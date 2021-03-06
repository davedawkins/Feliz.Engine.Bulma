module Types

type Modifier = {
    Name : string
    Values : string list
}

type StrVal =
    | Literal of string
    | ArgRef of string

type ElementVal = {
    Tag : StrVal
    Class : StrVal option
    Type : StrVal option
    Children : Node list
}
and Node =
    | TextNode of StrVal
    | ElementNode of ElementVal
    | ValueParamNodes

type ElChild =
    | Class of StrVal
    | Type of StrVal
    | ValueParam
    | Node of Node

type Member = {
    Name : string
    Params : (string * string) list
    Body : ElChild
}

type SubGroup = {
    Name : string // By Default this is the class
    Members : (Member * bool) list
}

let makeMember name parms body = { Name = name; Params = parms; Body = body }

// Constructors
let mkMods (name : string) (values : string list) = { Name = name; Values = values }

let makeElVal tag cls typ children = { Tag = tag; Class = cls; Type = typ; Children = children }

let text (v : StrVal) = TextNode v |> ElChild.Node

let class' (cls:StrVal) = ElChild.Class cls
let type' (typ:StrVal) = ElChild.Type typ
let valueParam = ElChild.ValueParam

let el (tag:StrVal) (children : ElChild list) =
    let rec build mn (args : ElChild list) =
        match args with
        | [] -> mn
        | x :: xs ->
            match x with
            | Class c -> build { mn with Class = Some c } xs
            | ElChild.Type t -> build { mn with Type = Some t } xs
            | ValueParam -> build { mn with Children = mn.Children @ [ ValueParamNodes ] } xs
            | Node n -> build { mn with Children = mn.Children @ [n] } xs

    build (makeElVal tag None None []) children |> ElementNode |> ElChild.Node

let makeSubMember (name:string) args node = fun cls -> makeMember name args node, true
let makeSubMemberMin (name:string) args node = fun cls -> makeMember name args node, false

let makeSubGroup nameIsClass members =
    {
        Name = nameIsClass;
        Members = members |> List.map (fun m -> m nameIsClass)
        }

let makeSubAll nameIsTag = fun cls ->
    makeMember nameIsTag [] (el (Literal nameIsTag) [ class' (Literal cls); ValueParam]), true

let makeSubMin nameIsTag = fun cls ->
    makeMember nameIsTag [] (el (Literal nameIsTag) [ class' (Literal cls); ValueParam]), false

let makeSubCls nameIsTag secondClass = fun cls ->
    makeMember nameIsTag [] (el (Literal nameIsTag) [ class' (Literal cls); class' (Literal secondClass); ValueParam]), true

let makeSubNested nameIsTagInner tagOuter clsInner = fun _ ->
    makeMember nameIsTagInner [] (el (Literal tagOuter) [
        el (Literal nameIsTagInner) [
            class' (Literal clsInner)
            ValueParam]]
    ), true

let makeSubNestedMin nameIsTagInner tagOuter clsInner = fun _ ->
    makeMember nameIsTagInner [] (el (Literal tagOuter) [
        el (Literal nameIsTagInner) [
            class' (Literal clsInner)
            ValueParam]]
    ), false

let makeSubType nameIsType tag = fun cls ->
    makeMember nameIsType [] (el (Literal tag) [ class' (Literal cls); type' (Literal nameIsType); ValueParam]), true
    //MemberCompat.Type (tag,nameIsType), true

let makeSubTypeMin nameIsType tag = fun cls ->
    makeMember nameIsType [] (el (Literal tag) [ class' (Literal cls); type' (Literal nameIsType); ValueParam]), false
    //MemberCompat.Type (tag,nameIsType), false

let makeMainMember tag cls = makeMember cls [] (el (Literal tag) [ class' (Literal cls);ValueParam ])

let makeAll (cls : string) tag = makeMainMember tag cls, true
let makeMin (cls : string) tag = makeMainMember tag cls, false

let makeDslAll name el = makeMember name [] el , true
let makeDslMin name el = makeMember name [] el , false
