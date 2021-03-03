module App

open Sutil.DOM
open Feliz

let bulma = Feliz.BulmaEngine.BulmaEngine<NodeFactory>( Html, Attr )

let b = bulma /// Can reduce "bulma" noise even further
let m = bulma.m  /// Access helper to reduce noise

/// ... or you can have it more verbose
let hero = bulma.m.hero /// Allows you to do  hero.isFullheight if you want
let color = bulma.m.color /// For example, color.isDanger

let app() =
    bulma.hero [
        m.hero.isFullheight
        m.color.isLight
        bulma.section [
            bulma.container [
               text "Hello world"
               bulma.button.button [
                   m.color.isDanger
                   text "Button"
               ]
               bulma.button.a [
                   m.color.isInfo
                   text "Link"
               ]
               bulma.button.span "Span"
            ]
        ]
    ]

app() |> mountElement "sutil-app"
