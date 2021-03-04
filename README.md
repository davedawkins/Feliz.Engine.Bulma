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

This is part of a Sutil example:

```fs
        bulma.heroBody [
            bulma.container [
                bulma.columns [
                    columns.isCentered
                    bulma.column [
                        column.is10Tablet; column.is8Desktop; column.is6Widescreen
                        bulma.box [
                            on "submit" (fun _ -> AttemptLogin |> dispatch) [PreventDefault]
                            Attr.action ""

                            bulma.field.div [
                                class' "has-text-danger"
                                Bind.fragment (model .> message) DOM.text
                            ] |> Transition.showIf (model .> messageIsSet)

                            bulma.field.div [
                                bulma.label "Email"
                                bulma.control.div [
                                    control.hasIconsLeft
                                    bulma.input.email [

                                        bindEvent "input" (fun e -> EventHelpers.validity(e).valid |> not) (fun s -> bindClass s "is-danger")

                                        Attr.placeholder "Hint: sutil@gmail.com"
                                        Bind.attr ("value", model .> username , SetUsername >> dispatch)
                                        Attr.required true
                                    ]
                                    bulma.icon [
                                        icon.isSmall
                                        icon.isLeft
                                        fa "envelope"
                                    ]
                                ]
                            ]
```

