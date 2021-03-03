module Types

open Identifier

type Element = {
    Name : string
    Tag : string
    Cls : string
    Text : bool // Can have int/float/string overload
}

type Modifier = {
    Name : string
    Values : string list
}

type SubItem =
    | Tag of string // All member overloads, group name as class
    | ExtraClass of TagName:string * ClassName:string // As "All" but with addition class
    | Emmet of TagName:string * string // About 5 cases where we have a nested structure
    | Type of TagName:string * Type:string // As "All", but with additional "type" attr, which is also the name of the members

type SubGroup = {
    Name : string // By Default this is the class
    Items : (SubItem * bool) list
}
// Constructors
let mkMods (name : string) (values : string list) = { Name = name; Values = values }
let makeAll (cls : string) tag = { Name = cls.KebabToCamelCase(); Tag = tag; Cls = cls; Text = true }
let makeMin (cls : string) tag = { Name = cls.KebabToCamelCase(); Tag = tag; Cls = cls; Text = false }
//let makeSub (cls : string) tag = { Name = (cls + "-" + tag).KebabToCamelCase(); Tag = tag; Cls = cls; Text = true }

let makeSubGroup nameIsClass members = { Name = nameIsClass; SubGroup.Items = members }
let makeSubAll nameIsTag = SubItem.Tag nameIsTag, true
let makeSubMin nameIsTag =  SubItem.Tag nameIsTag, false
let makeSubCls nameIsTag secondClass = SubItem.ExtraClass (nameIsTag,secondClass), true
let makeSubFmt name fmt = Emmet (name,fmt), true // FIXME: some don't have text overloads
let makeSubType nameIsType tag = SubItem.Type (tag,nameIsType), true

