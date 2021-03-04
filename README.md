# Feliz.BulmaEngine [![Nuget](https://img.shields.io/nuget/v/Feliz.BulmaEngine.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Feliz.BulmaEngine)

An F# implementation of Bulma layered on top of [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine), based on the work of Roman Provazník in [Feliz.Bulma](https://github.com/Dzoukr/Feliz.Bulma).

## Comparison with Feliz.Bulma / I'm just looking for Bulma for Feliz

Feliz.Bulma is implemented on top of Feliz, a DOM DSL for the React framework. **If your project uses Feliz, Feliz.Bulma is what you need.**

Feliz.BulmaEngine is implemented on top of Feliz.Engine, an abstract Feliz-like DSL which can be implemented for any DOM-builder backend, client-side
or server-side.

This means that given an implementation of Feliz.Engine for a particular framework, Feliz.BulmaEngine gives you a Bulma DSL for free.

## Bulma Framework Generation

The Feliz.BulmaEngine repository includes a code generator for Bulma, which was used to generate this library. It should make it
easier to incorporate updates to Bulma and then regenerate the library. Of course, others may also find it useful for their own Bulma projects. The data files for the generator were converted from the source files of Roman's Feliz.Bulma project.

See folder `./gen` in the repository for the code generator.

## Coverage

This is the status of Feliz.BulmaEngine with respect to Feliz.Bulma, which is a complete implementation of Bulma:

- Top-level elements (eg, bulma.hero)   78 /  83
- Sub-elements (eg, bulma.button.span)  23 /  24
- Modifiers (eg is-fullheight)         760 / 760
- Extensions (eg DateTimePicker)         0 /  11

## Example code

This is part of a test app, targeting the Sutil framework.

```fs
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
```

