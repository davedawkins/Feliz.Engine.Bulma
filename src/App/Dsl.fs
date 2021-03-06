module Dsl

open Feliz
open Browser.Types
open Browser.Dom

// ----------------------------------------------------------------------------
// Very simple DOM DSL
type NodeFactory = Node -> Node

let el (tag : string) (children : NodeFactory seq) : NodeFactory = fun (parent:Node) ->
    let e = document.createElement(tag)
    for child in children do
        child e |> ignore
    parent.appendChild(e) |> ignore
    upcast e

let text v : NodeFactory = fun parent ->
    let n = document.createTextNode(v)
    parent.appendChild(n) |> ignore
    upcast n

let attr (key:string,value:obj) : NodeFactory = fun (parent:Node) ->
    let el = parent :?> HTMLElement
    if key = "class" then
        let classes = (string value).Split(' ')
        for cls in classes do
            if cls <> "" then el.classList.add(cls)
    else
        el.setAttribute( key, string value )
    parent

let class' cls = attr("class",cls)

let mountElement (id:string) (app:NodeFactory) =
    let root = document.querySelector("#" + id)
    app root |> ignore

// ----------------------------------------------------------------------------
// Feliz.Engine for our simple DSL

let Html = HtmlEngine( {new HtmlHelper<NodeFactory> with
            member _.MakeNode(tag, nodes) = el tag nodes
            member _.StringToNode(v) = text v
            member _.EmptyNode = Unchecked.defaultof<_>
            })

let Attr =
    AttrEngine
        { new AttrHelper<NodeFactory> with
            member _.MakeAttr(key, value) = attr(key, value)
            member _.MakeBooleanAttr(key, value) = attr(key, value) }
