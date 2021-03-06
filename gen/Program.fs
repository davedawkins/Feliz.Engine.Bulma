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

let subGroupTypeTemplate (name:string)=
    $"type {name.KebabToPascalCase()}Engine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) ="

let rec genSval (sval:StrVal) =
    match sval with
    |Literal s -> "\"" + s + "\""
    |ArgRef id -> id

let nodeIsValueParam node = match node with |ValueParamNodes -> true|_->false

let rec genNode vname node =
    match node with
    | ValueParamNodes ->
        $"h.fragment Helpers.ToElems(h,{vname})"
    | TextNode sval ->
        $"h.text {genSval sval}"
    | ElementNode ev ->
        let insertValue = ev.Children |> List.exists nodeIsValueParam
        let childItems = ev.Children |> List.filter (not << nodeIsValueParam) |> List.map (genNode vname)
        let cls = ev.Class |> Option.map genSval |> Option.defaultValue "\"\""
        let typ = ev.Type |> Option.map (fun t ->  [ $"a.type' {genSval t}" ]) |> Option.defaultValue []

        let typeWithChildItems = typ @ childItems
        let iv = if insertValue then $"Helpers.ToElems(h,{vname})" else ""
        let tci = "[" + String.Join(";",typeWithChildItems) + "]"

        let finalChildItems =
            match (insertValue, typeWithChildItems.IsEmpty) with
            | true, false -> $"{tci} @ {iv}" // Join them
            | true, true -> $"{iv}" // Just the "Helpers.ToElems" call
            | _,_ -> tci // No "Helpers.ToElems", just use typeWithChildItems

        $"Helpers.MakeNode(h,a, {genSval ev.Tag}, {cls}, {finalChildItems})"

let genBody vname elchild =
    match elchild with
    | Node node -> genNode vname node
    | _ -> failwith "Must be a node"

let wrfn (name:string) (tag:string) (cls:string) (vname:string) (vtype:string) =
    sprintf "    member _.%s (%s: %s) = Helpers.MakeNode(h, a, \"%s\", \"%s\", %s)"
                name vname vtype tag cls vname

let genMember (m:Member) (vname:string) (vtype:string) =
    let args = m.Params |> List.fold (fun s (n,v) -> $"{s}{n}: {v}, ") ""
    let body = genBody vname m.Body
    $"    member _.{m.Name.KebabToCamelCase()} ({args}{vname}: {vtype}) = {body}"

//let genMemberCompat (groupName: string) (item:MemberCompat) (vname:string) (vtype:string) =
//    match item with
//    | MemberCompat.Tag tag -> wrfn tag tag groupName vname vtype
//    | MemberCompat.ExtraClass (tag,cls) -> wrfn tag tag $"{groupName} {cls}" vname vtype
//    | MemberCompat.Type (tag,typ) ->
//        $"    member _.{typ.KebabToCamelCase()} ({vname}: {vtype}) = Helpers.MakeNode(h,a,\"{tag}\", \"{groupName}\", [ a.type' \"{typ}\" ] @ (Helpers.ToElems(h,{vname})))"
//    | MemberCompat.Nested (tag, outerTag, cls) ->
//        $"    member _.{tag.KebabToCamelCase()} ({vname}: {vtype}) = Helpers.MakeNode(h,a,\"{outerTag}\", \"\", Helpers.MakeNode(h,a,\"{tag}\",\"{cls}\",{vname}) )"
//    | MemberCompat.Member m -> genMember m vname vtype


let bulmaElements (indent:int) : string[] =
    let ws = String(' ', indent)
    //let wrfn (e:Element) (vname:string) (vtype:string) =
    //    sprintf "%smember _.%s (%s: %s) = Helpers.MakeNode(h, a, \"%s\", \"%s\", %s)"
    //                ws e.Name vname vtype e.Tag e.Cls vname

    let gen (m : Member, hasTextOverloads : bool) =
        seq {
            if (hasTextOverloads) then
                genMember m "value" "string"
                genMember m "value" "int"
                genMember m "value" "float"
            genMember m "value" "'Element"
            genMember m "children" "seq<'Element>"

//                wrfn e "value" "string"
//                wrfn e "value" "int"
//                wrfn e "value" "float"
//            wrfn e "value" "'Element"
//            wrfn e "children" "seq<'Element>"
            ""
        } |> List.ofSeq

    Elements |> List.fold (fun lines el -> lines @ gen el) [ ] |> Array.ofList


let bulmaSubGroupTypes (indent:int) : string[] =
    let ws = String(' ', indent)
    let gen (g:SubGroup) =
        seq {
            ""
            subGroupTypeTemplate g.Name
            for (item,hasTextOverloads) in g.Members do
                if (hasTextOverloads) then
                    genMember item "value" "string"
                    genMember item "value" "int"
                    genMember item "value" "float"
                genMember item "value" "'Element"
                genMember item "children" "seq<'Element>"
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
    let target  = "../src/Feliz.Engine.Bulma"

    for template in templates do
        generateFrom template target

    0 // return an integer exit code