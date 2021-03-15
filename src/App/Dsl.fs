module Dsl

open System
open Feliz
open Browser.Types
open Browser.Dom

// ----------------------------------------------------------------------------
// Very simple DOM DSL
type NodeFactory = Node -> Node

let empty : NodeFactory = id

let el (tag : string) (children : NodeFactory seq) : NodeFactory = fun (parent:Node) ->
    let e = document.createElement(tag)
    for child in children do
        child e |> ignore
    parent.appendChild(e) |> ignore
    upcast e

let fragment (nodes : NodeFactory seq) : NodeFactory = fun (parent:Node) ->
    nodes |> Seq.iter (fun n -> parent |> n |> ignore)
    parent

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

let Html = HtmlEngine<NodeFactory>( el, text, fun () -> empty );

let Attr = AttrEngine<NodeFactory>( (fun k v -> attr(k,v)), (fun k v -> attr(k,v)) )
