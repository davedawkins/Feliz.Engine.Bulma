// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.IO
open Types
open Identifier
open Elements
open Modifiers

let Classes = Modifiers |> List.collect (fun m -> m.Values) |> List.sort |> List.distinct

let doNotEdit src = [|
    "// --------------------------------------------------------"
    "// !!! DO NOT EDIT !!!"
    "// Generated from " + src
    "// --------------------------------------------------------"
    ""
    |]

let classLiteral (c:string) = $"ClassLiterals.``{c}``"

let bulmaClasses (indent:int) : string[] =
    let ws = String(' ', indent)
    let fmt (c:string) = $"{ws}let [<Literal>] ``{c}`` = \"{c}\""
    Classes |> List.map fmt |> List.toArray

let bulmaModifierMembers (indent:int) : string[] =
    let ws = String(' ', indent)

    let fmtBlock (m:Modifier) =
        ([
            $"{ws}member _.{m.Name} = {m.Name.UpperFirst()}ModifiersEngine<'Element>(a)"
            ])
    Modifiers |> List.collect fmtBlock |> List.toArray

let bulmaModifierLetBindings (indent:int) : string [] =
    let ws = String(' ', indent)

    let fmt (m:Modifier) =
        $"let {m.Name} = bulma.m.{m.Name}"

    Modifiers |> List.map fmt |> List.toArray

let bulmaModifiers (indent:int) : string[] =
    let ws = String(' ', indent)

    let fmt (c : string) =
        $"    member _.{c.KebabToCamelCase()} = a.className({classLiteral(c)})"
    let fmtBlock (m:Modifier) =
        ([
            $"type {m.Name.UpperFirst()}ModifiersEngine<'Element>(a : AttrEngine<'Element>) ="
            ])
        @ (m.Values |> List.map fmt)
        @ [ " " ]

    Modifiers |> List.collect fmtBlock |> List.toArray

let bulmaElements (indent:int) : string[] =
    let ws = String(' ', indent)
    let wrfn (e:Element) (vname:string) (vtype:string) =
        sprintf "%smember _.%s (%s: %s) = Helpers.MakeNode(h, a, \"%s\", \"%s\", %s)"
                    ws e.Name vname vtype e.Tag e.Cls vname
    let gen e =
        seq {
            if (e.Text) then
                wrfn e "value" "string"
                wrfn e "value" "int"
                wrfn e "value" "float"
            wrfn e "value" "'Element"
            wrfn e "children" "seq<'Element>"
            ""
        } |> List.ofSeq

    Elements |> List.fold (fun lines el -> lines @ gen el) [ ] |> Array.ofList

let subGroupTypeTemplate (name:string)=
    $"type {name.KebabToPascalCase()}Engine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    do()"

let bulmaSubGroupTypes (indent:int) : string[] =
    let ws = String(' ', indent)
    let wrfn (name:string) (tag:string) (cls:string) (vname:string) (vtype:string) =
        sprintf "    member _.%s (%s: %s) = Helpers.MakeNode(h, a, \"%s\", \"%s\", %s)"
                    name vname vtype tag cls vname

    let genMember (groupName: string) (item:SubItem) (vname:string) (vtype:string) =
        match item with
        | SubItem.Tag tag -> wrfn tag tag groupName vname vtype
        | SubItem.ExtraClass (tag,cls) -> wrfn tag tag $"{groupName} {cls}" vname vtype
        | SubItem.Type (tag,typ) ->
            $"    member _.{typ.KebabToCamelCase()} ({vname}: {vtype}) = Helpers.MakeNode(h,a,\"{tag}\", \"{groupName}\", [ a.type' \"{typ}\" ] @ (Helpers.ToElems(h,{vname})))"
        | _ -> ""

    let gen (g:SubGroup) =
        seq {
            ""
            subGroupTypeTemplate g.Name
            for (item,hasTextOverloads) in g.Items do
                if (hasTextOverloads) then
                    genMember g.Name item "value" "string"
                    genMember g.Name item "value" "int"
                    genMember g.Name item "value" "float"
                genMember g.Name item "value" "'Element"
                genMember g.Name item "children" "seq<'Element>"
            ""
        } |> List.ofSeq

    SubElements |> List.fold (fun lines subGroup -> lines @ gen subGroup) [ ] |> Array.ofList

let bulmaSubGroupLetBindings (indent:int) : string[] =
    let ws = String(' ', indent)

    let fmt g =
        let name = g.Name.KebabToCamelCase()
        $"{ws}let _{name} = {g.Name.KebabToPascalCase()}Engine(h,a)"

    SubElements |> List.map fmt |> Array.ofList

let bulmaSubGroupMembers (indent:int) : string[] =
    let ws = String(' ', indent)

    let fmt g =
        let name = g.Name.KebabToCamelCase()
        $"{ws}member _.{name} = _{name}"

    SubElements |> List.map fmt |> Array.ofList

let generateFromCommand (indent:int) (cmd:string) : string [] =
    match cmd with
    | "bulmaClasses"   -> bulmaClasses   indent
    | "bulmaModifiers" -> bulmaModifiers indent
    | "bulmaModifierMembers" -> bulmaModifierMembers indent
    | "bulmaElements"  -> bulmaElements  indent
    | "bulmaSubGroupTypes"  -> bulmaSubGroupTypes  indent
    | "bulmaSubGroupLetBindings"  -> bulmaSubGroupLetBindings  indent
    | "bulmaModifierLetBindings" -> bulmaModifierLetBindings indent
    | "bulmaSubGroupMembers"  -> bulmaSubGroupMembers  indent
    | _ -> failwith ("Unknown generator command: " + cmd)

let generateFromLine (line:string) =
    if line.Trim().StartsWith("//%") then
        let i = line.IndexOf('/')
        generateFromCommand i (line.[(i+3)..].Trim())
    else
        [| line |]

let generateFrom (source:string) (targetDir:string) =
    let target = Path.Combine( targetDir, Path.GetFileName(source).Replace(".template",""))
    let lines = File.ReadAllLines( source )

    File.WriteAllLines(  target, Array.append (doNotEdit source) (lines |> Array.collect generateFromLine)  )
    Console.WriteLine("Generated \"{0}\" from \"{1}\"", target, source)

[<EntryPoint>]
let main argv =

    let templates = System.IO.Directory.EnumerateFiles("templates", "*.template.fs") |> List.ofSeq
    let target  = "../src/Feliz.BulmaEngine"

    for template in templates do
        generateFrom template target

    0 // return an integer exit code