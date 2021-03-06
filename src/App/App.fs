module App

open Dsl
open Dsl.Bulma

let text (s:string) = Html.text s

// Bulma for our simple DSL
let app() =
    bulma.section [
        bulma.columns [
            bulma.column [ column.is3 ]
            bulma.column [
                column.is6
                bulma.field.div [
                    bulma.label [
                        text "Name"
                    ]
                    bulma.control.div [
                        bulma.input.text [
                            Attr.placeholder "Text input"
                        ]
                    ]
                ]
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
                bulma.field.div [
                    bulma.label [
                        text "Email"
                    ]
                    bulma.control.div [
                        control.hasIconsLeft
                        control.hasIconsRight
                        bulma.input.email [
                            color.isDanger
                            Attr.placeholder "Email input"
                            Attr.value "hello@"
                        ]
                        bulma.icon [
                            icon.isSmall
                            icon.isLeft
                            Html.i [ class' "fa fa-envelope" ]
                        ]
                        bulma.icon [
                            icon.isSmall
                            icon.isRight
                            Html.i [ class' "fa fa-exclamation-triangle" ]
                        ]
                    ]
                    bulma.help [
                        color.isDanger
                        text "This email is invalid"
                    ]
                ]

                bulma.field.div [
                    bulma.label [ text "Subject "]
                    bulma.control.div [
                        bulma.select [
                            Html.option [ text "Select dropdown" ]
                            Html.option [ text "With options" ]
                        ]
                    ]
                ]

                bulma.field.div [
                    bulma.label [ text "Message" ]
                    bulma.control.div [
                        bulma.textarea [
                            Attr.placeholder "Textarea"
                        ]
                    ]
                ]

                bulma.field.div [
                    bulma.control.div [
                        bulma.inputLabels.checkbox [
                            bulma.input.checkbox [ ]
                            text " I agree to the "
                            Html.a [
                                Attr.href "#"
                                text "terms and conditions"
                            ]
                        ]
                    ]
                ]

                bulma.field.div [
                    bulma.control.div [
                        bulma.inputLabels.radio [
                            bulma.input.radio [ Attr.name "question"]
                            text " Yes"
                        ]
                        bulma.inputLabels.radio [
                            bulma.input.radio [ Attr.name "question"]
                            text " No"
                        ]
                    ]
                ]

                bulma.field.div [
                    field.isGrouped
                    bulma.control.div [
                        bulma.button.button [
                            color.isLink; text "Submit"
                        ]
                    ]
                    bulma.control.div [
                        bulma.button.button [
                            color.isLink; color.isLight; text "Cancel"
                        ]
                    ]
                ]

            ]
        ]
    ]

app() |> mountElement "dsl-app"
