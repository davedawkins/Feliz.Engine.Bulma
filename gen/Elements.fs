module Elements

open Types
open Constructors

let Elements = [
    makeAll "container"       "div"
    makeMin "level"           "nav"
    makeAll "level-left"      "div"
    makeAll "level-right"     "div"
    makeAll "level-item"      "div"
    makeAll "media"           "article"
    makeAll "media-left"      "div"
    makeAll "media-right"     "div"
    makeAll "media-content"   "div"
    makeMin "hero"            "section"
    makeAll "hero-body"       "div"
    makeAll "hero-head"       "div"
    makeAll "hero-foot"       "div"
    makeAll "field-label"      "div"
    makeAll "field-body"       "div"
    makeDslAll "file-input"    (el (Literal "input") [ class' (Literal "file-input"); type' (Literal "file"); value' ]) // input:type=file"
    makeMin "file-cta"         "span"
    makeAll "file-name"        "span"
    makeMin "file-icon"        "span"
    makeMin "section"         "section"
    makeMin "footer"          "footer"
    makeAll "tile"            "div"
    makeAll "columns"         "div"
    makeAll "column"          "div"
    makeAll "label"           "label"
    makeMin "textarea"        "textarea"
    makeDslMin "select"       (el (Literal "div") [ class' (Literal "select"); el (Literal "select") [ value' ]] )   //"div.select select" //TODO
    makeMin "icon"            "span"
    makeMin "file"        "div"
    makeAll "block"       "div"
    makeAll "box"         "div"
    makeMin "buttons"     "div"
    makeAll "content"         "div"
    makeMin "delete"         "button"
    makeMin "image"         "figure"
    makeAll "notification"         "div"
    makeAll "progress"         "progress"
    makeMin "table"         "table"
    makeMin "table-container"         "div"
    makeAll "tag"          "span"
    makeMin "tags"         "div"
    makeMin "breadcrumb"   "nav"
    makeMin "card"         "div"
    makeMin "card-header"  "header"
    makeMin "card-image"         "div"
    makeAll "card-content"         "div"
    makeMin "card-footer"         "footer"
    makeMin "dropdown"         "div"
    makeMin "dropdown-trigger"         "div"
    makeMin "dropdown-menu"         "div"
    makeMin "dropdown-content"         "div"
    makeMin "dropdown-divider"         "hr"
    makeMin "menu"         "aside"
    makeAll "menu-label"         "p"
    makeMin "menu-list"         "ul"
    makeMin "message"         "article"
    makeMin "message-header"         "div"
    makeAll "message-body"         "div"
    makeMin "modal"         "div"
    makeMin "modal-background"         "div"
    makeMin "modal-close"         "button"
    makeAll "modal-content"         "div"
    makeMin "modal-card"         "div"
    makeMin "modal-card-head"         "header"
    makeMin "modal-card-body"         "section"
    makeMin "modal-card-foot"         "footer"
    makeAll "modal-card-title"         "p"
    makeMin "navbar"         "nav"
    makeMin "navbar-divider"         "hr"
    makeMin "navbar-menu"         "div"
    makeMin "navbar-burger"         "a"
    makeMin "pagination"    "nav"
    makeMin "pagination-list"   "ul"
    makeDslMin "pagination-ellipsis"
        (el (Literal "li")
            [ el (Literal "span") [
                    class' (Literal "pagination-ellipsis")
                    text (Literal "…") // "&hellip;"
                    value' ]])
    makeMin "panel" "nav"
    makeMin "panel-heading" "p"
    makeMin "panel-tabs" "p"
    makeMin "panel-icon" "span"
    makeMin "tabs" "div"
    makeMin "tab" "li"
    makeAll "help" "p"
    //makeAll "title" "h1" // Clash with subgroup title :-(
    //makeAll "subtitle" "h2" // Clash with subgroup subtitle :-(
]


let SubElements = [
    makeSubGroup "button" [
        makeSubAll "button"
        makeSubAll "a"
        makeSubAll "span"
        makeSubType "submit" "input"
        makeSubType "reset" "input"
    ]
    makeSubGroup "title" [
        makeSubAll "h1"
        makeSubAll "h2"
        makeSubAll "h3"
        makeSubAll "h4"
        makeSubAll "h5"
        makeSubAll "h6"
        makeSubNameTagCls "h1" "is-1"
        makeSubNameTagCls "h2" "is-2"
        makeSubNameTagCls "h3" "is-3"
        makeSubNameTagCls "h4" "is-4"
        makeSubNameTagCls "h5" "is-5"
        makeSubNameTagCls "h6" "is-6"
        makeSubAll "p"
    ]
    makeSubGroup "subtitle" [
        makeSubAll "h1"
        makeSubAll "h2"
        makeSubAll "h3"
        makeSubAll "h4"
        makeSubAll "h5"
        makeSubAll "h6"
        makeSubNameTagCls "h1" "is-1"
        makeSubNameTagCls "h2" "is-2"
        makeSubNameTagCls "h3" "is-3"
        makeSubNameTagCls "h4" "is-4"
        makeSubNameTagCls "h5" "is-5"
        makeSubNameTagCls "h6" "is-6"
        makeSubAll "p"
    ]
    makeSubGroup "control" [
        makeSubMin "div"
        makeSubMin "p"
    ]
    makeSubGroup "field" [
        makeSubAll "div"
        makeSubAll "p"
    ]
    makeSubGroup "file-label" [
        makeSubAll "label"
        makeSubAll "span"
    ]
    makeSubGroup "card-header-title" [
        makeSubAll "div"
        makeSubAll "p"
    ]
    makeSubGroup "card-header-icon" [
        makeSubAll "a"
        makeSubAll "span"
    ]
    makeSubGroup "card-footer-item" [
        makeSubAll "div"
        makeSubAll "p"
        makeSubAll "a"
    ]
    makeSubGroup "dropdown-item" [
        makeSubAll "a"
        makeSubAll "div"
        // TODO: Based on docs (https://bulma.io/documentation/components/dropdown/) only A and DIV is allowed - is BUTTON ok here?
        makeSubAll "button"
    ]
    makeSubGroup "menu-item" [
        makeSubNested "a" "li" "" // li.a
    ]
    makeSubGroup "navbar-brand" [
        makeSubMin "div"
        makeSubMin "a"
    ]
    makeSubGroup "navbar-start" [
        makeSubMin "div"
        makeSubMin "a"
    ]
    makeSubGroup "navbar-end" [
        makeSubMin "div"
        makeSubMin "a"
    ]
    makeSubGroup "navbar-item" [
        makeSubMin "div"
        makeSubMin "a"
    ]
    makeSubGroup "navbar-link" [
        makeSubAll "div"
        makeSubAll "a"
    ]
    makeSubGroup "navbar-dropdown" [
        makeSubMin "div"
        makeSubMin "a"
    ]
    makeSubGroup "pagination-previous" [
        makeSubAll "a"
        makeSubAll "button"
    ]
    makeSubGroup "pagination-next" [
        makeSubAll "a"
        makeSubAll "button"
    ]
    makeSubGroup "pagination-link" [
        makeSubMember "a"      [] (el (Literal "li") [ (el (Literal "a"     ) [ class' (Literal "pagination-link") ]) ])
        makeSubMember "button" [] (el (Literal "li") [ (el (Literal "button") [ class' (Literal "pagination-link") ]) ])
    ]
    makeSubGroup "panel-block" [
        makeSubAll "div"
        makeSubAll "a"
        makeSubAll "label"
        makeSubAll "p"
    ]
    makeSubGroup "input" [
        makeSubType "text" "input"
        makeSubType "password" "input"
        makeSubType "datetime-local" "input"
        makeSubType "date" "input"
        makeSubType "month" "input"
        makeSubType "time" "input"
        makeSubType "week" "input"
        makeSubType "url" "input"
        makeSubType "search" "input"
        makeSubType "color" "input"
        makeSubType "email" "input"
        makeSubType "tel" "input"
        makeSubType "number" "input"
        makeSubMember "checkbox" [ ] (el (Literal "input") [ type' (Literal "checkbox"); value' ] )
        makeSubMember "radio" [ ] (el (Literal "input") [ type' (Literal "radio"); value' ] )
        makeSubMember
            "label-checkbox"
            [ "label", "string" ]
            (el (Literal "label") [
                class' (Literal "checkbox")
                (el (Literal "input") [ type' (Literal "checkbox"); value' ])
                (text (ArgRef "label"))
            ])
    ]

    makeSubGroup "input-labels" [
        makeSubMemberMin "checkbox" [] (el (Literal "label") [ class' (Literal "checkbox"); value' ])
        makeSubMemberMin "radio" [] (el (Literal "label") [ class' (Literal "radio"); value' ])
    ]

    makeSubGroup "text" [
        makeSubMin "p"
        makeSubMin "div"
        makeSubMin "span"
    ]
]
