module Constructors

open Types

// ----------------------------------------------------------------------------
// Record constructors
let makeMember name parms body =
    { Name = name; Params = parms; Body = body }

let mkMods (name : string) (values : string list) =
    { Name = name; Values = values }

let makeElVal tag cls typ children =
    { Tag = tag; Class = cls; Type = typ; Children = children }

let makeSubGroup nameIsClass members =
    { Name = nameIsClass; Members = members |> List.map (fun m -> m nameIsClass) }

// ----------------------------------------------------------------------------
// DSL constructors
let text (v : StrVal) = TextNode v |> ElChild.Node
let class' (cls:StrVal) = ElChild.Class cls
let type' (typ:StrVal) = ElChild.Type typ
let value' = ElChild.ValueParam // Placeholder for overloaded value: int, float, text, Node, Node list
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

// ----------------------------------------------------------------------------
// makeSub*: Subgroup constructors (eg bulma.button.span)
// make*Min: Generate only Node, Node list overloads, no int/float/string overloads
// make*All: Generate all overloads

let makeSubMember (name:string) args node = fun cls -> makeMember name args node, true
let makeSubMemberMin (name:string) args node = fun cls -> makeMember name args node, false

let makeSubAll nameIsTag = fun cls ->
    makeMember nameIsTag [] (el (Literal nameIsTag) [ class' (Literal cls); value']), true

let makeSubMin nameIsTag = fun cls ->
    makeMember nameIsTag [] (el (Literal nameIsTag) [ class' (Literal cls); value']), false

let makeSubCls nameIsTag secondClass = fun cls ->
    makeMember nameIsTag [] (el (Literal nameIsTag) [ class' (Literal cls); class' (Literal secondClass); value']), true

let makeSubNameTagCls  tag secondClass = fun cls ->
    makeMember (tag + "-" + secondClass) [] (el (Literal tag) [ class' (Literal cls); class' (Literal secondClass); value']), true

// ----------------------------------------------------------------------------
// tagOuter>tagInner.clsInner
//
let makeSubNested nameIsTagInner tagOuter clsInner = fun _ ->
    makeMember nameIsTagInner [] (el (Literal tagOuter) [
        el (Literal nameIsTagInner) [
            class' (Literal clsInner)
            value']]
    ), true

let makeSubNestedMin nameIsTagInner tagOuter clsInner = fun _ ->
    makeMember nameIsTagInner [] (el (Literal tagOuter) [
        el (Literal nameIsTagInner) [
            class' (Literal clsInner)
            value']]
    ), false

// ----------------------------------------------------------------------------
// Format: tag.cls:type=name>value
//
let makeSubType nameIsType tag = fun cls ->
    makeMember nameIsType [] (el (Literal tag) [ class' (Literal cls); type' (Literal nameIsType); value']), true
    //MemberCompat.Type (tag,nameIsType), true

let makeSubTypeMin nameIsType tag = fun cls ->
    makeMember nameIsType [] (el (Literal tag) [ class' (Literal cls); type' (Literal nameIsType); value']), false
    //MemberCompat.Type (tag,nameIsType), false

// ----------------------------------------------------------------------------
// Top-level members eg bulma.hero
// make*Min: Generate only Node, Node list overloads, no int/float/string overloads
// make*All: Generate all overloads
// Format: tag.cls>value
let makeMainMember tag cls = makeMember cls [] (el (Literal tag) [ class' (Literal cls); value' ])

// makeAll: make all overloads in form : tag.cls
let makeAll (cls : string) tag = makeMainMember tag cls, true
let makeMin (cls : string) tag = makeMainMember tag cls, false

// makeMin: make only child overloads, no text/int/float
let makeDslAll name el = makeMember name [] el , true
let makeDslMin name el = makeMember name [] el , false
