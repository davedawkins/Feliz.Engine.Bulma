# Feliz.Engine.Bulma [![Nuget](https://img.shields.io/nuget/v/Feliz.Engine.Bulma.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Feliz.Engine.Bulma)

An F# implementation of Bulma layered on top of [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine), based on the work of Roman Provazník in [Feliz.Bulma](https://github.com/Dzoukr/Feliz.Bulma).

## Comparison with Feliz.Bulma / I'm just looking for Bulma for Feliz

Feliz.Bulma is implemented on top of Feliz, a DOM DSL for the React framework. **If your project uses Feliz, Feliz.Bulma is what you need.**

Feliz.Engine.Bulma is implemented on top of Feliz.Engine, an abstract Feliz-like DSL which can be implemented for any DOM-builder backend, client-side
or server-side.

This means that given an implementation of Feliz.Engine for a particular framework, Feliz.Engine.Bulma gives you a Bulma DSL for free.

[Sutil](https://github.com/DaveDawkins/Sutil) uses both `Feliz.Engine` and `Feliz.Engine.Bulma`

## Bulma Framework Generation

The Feliz.Engine.Bulma repository includes a code generator for Bulma, which was used to generate this library. It should make it
easier to incorporate updates to Bulma and then regenerate the library. Of course, others may also find it useful for their own Bulma projects. The data files for the generator were converted from the source files of Roman's Feliz.Bulma project.

See folder `./gen` in the repository for the code generator.

## Coverage

This is the status of Feliz.Engine.Bulma with respect to Feliz.Bulma, which is a complete implementation of Bulma:

- Top-level elements (eg, bulma.hero)   83 /  83
- Sub-elements (eg, bulma.button.span)  24 /  24
- Modifiers (eg is-fullheight)         760 / 760
- Extensions (eg DateTimePicker)         0 /  11

## Usage

See example App in [src/App](https://github.com/davedawkins/Feliz.Engine.Bulma/blob/main/src/App) for full details.

Given an implementation of `Feliz.Engine` for a particular DSL, then the simplest way to get started is:

```fs
// Dsl is an example DOM building framework, and exports
open Dsl

// Html and Attr are instances of
// - Feliz.Engine.HtmlEngine<DslNode> and
// - Feliz.Engine.AttrEngine<DslNode> respectively
//

let bulma = Feliz.Engine.Bulma.BulmaEngine<DslNode>( Html, Attr )

```

However, you can copy & paste [src/Feliz.Engine.Bulma/Binding.fs](https://github.com/davedawkins/Feliz.Engine.Bulma/blob/main/src/Feliz.Engine.Bulma/Binding.fs) into your project (inserting the correct DSL types appropriately),
and you'll have additional shortcuts to modifiers such as `size.is6`, `color.isDanger` instead of `bulma.m.color.isDanger` etc.

```fs
// --------------------------------------------------------
// !!! DO NOT EDIT !!!
// Generated from templates/Binding.template.fs
// --------------------------------------------------------

// This isn't compiled into the Feliz.Engine.Bulma package. Copy it to your framework library
// and replace Framework and FrameworkElement appropriately. It isn't necessary, but it may
// help reduce some "bulma.m." boilerplate noise in your app

namespace Framework.Bulma

open Framework

let bulma = Feliz.Engine.Bulma.BulmaEngine<FrameworkElement>( Html, Attr )

let helpers = bulma.m.helpers
let size = bulma.m.size
let spacing = bulma.m.spacing
let text = bulma.m.text
// ... etc
```

## Example App

The example app in `src/App` implements the Bulma [form sampler](https://bulma.io/documentation/form/general/)

<img width="829" alt="Example App" src="https://user-images.githubusercontent.com/285421/110218799-87f29580-7eb3-11eb-8110-9f56f72104b1.png">

## Example code

This is part of the example App code:

```fs
    bulma.field.div [
        bulma.label [
            text "Username"
        ]
        bulma.control.div [
            control.hasIconsLeft
            control.hasIconsRight
            bulma.input.text [
                color.isSuccess
                Attr.placeholder "Text input"
                Attr.value "bulma"
            ]
            bulma.icon [
                icon.isSmall
                icon.isLeft
                Html.i [ class' "fa fa-user" ]
            ]
            bulma.icon [
                icon.isSmall
                icon.isRight
                Html.i [ class' "fa fa-check" ]
            ]
        ]
        bulma.help [
            color.isSuccess
            text "This username is available"
        ]
    ]
```

