# Feliz.BulmaEngine [![Nuget](https://img.shields.io/nuget/v/Feliz.BulmaEngine.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Feliz.BulmaEngine)

An F# implementation of Bulma layered on top of [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine), based on the work of Roman Provazník in [Feliz.Bulma](https://github.com/Dzoukr/Feliz.Bulma).

## Differences with Feliz.Bulma

Feliz.Bulma is implemented on top of Feliz, a DOM DSL for the React framework.

Feliz.BulmaEngine is implemented on top of Feliz.Engine, an abstract DSL which can be implemented for any DOM-builder backend, client-side
or server-side.

This means that given an implementation of Feliz.Engine for a particular framework, Feliz.BulmaEngine gives you a Bulma DSL for free.

## Bulma Framework Generation

The Feliz.BulmaEngine repository includes a code generator for Bulma, which used to generate this library. It should make it
easier to incorporate updates to Bulma and then regenerate the library. Of course, others may also find it useful for their own Bulma projects. The data files for the generator were converted from the source files of Roman's Feliz.Bulma project.

## Coverage

This is the status of Feliz.BulmaEngine with respect to Feliz.Bulma, which is a complete implementation of Bulma:

- Top-level elements (eg, bulma.hero)   78 /  83
- Sub-elements (eg, bulma.button.span)  23 /  24
- Modifiers (eg is-fullheight)         760 / 760
- Extensions (eg DateTimePicker)         0 /  11


