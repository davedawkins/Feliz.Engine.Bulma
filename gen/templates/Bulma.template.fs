namespace Feliz.BulmaEngine

open Feliz

type BulmaModifiersEngine<'Element>( a : AttrEngine<'Element> ) =
    //% bulmaModifierMembers

type private Helpers =

    static member ToElems (h : HtmlEngine<'Element>, v : float ) =
        [ h.text v ]

    static member ToElems (h : HtmlEngine<'Element>, v : int ) =
        [ h.text v ]

    static member ToElems (h : HtmlEngine<'Element>, v : string ) =
        [ h.text v ]

    static member ToElems (h : HtmlEngine<'Element>, child : 'Element ) =
        [ child ]

    static member ToElems (h : HtmlEngine<'Element>, children : seq<'Element> ) =
        children |> List.ofSeq

    //static member MakeNode (h : HtmlEngine<'Element>, a : AttrEngine<'Element>, tag:string, cls : string, elems : 'Element list ) =
    //    h.custom( tag, [ a.className cls ] @ elems )

    static member MakeNode (h : HtmlEngine<'Element>, a : AttrEngine<'Element>, tag:string, cls : string, v : float ) =
        h.custom( tag, [ a.className cls; h.text v ])

    static member MakeNode (h : HtmlEngine<'Element>, a : AttrEngine<'Element>, tag:string, cls : string, v : int ) =
        h.custom( tag, [ a.className cls; h.text v ])

    static member MakeNode (h : HtmlEngine<'Element>, a : AttrEngine<'Element>, tag:string, cls : string, child : 'Element ) =
        h.custom( tag, [ a.className cls; child ])

    static member MakeNode (h : HtmlEngine<'Element>, a : AttrEngine<'Element>, tag:string, cls : string, v : string ) =
        h.custom( tag, [ a.className cls; h.text v ])

    static member MakeNode (h : HtmlEngine<'Element>, a : AttrEngine<'Element>, tag:string, cls : string, children : seq<'Element> ) =
        h.custom( tag, [ a.className cls ] |> Seq.append children )

//% bulmaSubGroupTypes

type BulmaEngine<'Element>( h : HtmlEngine<'Element>, a : AttrEngine<'Element> ) =
    let _m = BulmaModifiersEngine<'Element>(a)
    //% bulmaSubGroupLetBindings

    member _.m = _m

    //% bulmaElements

    //% bulmaSubGroupMembers