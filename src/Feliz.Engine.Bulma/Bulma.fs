// --------------------------------------------------------
// !!! DO NOT EDIT !!!
// Generated from templates/Bulma.template.fs
// --------------------------------------------------------

namespace Feliz.Engine.Bulma

open Feliz

type BulmaModifiersEngine<'Element>( a : AttrEngine<'Element> ) =
    member _.helpers = HelpersModifiersEngine<'Element>(a)
    member _.size = SizeModifiersEngine<'Element>(a)
    member _.spacing = SpacingModifiersEngine<'Element>(a)
    member _.text = TextModifiersEngine<'Element>(a)
    member _.color = ColorModifiersEngine<'Element>(a)
    member _.image = ImageModifiersEngine<'Element>(a)
    member _.progress = ProgressModifiersEngine<'Element>(a)
    member _.table = TableModifiersEngine<'Element>(a)
    member _.tr = TrModifiersEngine<'Element>(a)
    member _.tag = TagModifiersEngine<'Element>(a)
    member _.tags = TagsModifiersEngine<'Element>(a)
    member _.title = TitleModifiersEngine<'Element>(a)
    member _.tabs = TabsModifiersEngine<'Element>(a)
    member _.tab = TabModifiersEngine<'Element>(a)
    member _.breadcrumb = BreadcrumbModifiersEngine<'Element>(a)
    member _.cardHeaderTitle = CardHeaderTitleModifiersEngine<'Element>(a)
    member _.dropdown = DropdownModifiersEngine<'Element>(a)
    member _.modal = ModalModifiersEngine<'Element>(a)
    member _.modalClose = ModalCloseModifiersEngine<'Element>(a)
    member _.navbar = NavbarModifiersEngine<'Element>(a)
    member _.navbarMenu = NavbarMenuModifiersEngine<'Element>(a)
    member _.navbarBurger = NavbarBurgerModifiersEngine<'Element>(a)
    member _.navbarDropdown = NavbarDropdownModifiersEngine<'Element>(a)
    member _.navbarLink = NavbarLinkModifiersEngine<'Element>(a)
    member _.navbarItem = NavbarItemModifiersEngine<'Element>(a)
    member _.paginationLink = PaginationLinkModifiersEngine<'Element>(a)
    member _.file = FileModifiersEngine<'Element>(a)
    member _.input = InputModifiersEngine<'Element>(a)
    member _.button = ButtonModifiersEngine<'Element>(a)
    member _.buttons = ButtonsModifiersEngine<'Element>(a)
    member _.fieldLabel = FieldLabelModifiersEngine<'Element>(a)
    member _.textarea = TextareaModifiersEngine<'Element>(a)
    member _.field = FieldModifiersEngine<'Element>(a)
    member _.icon = IconModifiersEngine<'Element>(a)
    member _.select = SelectModifiersEngine<'Element>(a)
    member _.control = ControlModifiersEngine<'Element>(a)
    member _.ol = OlModifiersEngine<'Element>(a)
    member _.content = ContentModifiersEngine<'Element>(a)
    member _.delete = DeleteModifiersEngine<'Element>(a)
    member _.container = ContainerModifiersEngine<'Element>(a)
    member _.level = LevelModifiersEngine<'Element>(a)
    member _.section = SectionModifiersEngine<'Element>(a)
    member _.hero = HeroModifiersEngine<'Element>(a)
    member _.tile = TileModifiersEngine<'Element>(a)
    member _.columns = ColumnsModifiersEngine<'Element>(a)
    member _.column = ColumnModifiersEngine<'Element>(a)

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


type ButtonEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.button (value: string) = Helpers.MakeNode(h,a, "button", "button", Helpers.ToElems(h,value))
    member _.button (value: int) = Helpers.MakeNode(h,a, "button", "button", Helpers.ToElems(h,value))
    member _.button (value: float) = Helpers.MakeNode(h,a, "button", "button", Helpers.ToElems(h,value))
    member _.button (value: 'Element) = Helpers.MakeNode(h,a, "button", "button", Helpers.ToElems(h,value))
    member _.button (children: seq<'Element>) = Helpers.MakeNode(h,a, "button", "button", Helpers.ToElems(h,children))
    member _.a (value: string) = Helpers.MakeNode(h,a, "a", "button", Helpers.ToElems(h,value))
    member _.a (value: int) = Helpers.MakeNode(h,a, "a", "button", Helpers.ToElems(h,value))
    member _.a (value: float) = Helpers.MakeNode(h,a, "a", "button", Helpers.ToElems(h,value))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "button", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "button", Helpers.ToElems(h,children))
    member _.span (value: string) = Helpers.MakeNode(h,a, "span", "button", Helpers.ToElems(h,value))
    member _.span (value: int) = Helpers.MakeNode(h,a, "span", "button", Helpers.ToElems(h,value))
    member _.span (value: float) = Helpers.MakeNode(h,a, "span", "button", Helpers.ToElems(h,value))
    member _.span (value: 'Element) = Helpers.MakeNode(h,a, "span", "button", Helpers.ToElems(h,value))
    member _.span (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "button", Helpers.ToElems(h,children))
    member _.submit (value: string) = Helpers.MakeNode(h,a, "input", "button", [a.type' "submit"] @ Helpers.ToElems(h,value))
    member _.submit (value: int) = Helpers.MakeNode(h,a, "input", "button", [a.type' "submit"] @ Helpers.ToElems(h,value))
    member _.submit (value: float) = Helpers.MakeNode(h,a, "input", "button", [a.type' "submit"] @ Helpers.ToElems(h,value))
    member _.submit (value: 'Element) = Helpers.MakeNode(h,a, "input", "button", [a.type' "submit"] @ Helpers.ToElems(h,value))
    member _.submit (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "button", [a.type' "submit"] @ Helpers.ToElems(h,children))
    member _.reset (value: string) = Helpers.MakeNode(h,a, "input", "button", [a.type' "reset"] @ Helpers.ToElems(h,value))
    member _.reset (value: int) = Helpers.MakeNode(h,a, "input", "button", [a.type' "reset"] @ Helpers.ToElems(h,value))
    member _.reset (value: float) = Helpers.MakeNode(h,a, "input", "button", [a.type' "reset"] @ Helpers.ToElems(h,value))
    member _.reset (value: 'Element) = Helpers.MakeNode(h,a, "input", "button", [a.type' "reset"] @ Helpers.ToElems(h,value))
    member _.reset (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "button", [a.type' "reset"] @ Helpers.ToElems(h,children))


type TitleEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.h1 (value: string) = Helpers.MakeNode(h,a, "h1", "title", Helpers.ToElems(h,value))
    member _.h1 (value: int) = Helpers.MakeNode(h,a, "h1", "title", Helpers.ToElems(h,value))
    member _.h1 (value: float) = Helpers.MakeNode(h,a, "h1", "title", Helpers.ToElems(h,value))
    member _.h1 (value: 'Element) = Helpers.MakeNode(h,a, "h1", "title", Helpers.ToElems(h,value))
    member _.h1 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h1", "title", Helpers.ToElems(h,children))
    member _.h2 (value: string) = Helpers.MakeNode(h,a, "h2", "title", Helpers.ToElems(h,value))
    member _.h2 (value: int) = Helpers.MakeNode(h,a, "h2", "title", Helpers.ToElems(h,value))
    member _.h2 (value: float) = Helpers.MakeNode(h,a, "h2", "title", Helpers.ToElems(h,value))
    member _.h2 (value: 'Element) = Helpers.MakeNode(h,a, "h2", "title", Helpers.ToElems(h,value))
    member _.h2 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h2", "title", Helpers.ToElems(h,children))
    member _.h3 (value: string) = Helpers.MakeNode(h,a, "h3", "title", Helpers.ToElems(h,value))
    member _.h3 (value: int) = Helpers.MakeNode(h,a, "h3", "title", Helpers.ToElems(h,value))
    member _.h3 (value: float) = Helpers.MakeNode(h,a, "h3", "title", Helpers.ToElems(h,value))
    member _.h3 (value: 'Element) = Helpers.MakeNode(h,a, "h3", "title", Helpers.ToElems(h,value))
    member _.h3 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h3", "title", Helpers.ToElems(h,children))
    member _.h4 (value: string) = Helpers.MakeNode(h,a, "h4", "title", Helpers.ToElems(h,value))
    member _.h4 (value: int) = Helpers.MakeNode(h,a, "h4", "title", Helpers.ToElems(h,value))
    member _.h4 (value: float) = Helpers.MakeNode(h,a, "h4", "title", Helpers.ToElems(h,value))
    member _.h4 (value: 'Element) = Helpers.MakeNode(h,a, "h4", "title", Helpers.ToElems(h,value))
    member _.h4 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h4", "title", Helpers.ToElems(h,children))
    member _.h5 (value: string) = Helpers.MakeNode(h,a, "h5", "title", Helpers.ToElems(h,value))
    member _.h5 (value: int) = Helpers.MakeNode(h,a, "h5", "title", Helpers.ToElems(h,value))
    member _.h5 (value: float) = Helpers.MakeNode(h,a, "h5", "title", Helpers.ToElems(h,value))
    member _.h5 (value: 'Element) = Helpers.MakeNode(h,a, "h5", "title", Helpers.ToElems(h,value))
    member _.h5 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h5", "title", Helpers.ToElems(h,children))
    member _.h6 (value: string) = Helpers.MakeNode(h,a, "h6", "title", Helpers.ToElems(h,value))
    member _.h6 (value: int) = Helpers.MakeNode(h,a, "h6", "title", Helpers.ToElems(h,value))
    member _.h6 (value: float) = Helpers.MakeNode(h,a, "h6", "title", Helpers.ToElems(h,value))
    member _.h6 (value: 'Element) = Helpers.MakeNode(h,a, "h6", "title", Helpers.ToElems(h,value))
    member _.h6 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h6", "title", Helpers.ToElems(h,children))
    member _.h1Is1 (value: string) = Helpers.MakeNode(h,a, "h1", "title is-1", Helpers.ToElems(h,value))
    member _.h1Is1 (value: int) = Helpers.MakeNode(h,a, "h1", "title is-1", Helpers.ToElems(h,value))
    member _.h1Is1 (value: float) = Helpers.MakeNode(h,a, "h1", "title is-1", Helpers.ToElems(h,value))
    member _.h1Is1 (value: 'Element) = Helpers.MakeNode(h,a, "h1", "title is-1", Helpers.ToElems(h,value))
    member _.h1Is1 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h1", "title is-1", Helpers.ToElems(h,children))
    member _.h2Is2 (value: string) = Helpers.MakeNode(h,a, "h2", "title is-2", Helpers.ToElems(h,value))
    member _.h2Is2 (value: int) = Helpers.MakeNode(h,a, "h2", "title is-2", Helpers.ToElems(h,value))
    member _.h2Is2 (value: float) = Helpers.MakeNode(h,a, "h2", "title is-2", Helpers.ToElems(h,value))
    member _.h2Is2 (value: 'Element) = Helpers.MakeNode(h,a, "h2", "title is-2", Helpers.ToElems(h,value))
    member _.h2Is2 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h2", "title is-2", Helpers.ToElems(h,children))
    member _.h3Is3 (value: string) = Helpers.MakeNode(h,a, "h3", "title is-3", Helpers.ToElems(h,value))
    member _.h3Is3 (value: int) = Helpers.MakeNode(h,a, "h3", "title is-3", Helpers.ToElems(h,value))
    member _.h3Is3 (value: float) = Helpers.MakeNode(h,a, "h3", "title is-3", Helpers.ToElems(h,value))
    member _.h3Is3 (value: 'Element) = Helpers.MakeNode(h,a, "h3", "title is-3", Helpers.ToElems(h,value))
    member _.h3Is3 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h3", "title is-3", Helpers.ToElems(h,children))
    member _.h4Is4 (value: string) = Helpers.MakeNode(h,a, "h4", "title is-4", Helpers.ToElems(h,value))
    member _.h4Is4 (value: int) = Helpers.MakeNode(h,a, "h4", "title is-4", Helpers.ToElems(h,value))
    member _.h4Is4 (value: float) = Helpers.MakeNode(h,a, "h4", "title is-4", Helpers.ToElems(h,value))
    member _.h4Is4 (value: 'Element) = Helpers.MakeNode(h,a, "h4", "title is-4", Helpers.ToElems(h,value))
    member _.h4Is4 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h4", "title is-4", Helpers.ToElems(h,children))
    member _.h5Is5 (value: string) = Helpers.MakeNode(h,a, "h5", "title is-5", Helpers.ToElems(h,value))
    member _.h5Is5 (value: int) = Helpers.MakeNode(h,a, "h5", "title is-5", Helpers.ToElems(h,value))
    member _.h5Is5 (value: float) = Helpers.MakeNode(h,a, "h5", "title is-5", Helpers.ToElems(h,value))
    member _.h5Is5 (value: 'Element) = Helpers.MakeNode(h,a, "h5", "title is-5", Helpers.ToElems(h,value))
    member _.h5Is5 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h5", "title is-5", Helpers.ToElems(h,children))
    member _.h6Is6 (value: string) = Helpers.MakeNode(h,a, "h6", "title is-6", Helpers.ToElems(h,value))
    member _.h6Is6 (value: int) = Helpers.MakeNode(h,a, "h6", "title is-6", Helpers.ToElems(h,value))
    member _.h6Is6 (value: float) = Helpers.MakeNode(h,a, "h6", "title is-6", Helpers.ToElems(h,value))
    member _.h6Is6 (value: 'Element) = Helpers.MakeNode(h,a, "h6", "title is-6", Helpers.ToElems(h,value))
    member _.h6Is6 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h6", "title is-6", Helpers.ToElems(h,children))
    member _.p (value: string) = Helpers.MakeNode(h,a, "p", "title", Helpers.ToElems(h,value))
    member _.p (value: int) = Helpers.MakeNode(h,a, "p", "title", Helpers.ToElems(h,value))
    member _.p (value: float) = Helpers.MakeNode(h,a, "p", "title", Helpers.ToElems(h,value))
    member _.p (value: 'Element) = Helpers.MakeNode(h,a, "p", "title", Helpers.ToElems(h,value))
    member _.p (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "title", Helpers.ToElems(h,children))


type SubtitleEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.h1 (value: string) = Helpers.MakeNode(h,a, "h1", "subtitle", Helpers.ToElems(h,value))
    member _.h1 (value: int) = Helpers.MakeNode(h,a, "h1", "subtitle", Helpers.ToElems(h,value))
    member _.h1 (value: float) = Helpers.MakeNode(h,a, "h1", "subtitle", Helpers.ToElems(h,value))
    member _.h1 (value: 'Element) = Helpers.MakeNode(h,a, "h1", "subtitle", Helpers.ToElems(h,value))
    member _.h1 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h1", "subtitle", Helpers.ToElems(h,children))
    member _.h2 (value: string) = Helpers.MakeNode(h,a, "h2", "subtitle", Helpers.ToElems(h,value))
    member _.h2 (value: int) = Helpers.MakeNode(h,a, "h2", "subtitle", Helpers.ToElems(h,value))
    member _.h2 (value: float) = Helpers.MakeNode(h,a, "h2", "subtitle", Helpers.ToElems(h,value))
    member _.h2 (value: 'Element) = Helpers.MakeNode(h,a, "h2", "subtitle", Helpers.ToElems(h,value))
    member _.h2 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h2", "subtitle", Helpers.ToElems(h,children))
    member _.h3 (value: string) = Helpers.MakeNode(h,a, "h3", "subtitle", Helpers.ToElems(h,value))
    member _.h3 (value: int) = Helpers.MakeNode(h,a, "h3", "subtitle", Helpers.ToElems(h,value))
    member _.h3 (value: float) = Helpers.MakeNode(h,a, "h3", "subtitle", Helpers.ToElems(h,value))
    member _.h3 (value: 'Element) = Helpers.MakeNode(h,a, "h3", "subtitle", Helpers.ToElems(h,value))
    member _.h3 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h3", "subtitle", Helpers.ToElems(h,children))
    member _.h4 (value: string) = Helpers.MakeNode(h,a, "h4", "subtitle", Helpers.ToElems(h,value))
    member _.h4 (value: int) = Helpers.MakeNode(h,a, "h4", "subtitle", Helpers.ToElems(h,value))
    member _.h4 (value: float) = Helpers.MakeNode(h,a, "h4", "subtitle", Helpers.ToElems(h,value))
    member _.h4 (value: 'Element) = Helpers.MakeNode(h,a, "h4", "subtitle", Helpers.ToElems(h,value))
    member _.h4 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h4", "subtitle", Helpers.ToElems(h,children))
    member _.h5 (value: string) = Helpers.MakeNode(h,a, "h5", "subtitle", Helpers.ToElems(h,value))
    member _.h5 (value: int) = Helpers.MakeNode(h,a, "h5", "subtitle", Helpers.ToElems(h,value))
    member _.h5 (value: float) = Helpers.MakeNode(h,a, "h5", "subtitle", Helpers.ToElems(h,value))
    member _.h5 (value: 'Element) = Helpers.MakeNode(h,a, "h5", "subtitle", Helpers.ToElems(h,value))
    member _.h5 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h5", "subtitle", Helpers.ToElems(h,children))
    member _.h6 (value: string) = Helpers.MakeNode(h,a, "h6", "subtitle", Helpers.ToElems(h,value))
    member _.h6 (value: int) = Helpers.MakeNode(h,a, "h6", "subtitle", Helpers.ToElems(h,value))
    member _.h6 (value: float) = Helpers.MakeNode(h,a, "h6", "subtitle", Helpers.ToElems(h,value))
    member _.h6 (value: 'Element) = Helpers.MakeNode(h,a, "h6", "subtitle", Helpers.ToElems(h,value))
    member _.h6 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h6", "subtitle", Helpers.ToElems(h,children))
    member _.h1Is1 (value: string) = Helpers.MakeNode(h,a, "h1", "subtitle is-1", Helpers.ToElems(h,value))
    member _.h1Is1 (value: int) = Helpers.MakeNode(h,a, "h1", "subtitle is-1", Helpers.ToElems(h,value))
    member _.h1Is1 (value: float) = Helpers.MakeNode(h,a, "h1", "subtitle is-1", Helpers.ToElems(h,value))
    member _.h1Is1 (value: 'Element) = Helpers.MakeNode(h,a, "h1", "subtitle is-1", Helpers.ToElems(h,value))
    member _.h1Is1 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h1", "subtitle is-1", Helpers.ToElems(h,children))
    member _.h2Is2 (value: string) = Helpers.MakeNode(h,a, "h2", "subtitle is-2", Helpers.ToElems(h,value))
    member _.h2Is2 (value: int) = Helpers.MakeNode(h,a, "h2", "subtitle is-2", Helpers.ToElems(h,value))
    member _.h2Is2 (value: float) = Helpers.MakeNode(h,a, "h2", "subtitle is-2", Helpers.ToElems(h,value))
    member _.h2Is2 (value: 'Element) = Helpers.MakeNode(h,a, "h2", "subtitle is-2", Helpers.ToElems(h,value))
    member _.h2Is2 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h2", "subtitle is-2", Helpers.ToElems(h,children))
    member _.h3Is3 (value: string) = Helpers.MakeNode(h,a, "h3", "subtitle is-3", Helpers.ToElems(h,value))
    member _.h3Is3 (value: int) = Helpers.MakeNode(h,a, "h3", "subtitle is-3", Helpers.ToElems(h,value))
    member _.h3Is3 (value: float) = Helpers.MakeNode(h,a, "h3", "subtitle is-3", Helpers.ToElems(h,value))
    member _.h3Is3 (value: 'Element) = Helpers.MakeNode(h,a, "h3", "subtitle is-3", Helpers.ToElems(h,value))
    member _.h3Is3 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h3", "subtitle is-3", Helpers.ToElems(h,children))
    member _.h4Is4 (value: string) = Helpers.MakeNode(h,a, "h4", "subtitle is-4", Helpers.ToElems(h,value))
    member _.h4Is4 (value: int) = Helpers.MakeNode(h,a, "h4", "subtitle is-4", Helpers.ToElems(h,value))
    member _.h4Is4 (value: float) = Helpers.MakeNode(h,a, "h4", "subtitle is-4", Helpers.ToElems(h,value))
    member _.h4Is4 (value: 'Element) = Helpers.MakeNode(h,a, "h4", "subtitle is-4", Helpers.ToElems(h,value))
    member _.h4Is4 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h4", "subtitle is-4", Helpers.ToElems(h,children))
    member _.h5Is5 (value: string) = Helpers.MakeNode(h,a, "h5", "subtitle is-5", Helpers.ToElems(h,value))
    member _.h5Is5 (value: int) = Helpers.MakeNode(h,a, "h5", "subtitle is-5", Helpers.ToElems(h,value))
    member _.h5Is5 (value: float) = Helpers.MakeNode(h,a, "h5", "subtitle is-5", Helpers.ToElems(h,value))
    member _.h5Is5 (value: 'Element) = Helpers.MakeNode(h,a, "h5", "subtitle is-5", Helpers.ToElems(h,value))
    member _.h5Is5 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h5", "subtitle is-5", Helpers.ToElems(h,children))
    member _.h6Is6 (value: string) = Helpers.MakeNode(h,a, "h6", "subtitle is-6", Helpers.ToElems(h,value))
    member _.h6Is6 (value: int) = Helpers.MakeNode(h,a, "h6", "subtitle is-6", Helpers.ToElems(h,value))
    member _.h6Is6 (value: float) = Helpers.MakeNode(h,a, "h6", "subtitle is-6", Helpers.ToElems(h,value))
    member _.h6Is6 (value: 'Element) = Helpers.MakeNode(h,a, "h6", "subtitle is-6", Helpers.ToElems(h,value))
    member _.h6Is6 (children: seq<'Element>) = Helpers.MakeNode(h,a, "h6", "subtitle is-6", Helpers.ToElems(h,children))
    member _.p (value: string) = Helpers.MakeNode(h,a, "p", "subtitle", Helpers.ToElems(h,value))
    member _.p (value: int) = Helpers.MakeNode(h,a, "p", "subtitle", Helpers.ToElems(h,value))
    member _.p (value: float) = Helpers.MakeNode(h,a, "p", "subtitle", Helpers.ToElems(h,value))
    member _.p (value: 'Element) = Helpers.MakeNode(h,a, "p", "subtitle", Helpers.ToElems(h,value))
    member _.p (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "subtitle", Helpers.ToElems(h,children))


type ControlEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "control", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "control", Helpers.ToElems(h,children))
    member _.p (value: 'Element) = Helpers.MakeNode(h,a, "p", "control", Helpers.ToElems(h,value))
    member _.p (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "control", Helpers.ToElems(h,children))


type FieldEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: string) = Helpers.MakeNode(h,a, "div", "field", Helpers.ToElems(h,value))
    member _.div (value: int) = Helpers.MakeNode(h,a, "div", "field", Helpers.ToElems(h,value))
    member _.div (value: float) = Helpers.MakeNode(h,a, "div", "field", Helpers.ToElems(h,value))
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "field", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "field", Helpers.ToElems(h,children))
    member _.p (value: string) = Helpers.MakeNode(h,a, "p", "field", Helpers.ToElems(h,value))
    member _.p (value: int) = Helpers.MakeNode(h,a, "p", "field", Helpers.ToElems(h,value))
    member _.p (value: float) = Helpers.MakeNode(h,a, "p", "field", Helpers.ToElems(h,value))
    member _.p (value: 'Element) = Helpers.MakeNode(h,a, "p", "field", Helpers.ToElems(h,value))
    member _.p (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "field", Helpers.ToElems(h,children))


type FileLabelEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.label (value: string) = Helpers.MakeNode(h,a, "label", "file-label", Helpers.ToElems(h,value))
    member _.label (value: int) = Helpers.MakeNode(h,a, "label", "file-label", Helpers.ToElems(h,value))
    member _.label (value: float) = Helpers.MakeNode(h,a, "label", "file-label", Helpers.ToElems(h,value))
    member _.label (value: 'Element) = Helpers.MakeNode(h,a, "label", "file-label", Helpers.ToElems(h,value))
    member _.label (children: seq<'Element>) = Helpers.MakeNode(h,a, "label", "file-label", Helpers.ToElems(h,children))
    member _.span (value: string) = Helpers.MakeNode(h,a, "span", "file-label", Helpers.ToElems(h,value))
    member _.span (value: int) = Helpers.MakeNode(h,a, "span", "file-label", Helpers.ToElems(h,value))
    member _.span (value: float) = Helpers.MakeNode(h,a, "span", "file-label", Helpers.ToElems(h,value))
    member _.span (value: 'Element) = Helpers.MakeNode(h,a, "span", "file-label", Helpers.ToElems(h,value))
    member _.span (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "file-label", Helpers.ToElems(h,children))


type CardHeaderTitleEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: string) = Helpers.MakeNode(h,a, "div", "card-header-title", Helpers.ToElems(h,value))
    member _.div (value: int) = Helpers.MakeNode(h,a, "div", "card-header-title", Helpers.ToElems(h,value))
    member _.div (value: float) = Helpers.MakeNode(h,a, "div", "card-header-title", Helpers.ToElems(h,value))
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "card-header-title", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "card-header-title", Helpers.ToElems(h,children))
    member _.p (value: string) = Helpers.MakeNode(h,a, "p", "card-header-title", Helpers.ToElems(h,value))
    member _.p (value: int) = Helpers.MakeNode(h,a, "p", "card-header-title", Helpers.ToElems(h,value))
    member _.p (value: float) = Helpers.MakeNode(h,a, "p", "card-header-title", Helpers.ToElems(h,value))
    member _.p (value: 'Element) = Helpers.MakeNode(h,a, "p", "card-header-title", Helpers.ToElems(h,value))
    member _.p (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "card-header-title", Helpers.ToElems(h,children))


type CardHeaderIconEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.a (value: string) = Helpers.MakeNode(h,a, "a", "card-header-icon", Helpers.ToElems(h,value))
    member _.a (value: int) = Helpers.MakeNode(h,a, "a", "card-header-icon", Helpers.ToElems(h,value))
    member _.a (value: float) = Helpers.MakeNode(h,a, "a", "card-header-icon", Helpers.ToElems(h,value))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "card-header-icon", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "card-header-icon", Helpers.ToElems(h,children))
    member _.span (value: string) = Helpers.MakeNode(h,a, "span", "card-header-icon", Helpers.ToElems(h,value))
    member _.span (value: int) = Helpers.MakeNode(h,a, "span", "card-header-icon", Helpers.ToElems(h,value))
    member _.span (value: float) = Helpers.MakeNode(h,a, "span", "card-header-icon", Helpers.ToElems(h,value))
    member _.span (value: 'Element) = Helpers.MakeNode(h,a, "span", "card-header-icon", Helpers.ToElems(h,value))
    member _.span (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "card-header-icon", Helpers.ToElems(h,children))


type CardFooterItemEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: string) = Helpers.MakeNode(h,a, "div", "card-footer-item", Helpers.ToElems(h,value))
    member _.div (value: int) = Helpers.MakeNode(h,a, "div", "card-footer-item", Helpers.ToElems(h,value))
    member _.div (value: float) = Helpers.MakeNode(h,a, "div", "card-footer-item", Helpers.ToElems(h,value))
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "card-footer-item", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "card-footer-item", Helpers.ToElems(h,children))
    member _.p (value: string) = Helpers.MakeNode(h,a, "p", "card-footer-item", Helpers.ToElems(h,value))
    member _.p (value: int) = Helpers.MakeNode(h,a, "p", "card-footer-item", Helpers.ToElems(h,value))
    member _.p (value: float) = Helpers.MakeNode(h,a, "p", "card-footer-item", Helpers.ToElems(h,value))
    member _.p (value: 'Element) = Helpers.MakeNode(h,a, "p", "card-footer-item", Helpers.ToElems(h,value))
    member _.p (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "card-footer-item", Helpers.ToElems(h,children))
    member _.a (value: string) = Helpers.MakeNode(h,a, "a", "card-footer-item", Helpers.ToElems(h,value))
    member _.a (value: int) = Helpers.MakeNode(h,a, "a", "card-footer-item", Helpers.ToElems(h,value))
    member _.a (value: float) = Helpers.MakeNode(h,a, "a", "card-footer-item", Helpers.ToElems(h,value))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "card-footer-item", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "card-footer-item", Helpers.ToElems(h,children))


type DropdownItemEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.a (value: string) = Helpers.MakeNode(h,a, "a", "dropdown-item", Helpers.ToElems(h,value))
    member _.a (value: int) = Helpers.MakeNode(h,a, "a", "dropdown-item", Helpers.ToElems(h,value))
    member _.a (value: float) = Helpers.MakeNode(h,a, "a", "dropdown-item", Helpers.ToElems(h,value))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "dropdown-item", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "dropdown-item", Helpers.ToElems(h,children))
    member _.div (value: string) = Helpers.MakeNode(h,a, "div", "dropdown-item", Helpers.ToElems(h,value))
    member _.div (value: int) = Helpers.MakeNode(h,a, "div", "dropdown-item", Helpers.ToElems(h,value))
    member _.div (value: float) = Helpers.MakeNode(h,a, "div", "dropdown-item", Helpers.ToElems(h,value))
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "dropdown-item", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "dropdown-item", Helpers.ToElems(h,children))
    member _.button (value: string) = Helpers.MakeNode(h,a, "button", "dropdown-item", Helpers.ToElems(h,value))
    member _.button (value: int) = Helpers.MakeNode(h,a, "button", "dropdown-item", Helpers.ToElems(h,value))
    member _.button (value: float) = Helpers.MakeNode(h,a, "button", "dropdown-item", Helpers.ToElems(h,value))
    member _.button (value: 'Element) = Helpers.MakeNode(h,a, "button", "dropdown-item", Helpers.ToElems(h,value))
    member _.button (children: seq<'Element>) = Helpers.MakeNode(h,a, "button", "dropdown-item", Helpers.ToElems(h,children))


type MenuItemEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.a (value: string) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "", Helpers.ToElems(h,value))])
    member _.a (value: int) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "", Helpers.ToElems(h,value))])
    member _.a (value: float) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "", Helpers.ToElems(h,value))])
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "", Helpers.ToElems(h,value))])
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "", Helpers.ToElems(h,children))])


type NavbarBrandEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "navbar-brand", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "navbar-brand", Helpers.ToElems(h,children))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "navbar-brand", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "navbar-brand", Helpers.ToElems(h,children))


type NavbarStartEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "navbar-start", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "navbar-start", Helpers.ToElems(h,children))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "navbar-start", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "navbar-start", Helpers.ToElems(h,children))


type NavbarEndEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "navbar-end", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "navbar-end", Helpers.ToElems(h,children))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "navbar-end", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "navbar-end", Helpers.ToElems(h,children))


type NavbarItemEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "navbar-item", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "navbar-item", Helpers.ToElems(h,children))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "navbar-item", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "navbar-item", Helpers.ToElems(h,children))


type NavbarLinkEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: string) = Helpers.MakeNode(h,a, "div", "navbar-link", Helpers.ToElems(h,value))
    member _.div (value: int) = Helpers.MakeNode(h,a, "div", "navbar-link", Helpers.ToElems(h,value))
    member _.div (value: float) = Helpers.MakeNode(h,a, "div", "navbar-link", Helpers.ToElems(h,value))
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "navbar-link", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "navbar-link", Helpers.ToElems(h,children))
    member _.a (value: string) = Helpers.MakeNode(h,a, "a", "navbar-link", Helpers.ToElems(h,value))
    member _.a (value: int) = Helpers.MakeNode(h,a, "a", "navbar-link", Helpers.ToElems(h,value))
    member _.a (value: float) = Helpers.MakeNode(h,a, "a", "navbar-link", Helpers.ToElems(h,value))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "navbar-link", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "navbar-link", Helpers.ToElems(h,children))


type NavbarDropdownEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "navbar-dropdown", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "navbar-dropdown", Helpers.ToElems(h,children))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "navbar-dropdown", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "navbar-dropdown", Helpers.ToElems(h,children))


type PaginationPreviousEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.a (value: string) = Helpers.MakeNode(h,a, "a", "pagination-previous", Helpers.ToElems(h,value))
    member _.a (value: int) = Helpers.MakeNode(h,a, "a", "pagination-previous", Helpers.ToElems(h,value))
    member _.a (value: float) = Helpers.MakeNode(h,a, "a", "pagination-previous", Helpers.ToElems(h,value))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "pagination-previous", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "pagination-previous", Helpers.ToElems(h,children))
    member _.button (value: string) = Helpers.MakeNode(h,a, "button", "pagination-previous", Helpers.ToElems(h,value))
    member _.button (value: int) = Helpers.MakeNode(h,a, "button", "pagination-previous", Helpers.ToElems(h,value))
    member _.button (value: float) = Helpers.MakeNode(h,a, "button", "pagination-previous", Helpers.ToElems(h,value))
    member _.button (value: 'Element) = Helpers.MakeNode(h,a, "button", "pagination-previous", Helpers.ToElems(h,value))
    member _.button (children: seq<'Element>) = Helpers.MakeNode(h,a, "button", "pagination-previous", Helpers.ToElems(h,children))


type PaginationNextEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.a (value: string) = Helpers.MakeNode(h,a, "a", "pagination-next", Helpers.ToElems(h,value))
    member _.a (value: int) = Helpers.MakeNode(h,a, "a", "pagination-next", Helpers.ToElems(h,value))
    member _.a (value: float) = Helpers.MakeNode(h,a, "a", "pagination-next", Helpers.ToElems(h,value))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "pagination-next", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "pagination-next", Helpers.ToElems(h,children))
    member _.button (value: string) = Helpers.MakeNode(h,a, "button", "pagination-next", Helpers.ToElems(h,value))
    member _.button (value: int) = Helpers.MakeNode(h,a, "button", "pagination-next", Helpers.ToElems(h,value))
    member _.button (value: float) = Helpers.MakeNode(h,a, "button", "pagination-next", Helpers.ToElems(h,value))
    member _.button (value: 'Element) = Helpers.MakeNode(h,a, "button", "pagination-next", Helpers.ToElems(h,value))
    member _.button (children: seq<'Element>) = Helpers.MakeNode(h,a, "button", "pagination-next", Helpers.ToElems(h,children))


type PaginationLinkEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.a (value: string) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "pagination-link", [])])
    member _.a (value: int) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "pagination-link", [])])
    member _.a (value: float) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "pagination-link", [])])
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "pagination-link", [])])
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "a", "pagination-link", [])])
    member _.button (value: string) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "button", "pagination-link", [])])
    member _.button (value: int) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "button", "pagination-link", [])])
    member _.button (value: float) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "button", "pagination-link", [])])
    member _.button (value: 'Element) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "button", "pagination-link", [])])
    member _.button (children: seq<'Element>) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "button", "pagination-link", [])])


type PanelBlockEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.div (value: string) = Helpers.MakeNode(h,a, "div", "panel-block", Helpers.ToElems(h,value))
    member _.div (value: int) = Helpers.MakeNode(h,a, "div", "panel-block", Helpers.ToElems(h,value))
    member _.div (value: float) = Helpers.MakeNode(h,a, "div", "panel-block", Helpers.ToElems(h,value))
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "panel-block", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "panel-block", Helpers.ToElems(h,children))
    member _.a (value: string) = Helpers.MakeNode(h,a, "a", "panel-block", Helpers.ToElems(h,value))
    member _.a (value: int) = Helpers.MakeNode(h,a, "a", "panel-block", Helpers.ToElems(h,value))
    member _.a (value: float) = Helpers.MakeNode(h,a, "a", "panel-block", Helpers.ToElems(h,value))
    member _.a (value: 'Element) = Helpers.MakeNode(h,a, "a", "panel-block", Helpers.ToElems(h,value))
    member _.a (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "panel-block", Helpers.ToElems(h,children))
    member _.label (value: string) = Helpers.MakeNode(h,a, "label", "panel-block", Helpers.ToElems(h,value))
    member _.label (value: int) = Helpers.MakeNode(h,a, "label", "panel-block", Helpers.ToElems(h,value))
    member _.label (value: float) = Helpers.MakeNode(h,a, "label", "panel-block", Helpers.ToElems(h,value))
    member _.label (value: 'Element) = Helpers.MakeNode(h,a, "label", "panel-block", Helpers.ToElems(h,value))
    member _.label (children: seq<'Element>) = Helpers.MakeNode(h,a, "label", "panel-block", Helpers.ToElems(h,children))
    member _.p (value: string) = Helpers.MakeNode(h,a, "p", "panel-block", Helpers.ToElems(h,value))
    member _.p (value: int) = Helpers.MakeNode(h,a, "p", "panel-block", Helpers.ToElems(h,value))
    member _.p (value: float) = Helpers.MakeNode(h,a, "p", "panel-block", Helpers.ToElems(h,value))
    member _.p (value: 'Element) = Helpers.MakeNode(h,a, "p", "panel-block", Helpers.ToElems(h,value))
    member _.p (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "panel-block", Helpers.ToElems(h,children))


type InputEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.text (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "text"] @ Helpers.ToElems(h,value))
    member _.text (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "text"] @ Helpers.ToElems(h,value))
    member _.text (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "text"] @ Helpers.ToElems(h,value))
    member _.text (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "text"] @ Helpers.ToElems(h,value))
    member _.text (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "text"] @ Helpers.ToElems(h,children))
    member _.password (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "password"] @ Helpers.ToElems(h,value))
    member _.password (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "password"] @ Helpers.ToElems(h,value))
    member _.password (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "password"] @ Helpers.ToElems(h,value))
    member _.password (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "password"] @ Helpers.ToElems(h,value))
    member _.password (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "password"] @ Helpers.ToElems(h,children))
    member _.datetimeLocal (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "datetime-local"] @ Helpers.ToElems(h,value))
    member _.datetimeLocal (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "datetime-local"] @ Helpers.ToElems(h,value))
    member _.datetimeLocal (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "datetime-local"] @ Helpers.ToElems(h,value))
    member _.datetimeLocal (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "datetime-local"] @ Helpers.ToElems(h,value))
    member _.datetimeLocal (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "datetime-local"] @ Helpers.ToElems(h,children))
    member _.date (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "date"] @ Helpers.ToElems(h,value))
    member _.date (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "date"] @ Helpers.ToElems(h,value))
    member _.date (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "date"] @ Helpers.ToElems(h,value))
    member _.date (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "date"] @ Helpers.ToElems(h,value))
    member _.date (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "date"] @ Helpers.ToElems(h,children))
    member _.month (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "month"] @ Helpers.ToElems(h,value))
    member _.month (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "month"] @ Helpers.ToElems(h,value))
    member _.month (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "month"] @ Helpers.ToElems(h,value))
    member _.month (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "month"] @ Helpers.ToElems(h,value))
    member _.month (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "month"] @ Helpers.ToElems(h,children))
    member _.time (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "time"] @ Helpers.ToElems(h,value))
    member _.time (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "time"] @ Helpers.ToElems(h,value))
    member _.time (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "time"] @ Helpers.ToElems(h,value))
    member _.time (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "time"] @ Helpers.ToElems(h,value))
    member _.time (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "time"] @ Helpers.ToElems(h,children))
    member _.week (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "week"] @ Helpers.ToElems(h,value))
    member _.week (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "week"] @ Helpers.ToElems(h,value))
    member _.week (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "week"] @ Helpers.ToElems(h,value))
    member _.week (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "week"] @ Helpers.ToElems(h,value))
    member _.week (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "week"] @ Helpers.ToElems(h,children))
    member _.url (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "url"] @ Helpers.ToElems(h,value))
    member _.url (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "url"] @ Helpers.ToElems(h,value))
    member _.url (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "url"] @ Helpers.ToElems(h,value))
    member _.url (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "url"] @ Helpers.ToElems(h,value))
    member _.url (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "url"] @ Helpers.ToElems(h,children))
    member _.search (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "search"] @ Helpers.ToElems(h,value))
    member _.search (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "search"] @ Helpers.ToElems(h,value))
    member _.search (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "search"] @ Helpers.ToElems(h,value))
    member _.search (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "search"] @ Helpers.ToElems(h,value))
    member _.search (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "search"] @ Helpers.ToElems(h,children))
    member _.color (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "color"] @ Helpers.ToElems(h,value))
    member _.color (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "color"] @ Helpers.ToElems(h,value))
    member _.color (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "color"] @ Helpers.ToElems(h,value))
    member _.color (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "color"] @ Helpers.ToElems(h,value))
    member _.color (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "color"] @ Helpers.ToElems(h,children))
    member _.email (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "email"] @ Helpers.ToElems(h,value))
    member _.email (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "email"] @ Helpers.ToElems(h,value))
    member _.email (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "email"] @ Helpers.ToElems(h,value))
    member _.email (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "email"] @ Helpers.ToElems(h,value))
    member _.email (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "email"] @ Helpers.ToElems(h,children))
    member _.tel (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "tel"] @ Helpers.ToElems(h,value))
    member _.tel (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "tel"] @ Helpers.ToElems(h,value))
    member _.tel (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "tel"] @ Helpers.ToElems(h,value))
    member _.tel (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "tel"] @ Helpers.ToElems(h,value))
    member _.tel (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "tel"] @ Helpers.ToElems(h,children))
    member _.number (value: string) = Helpers.MakeNode(h,a, "input", "input", [a.type' "number"] @ Helpers.ToElems(h,value))
    member _.number (value: int) = Helpers.MakeNode(h,a, "input", "input", [a.type' "number"] @ Helpers.ToElems(h,value))
    member _.number (value: float) = Helpers.MakeNode(h,a, "input", "input", [a.type' "number"] @ Helpers.ToElems(h,value))
    member _.number (value: 'Element) = Helpers.MakeNode(h,a, "input", "input", [a.type' "number"] @ Helpers.ToElems(h,value))
    member _.number (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "input", [a.type' "number"] @ Helpers.ToElems(h,children))
    member _.checkbox (value: string) = Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,value))
    member _.checkbox (value: int) = Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,value))
    member _.checkbox (value: float) = Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,value))
    member _.checkbox (value: 'Element) = Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,value))
    member _.checkbox (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,children))
    member _.radio (value: string) = Helpers.MakeNode(h,a, "input", "", [a.type' "radio"] @ Helpers.ToElems(h,value))
    member _.radio (value: int) = Helpers.MakeNode(h,a, "input", "", [a.type' "radio"] @ Helpers.ToElems(h,value))
    member _.radio (value: float) = Helpers.MakeNode(h,a, "input", "", [a.type' "radio"] @ Helpers.ToElems(h,value))
    member _.radio (value: 'Element) = Helpers.MakeNode(h,a, "input", "", [a.type' "radio"] @ Helpers.ToElems(h,value))
    member _.radio (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "", [a.type' "radio"] @ Helpers.ToElems(h,children))
    member _.labelCheckbox (label: string, value: string) = Helpers.MakeNode(h,a, "label", "checkbox", [Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,value));h.text label])
    member _.labelCheckbox (label: string, value: int) = Helpers.MakeNode(h,a, "label", "checkbox", [Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,value));h.text label])
    member _.labelCheckbox (label: string, value: float) = Helpers.MakeNode(h,a, "label", "checkbox", [Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,value));h.text label])
    member _.labelCheckbox (label: string, value: 'Element) = Helpers.MakeNode(h,a, "label", "checkbox", [Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,value));h.text label])
    member _.labelCheckbox (label: string, children: seq<'Element>) = Helpers.MakeNode(h,a, "label", "checkbox", [Helpers.MakeNode(h,a, "input", "", [a.type' "checkbox"] @ Helpers.ToElems(h,children));h.text label])


type InputLabelsEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.checkbox (value: 'Element) = Helpers.MakeNode(h,a, "label", "checkbox", Helpers.ToElems(h,value))
    member _.checkbox (children: seq<'Element>) = Helpers.MakeNode(h,a, "label", "checkbox", Helpers.ToElems(h,children))
    member _.radio (value: 'Element) = Helpers.MakeNode(h,a, "label", "radio", Helpers.ToElems(h,value))
    member _.radio (children: seq<'Element>) = Helpers.MakeNode(h,a, "label", "radio", Helpers.ToElems(h,children))


type TextEngine<'Element>( h : Feliz.HtmlEngine<'Element>, a : Feliz.AttrEngine<'Element> ) =
    member _.p (value: 'Element) = Helpers.MakeNode(h,a, "p", "text", Helpers.ToElems(h,value))
    member _.p (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "text", Helpers.ToElems(h,children))
    member _.div (value: 'Element) = Helpers.MakeNode(h,a, "div", "text", Helpers.ToElems(h,value))
    member _.div (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "text", Helpers.ToElems(h,children))
    member _.span (value: 'Element) = Helpers.MakeNode(h,a, "span", "text", Helpers.ToElems(h,value))
    member _.span (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "text", Helpers.ToElems(h,children))


type BulmaEngine<'Element>( h : HtmlEngine<'Element>, a : AttrEngine<'Element> ) =
    let _m = BulmaModifiersEngine<'Element>(a)
    let _button = ButtonEngine(h,a)
    let _title = TitleEngine(h,a)
    let _subtitle = SubtitleEngine(h,a)
    let _control = ControlEngine(h,a)
    let _field = FieldEngine(h,a)
    let _fileLabel = FileLabelEngine(h,a)
    let _cardHeaderTitle = CardHeaderTitleEngine(h,a)
    let _cardHeaderIcon = CardHeaderIconEngine(h,a)
    let _cardFooterItem = CardFooterItemEngine(h,a)
    let _dropdownItem = DropdownItemEngine(h,a)
    let _menuItem = MenuItemEngine(h,a)
    let _navbarBrand = NavbarBrandEngine(h,a)
    let _navbarStart = NavbarStartEngine(h,a)
    let _navbarEnd = NavbarEndEngine(h,a)
    let _navbarItem = NavbarItemEngine(h,a)
    let _navbarLink = NavbarLinkEngine(h,a)
    let _navbarDropdown = NavbarDropdownEngine(h,a)
    let _paginationPrevious = PaginationPreviousEngine(h,a)
    let _paginationNext = PaginationNextEngine(h,a)
    let _paginationLink = PaginationLinkEngine(h,a)
    let _panelBlock = PanelBlockEngine(h,a)
    let _input = InputEngine(h,a)
    let _inputLabels = InputLabelsEngine(h,a)
    let _text = TextEngine(h,a)

    member _.m = _m

    member _.container (value: string) = Helpers.MakeNode(h,a, "div", "container", Helpers.ToElems(h,value))
    member _.container (value: int) = Helpers.MakeNode(h,a, "div", "container", Helpers.ToElems(h,value))
    member _.container (value: float) = Helpers.MakeNode(h,a, "div", "container", Helpers.ToElems(h,value))
    member _.container (value: 'Element) = Helpers.MakeNode(h,a, "div", "container", Helpers.ToElems(h,value))
    member _.container (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "container", Helpers.ToElems(h,children))

    member _.level (value: 'Element) = Helpers.MakeNode(h,a, "nav", "level", Helpers.ToElems(h,value))
    member _.level (children: seq<'Element>) = Helpers.MakeNode(h,a, "nav", "level", Helpers.ToElems(h,children))

    member _.levelLeft (value: string) = Helpers.MakeNode(h,a, "div", "level-left", Helpers.ToElems(h,value))
    member _.levelLeft (value: int) = Helpers.MakeNode(h,a, "div", "level-left", Helpers.ToElems(h,value))
    member _.levelLeft (value: float) = Helpers.MakeNode(h,a, "div", "level-left", Helpers.ToElems(h,value))
    member _.levelLeft (value: 'Element) = Helpers.MakeNode(h,a, "div", "level-left", Helpers.ToElems(h,value))
    member _.levelLeft (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "level-left", Helpers.ToElems(h,children))

    member _.levelRight (value: string) = Helpers.MakeNode(h,a, "div", "level-right", Helpers.ToElems(h,value))
    member _.levelRight (value: int) = Helpers.MakeNode(h,a, "div", "level-right", Helpers.ToElems(h,value))
    member _.levelRight (value: float) = Helpers.MakeNode(h,a, "div", "level-right", Helpers.ToElems(h,value))
    member _.levelRight (value: 'Element) = Helpers.MakeNode(h,a, "div", "level-right", Helpers.ToElems(h,value))
    member _.levelRight (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "level-right", Helpers.ToElems(h,children))

    member _.levelItem (value: string) = Helpers.MakeNode(h,a, "div", "level-item", Helpers.ToElems(h,value))
    member _.levelItem (value: int) = Helpers.MakeNode(h,a, "div", "level-item", Helpers.ToElems(h,value))
    member _.levelItem (value: float) = Helpers.MakeNode(h,a, "div", "level-item", Helpers.ToElems(h,value))
    member _.levelItem (value: 'Element) = Helpers.MakeNode(h,a, "div", "level-item", Helpers.ToElems(h,value))
    member _.levelItem (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "level-item", Helpers.ToElems(h,children))

    member _.media (value: string) = Helpers.MakeNode(h,a, "article", "media", Helpers.ToElems(h,value))
    member _.media (value: int) = Helpers.MakeNode(h,a, "article", "media", Helpers.ToElems(h,value))
    member _.media (value: float) = Helpers.MakeNode(h,a, "article", "media", Helpers.ToElems(h,value))
    member _.media (value: 'Element) = Helpers.MakeNode(h,a, "article", "media", Helpers.ToElems(h,value))
    member _.media (children: seq<'Element>) = Helpers.MakeNode(h,a, "article", "media", Helpers.ToElems(h,children))

    member _.mediaLeft (value: string) = Helpers.MakeNode(h,a, "div", "media-left", Helpers.ToElems(h,value))
    member _.mediaLeft (value: int) = Helpers.MakeNode(h,a, "div", "media-left", Helpers.ToElems(h,value))
    member _.mediaLeft (value: float) = Helpers.MakeNode(h,a, "div", "media-left", Helpers.ToElems(h,value))
    member _.mediaLeft (value: 'Element) = Helpers.MakeNode(h,a, "div", "media-left", Helpers.ToElems(h,value))
    member _.mediaLeft (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "media-left", Helpers.ToElems(h,children))

    member _.mediaRight (value: string) = Helpers.MakeNode(h,a, "div", "media-right", Helpers.ToElems(h,value))
    member _.mediaRight (value: int) = Helpers.MakeNode(h,a, "div", "media-right", Helpers.ToElems(h,value))
    member _.mediaRight (value: float) = Helpers.MakeNode(h,a, "div", "media-right", Helpers.ToElems(h,value))
    member _.mediaRight (value: 'Element) = Helpers.MakeNode(h,a, "div", "media-right", Helpers.ToElems(h,value))
    member _.mediaRight (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "media-right", Helpers.ToElems(h,children))

    member _.mediaContent (value: string) = Helpers.MakeNode(h,a, "div", "media-content", Helpers.ToElems(h,value))
    member _.mediaContent (value: int) = Helpers.MakeNode(h,a, "div", "media-content", Helpers.ToElems(h,value))
    member _.mediaContent (value: float) = Helpers.MakeNode(h,a, "div", "media-content", Helpers.ToElems(h,value))
    member _.mediaContent (value: 'Element) = Helpers.MakeNode(h,a, "div", "media-content", Helpers.ToElems(h,value))
    member _.mediaContent (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "media-content", Helpers.ToElems(h,children))

    member _.hero (value: 'Element) = Helpers.MakeNode(h,a, "section", "hero", Helpers.ToElems(h,value))
    member _.hero (children: seq<'Element>) = Helpers.MakeNode(h,a, "section", "hero", Helpers.ToElems(h,children))

    member _.heroBody (value: string) = Helpers.MakeNode(h,a, "div", "hero-body", Helpers.ToElems(h,value))
    member _.heroBody (value: int) = Helpers.MakeNode(h,a, "div", "hero-body", Helpers.ToElems(h,value))
    member _.heroBody (value: float) = Helpers.MakeNode(h,a, "div", "hero-body", Helpers.ToElems(h,value))
    member _.heroBody (value: 'Element) = Helpers.MakeNode(h,a, "div", "hero-body", Helpers.ToElems(h,value))
    member _.heroBody (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "hero-body", Helpers.ToElems(h,children))

    member _.heroHead (value: string) = Helpers.MakeNode(h,a, "div", "hero-head", Helpers.ToElems(h,value))
    member _.heroHead (value: int) = Helpers.MakeNode(h,a, "div", "hero-head", Helpers.ToElems(h,value))
    member _.heroHead (value: float) = Helpers.MakeNode(h,a, "div", "hero-head", Helpers.ToElems(h,value))
    member _.heroHead (value: 'Element) = Helpers.MakeNode(h,a, "div", "hero-head", Helpers.ToElems(h,value))
    member _.heroHead (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "hero-head", Helpers.ToElems(h,children))

    member _.heroFoot (value: string) = Helpers.MakeNode(h,a, "div", "hero-foot", Helpers.ToElems(h,value))
    member _.heroFoot (value: int) = Helpers.MakeNode(h,a, "div", "hero-foot", Helpers.ToElems(h,value))
    member _.heroFoot (value: float) = Helpers.MakeNode(h,a, "div", "hero-foot", Helpers.ToElems(h,value))
    member _.heroFoot (value: 'Element) = Helpers.MakeNode(h,a, "div", "hero-foot", Helpers.ToElems(h,value))
    member _.heroFoot (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "hero-foot", Helpers.ToElems(h,children))

    member _.fieldLabel (value: string) = Helpers.MakeNode(h,a, "div", "field-label", Helpers.ToElems(h,value))
    member _.fieldLabel (value: int) = Helpers.MakeNode(h,a, "div", "field-label", Helpers.ToElems(h,value))
    member _.fieldLabel (value: float) = Helpers.MakeNode(h,a, "div", "field-label", Helpers.ToElems(h,value))
    member _.fieldLabel (value: 'Element) = Helpers.MakeNode(h,a, "div", "field-label", Helpers.ToElems(h,value))
    member _.fieldLabel (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "field-label", Helpers.ToElems(h,children))

    member _.fieldBody (value: string) = Helpers.MakeNode(h,a, "div", "field-body", Helpers.ToElems(h,value))
    member _.fieldBody (value: int) = Helpers.MakeNode(h,a, "div", "field-body", Helpers.ToElems(h,value))
    member _.fieldBody (value: float) = Helpers.MakeNode(h,a, "div", "field-body", Helpers.ToElems(h,value))
    member _.fieldBody (value: 'Element) = Helpers.MakeNode(h,a, "div", "field-body", Helpers.ToElems(h,value))
    member _.fieldBody (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "field-body", Helpers.ToElems(h,children))

    member _.fileInput (value: string) = Helpers.MakeNode(h,a, "input", "file-input", [a.type' "file"] @ Helpers.ToElems(h,value))
    member _.fileInput (value: int) = Helpers.MakeNode(h,a, "input", "file-input", [a.type' "file"] @ Helpers.ToElems(h,value))
    member _.fileInput (value: float) = Helpers.MakeNode(h,a, "input", "file-input", [a.type' "file"] @ Helpers.ToElems(h,value))
    member _.fileInput (value: 'Element) = Helpers.MakeNode(h,a, "input", "file-input", [a.type' "file"] @ Helpers.ToElems(h,value))
    member _.fileInput (children: seq<'Element>) = Helpers.MakeNode(h,a, "input", "file-input", [a.type' "file"] @ Helpers.ToElems(h,children))

    member _.fileCta (value: 'Element) = Helpers.MakeNode(h,a, "span", "file-cta", Helpers.ToElems(h,value))
    member _.fileCta (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "file-cta", Helpers.ToElems(h,children))

    member _.fileName (value: string) = Helpers.MakeNode(h,a, "span", "file-name", Helpers.ToElems(h,value))
    member _.fileName (value: int) = Helpers.MakeNode(h,a, "span", "file-name", Helpers.ToElems(h,value))
    member _.fileName (value: float) = Helpers.MakeNode(h,a, "span", "file-name", Helpers.ToElems(h,value))
    member _.fileName (value: 'Element) = Helpers.MakeNode(h,a, "span", "file-name", Helpers.ToElems(h,value))
    member _.fileName (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "file-name", Helpers.ToElems(h,children))

    member _.fileIcon (value: 'Element) = Helpers.MakeNode(h,a, "span", "file-icon", Helpers.ToElems(h,value))
    member _.fileIcon (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "file-icon", Helpers.ToElems(h,children))

    member _.section (value: 'Element) = Helpers.MakeNode(h,a, "section", "section", Helpers.ToElems(h,value))
    member _.section (children: seq<'Element>) = Helpers.MakeNode(h,a, "section", "section", Helpers.ToElems(h,children))

    member _.footer (value: 'Element) = Helpers.MakeNode(h,a, "footer", "footer", Helpers.ToElems(h,value))
    member _.footer (children: seq<'Element>) = Helpers.MakeNode(h,a, "footer", "footer", Helpers.ToElems(h,children))

    member _.tile (value: string) = Helpers.MakeNode(h,a, "div", "tile", Helpers.ToElems(h,value))
    member _.tile (value: int) = Helpers.MakeNode(h,a, "div", "tile", Helpers.ToElems(h,value))
    member _.tile (value: float) = Helpers.MakeNode(h,a, "div", "tile", Helpers.ToElems(h,value))
    member _.tile (value: 'Element) = Helpers.MakeNode(h,a, "div", "tile", Helpers.ToElems(h,value))
    member _.tile (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "tile", Helpers.ToElems(h,children))

    member _.columns (value: string) = Helpers.MakeNode(h,a, "div", "columns", Helpers.ToElems(h,value))
    member _.columns (value: int) = Helpers.MakeNode(h,a, "div", "columns", Helpers.ToElems(h,value))
    member _.columns (value: float) = Helpers.MakeNode(h,a, "div", "columns", Helpers.ToElems(h,value))
    member _.columns (value: 'Element) = Helpers.MakeNode(h,a, "div", "columns", Helpers.ToElems(h,value))
    member _.columns (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "columns", Helpers.ToElems(h,children))

    member _.column (value: string) = Helpers.MakeNode(h,a, "div", "column", Helpers.ToElems(h,value))
    member _.column (value: int) = Helpers.MakeNode(h,a, "div", "column", Helpers.ToElems(h,value))
    member _.column (value: float) = Helpers.MakeNode(h,a, "div", "column", Helpers.ToElems(h,value))
    member _.column (value: 'Element) = Helpers.MakeNode(h,a, "div", "column", Helpers.ToElems(h,value))
    member _.column (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "column", Helpers.ToElems(h,children))

    member _.label (value: string) = Helpers.MakeNode(h,a, "label", "label", Helpers.ToElems(h,value))
    member _.label (value: int) = Helpers.MakeNode(h,a, "label", "label", Helpers.ToElems(h,value))
    member _.label (value: float) = Helpers.MakeNode(h,a, "label", "label", Helpers.ToElems(h,value))
    member _.label (value: 'Element) = Helpers.MakeNode(h,a, "label", "label", Helpers.ToElems(h,value))
    member _.label (children: seq<'Element>) = Helpers.MakeNode(h,a, "label", "label", Helpers.ToElems(h,children))

    member _.textarea (value: 'Element) = Helpers.MakeNode(h,a, "textarea", "textarea", Helpers.ToElems(h,value))
    member _.textarea (children: seq<'Element>) = Helpers.MakeNode(h,a, "textarea", "textarea", Helpers.ToElems(h,children))

    member _.select (value: 'Element) = Helpers.MakeNode(h,a, "div", "select", [Helpers.MakeNode(h,a, "select", "", Helpers.ToElems(h,value))])
    member _.select (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "select", [Helpers.MakeNode(h,a, "select", "", Helpers.ToElems(h,children))])

    member _.icon (value: 'Element) = Helpers.MakeNode(h,a, "span", "icon", Helpers.ToElems(h,value))
    member _.icon (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "icon", Helpers.ToElems(h,children))

    member _.file (value: 'Element) = Helpers.MakeNode(h,a, "div", "file", Helpers.ToElems(h,value))
    member _.file (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "file", Helpers.ToElems(h,children))

    member _.block (value: string) = Helpers.MakeNode(h,a, "div", "block", Helpers.ToElems(h,value))
    member _.block (value: int) = Helpers.MakeNode(h,a, "div", "block", Helpers.ToElems(h,value))
    member _.block (value: float) = Helpers.MakeNode(h,a, "div", "block", Helpers.ToElems(h,value))
    member _.block (value: 'Element) = Helpers.MakeNode(h,a, "div", "block", Helpers.ToElems(h,value))
    member _.block (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "block", Helpers.ToElems(h,children))

    member _.box (value: string) = Helpers.MakeNode(h,a, "div", "box", Helpers.ToElems(h,value))
    member _.box (value: int) = Helpers.MakeNode(h,a, "div", "box", Helpers.ToElems(h,value))
    member _.box (value: float) = Helpers.MakeNode(h,a, "div", "box", Helpers.ToElems(h,value))
    member _.box (value: 'Element) = Helpers.MakeNode(h,a, "div", "box", Helpers.ToElems(h,value))
    member _.box (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "box", Helpers.ToElems(h,children))

    member _.buttons (value: 'Element) = Helpers.MakeNode(h,a, "div", "buttons", Helpers.ToElems(h,value))
    member _.buttons (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "buttons", Helpers.ToElems(h,children))

    member _.content (value: string) = Helpers.MakeNode(h,a, "div", "content", Helpers.ToElems(h,value))
    member _.content (value: int) = Helpers.MakeNode(h,a, "div", "content", Helpers.ToElems(h,value))
    member _.content (value: float) = Helpers.MakeNode(h,a, "div", "content", Helpers.ToElems(h,value))
    member _.content (value: 'Element) = Helpers.MakeNode(h,a, "div", "content", Helpers.ToElems(h,value))
    member _.content (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "content", Helpers.ToElems(h,children))

    member _.delete (value: 'Element) = Helpers.MakeNode(h,a, "button", "delete", Helpers.ToElems(h,value))
    member _.delete (children: seq<'Element>) = Helpers.MakeNode(h,a, "button", "delete", Helpers.ToElems(h,children))

    member _.image (value: 'Element) = Helpers.MakeNode(h,a, "figure", "image", Helpers.ToElems(h,value))
    member _.image (children: seq<'Element>) = Helpers.MakeNode(h,a, "figure", "image", Helpers.ToElems(h,children))

    member _.notification (value: string) = Helpers.MakeNode(h,a, "div", "notification", Helpers.ToElems(h,value))
    member _.notification (value: int) = Helpers.MakeNode(h,a, "div", "notification", Helpers.ToElems(h,value))
    member _.notification (value: float) = Helpers.MakeNode(h,a, "div", "notification", Helpers.ToElems(h,value))
    member _.notification (value: 'Element) = Helpers.MakeNode(h,a, "div", "notification", Helpers.ToElems(h,value))
    member _.notification (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "notification", Helpers.ToElems(h,children))

    member _.progress (value: string) = Helpers.MakeNode(h,a, "progress", "progress", Helpers.ToElems(h,value))
    member _.progress (value: int) = Helpers.MakeNode(h,a, "progress", "progress", Helpers.ToElems(h,value))
    member _.progress (value: float) = Helpers.MakeNode(h,a, "progress", "progress", Helpers.ToElems(h,value))
    member _.progress (value: 'Element) = Helpers.MakeNode(h,a, "progress", "progress", Helpers.ToElems(h,value))
    member _.progress (children: seq<'Element>) = Helpers.MakeNode(h,a, "progress", "progress", Helpers.ToElems(h,children))

    member _.table (value: 'Element) = Helpers.MakeNode(h,a, "table", "table", Helpers.ToElems(h,value))
    member _.table (children: seq<'Element>) = Helpers.MakeNode(h,a, "table", "table", Helpers.ToElems(h,children))

    member _.tableContainer (value: 'Element) = Helpers.MakeNode(h,a, "div", "table-container", Helpers.ToElems(h,value))
    member _.tableContainer (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "table-container", Helpers.ToElems(h,children))

    member _.tag (value: string) = Helpers.MakeNode(h,a, "span", "tag", Helpers.ToElems(h,value))
    member _.tag (value: int) = Helpers.MakeNode(h,a, "span", "tag", Helpers.ToElems(h,value))
    member _.tag (value: float) = Helpers.MakeNode(h,a, "span", "tag", Helpers.ToElems(h,value))
    member _.tag (value: 'Element) = Helpers.MakeNode(h,a, "span", "tag", Helpers.ToElems(h,value))
    member _.tag (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "tag", Helpers.ToElems(h,children))

    member _.tags (value: 'Element) = Helpers.MakeNode(h,a, "div", "tags", Helpers.ToElems(h,value))
    member _.tags (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "tags", Helpers.ToElems(h,children))

    member _.breadcrumb (value: 'Element) = Helpers.MakeNode(h,a, "nav", "breadcrumb", Helpers.ToElems(h,value))
    member _.breadcrumb (children: seq<'Element>) = Helpers.MakeNode(h,a, "nav", "breadcrumb", Helpers.ToElems(h,children))

    member _.card (value: 'Element) = Helpers.MakeNode(h,a, "div", "card", Helpers.ToElems(h,value))
    member _.card (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "card", Helpers.ToElems(h,children))

    member _.cardHeader (value: 'Element) = Helpers.MakeNode(h,a, "header", "card-header", Helpers.ToElems(h,value))
    member _.cardHeader (children: seq<'Element>) = Helpers.MakeNode(h,a, "header", "card-header", Helpers.ToElems(h,children))

    member _.cardImage (value: 'Element) = Helpers.MakeNode(h,a, "div", "card-image", Helpers.ToElems(h,value))
    member _.cardImage (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "card-image", Helpers.ToElems(h,children))

    member _.cardContent (value: string) = Helpers.MakeNode(h,a, "div", "card-content", Helpers.ToElems(h,value))
    member _.cardContent (value: int) = Helpers.MakeNode(h,a, "div", "card-content", Helpers.ToElems(h,value))
    member _.cardContent (value: float) = Helpers.MakeNode(h,a, "div", "card-content", Helpers.ToElems(h,value))
    member _.cardContent (value: 'Element) = Helpers.MakeNode(h,a, "div", "card-content", Helpers.ToElems(h,value))
    member _.cardContent (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "card-content", Helpers.ToElems(h,children))

    member _.cardFooter (value: 'Element) = Helpers.MakeNode(h,a, "footer", "card-footer", Helpers.ToElems(h,value))
    member _.cardFooter (children: seq<'Element>) = Helpers.MakeNode(h,a, "footer", "card-footer", Helpers.ToElems(h,children))

    member _.dropdown (value: 'Element) = Helpers.MakeNode(h,a, "div", "dropdown", Helpers.ToElems(h,value))
    member _.dropdown (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "dropdown", Helpers.ToElems(h,children))

    member _.dropdownTrigger (value: 'Element) = Helpers.MakeNode(h,a, "div", "dropdown-trigger", Helpers.ToElems(h,value))
    member _.dropdownTrigger (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "dropdown-trigger", Helpers.ToElems(h,children))

    member _.dropdownMenu (value: 'Element) = Helpers.MakeNode(h,a, "div", "dropdown-menu", Helpers.ToElems(h,value))
    member _.dropdownMenu (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "dropdown-menu", Helpers.ToElems(h,children))

    member _.dropdownContent (value: 'Element) = Helpers.MakeNode(h,a, "div", "dropdown-content", Helpers.ToElems(h,value))
    member _.dropdownContent (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "dropdown-content", Helpers.ToElems(h,children))

    member _.dropdownDivider (value: 'Element) = Helpers.MakeNode(h,a, "hr", "dropdown-divider", Helpers.ToElems(h,value))
    member _.dropdownDivider (children: seq<'Element>) = Helpers.MakeNode(h,a, "hr", "dropdown-divider", Helpers.ToElems(h,children))

    member _.menu (value: 'Element) = Helpers.MakeNode(h,a, "aside", "menu", Helpers.ToElems(h,value))
    member _.menu (children: seq<'Element>) = Helpers.MakeNode(h,a, "aside", "menu", Helpers.ToElems(h,children))

    member _.menuLabel (value: string) = Helpers.MakeNode(h,a, "p", "menu-label", Helpers.ToElems(h,value))
    member _.menuLabel (value: int) = Helpers.MakeNode(h,a, "p", "menu-label", Helpers.ToElems(h,value))
    member _.menuLabel (value: float) = Helpers.MakeNode(h,a, "p", "menu-label", Helpers.ToElems(h,value))
    member _.menuLabel (value: 'Element) = Helpers.MakeNode(h,a, "p", "menu-label", Helpers.ToElems(h,value))
    member _.menuLabel (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "menu-label", Helpers.ToElems(h,children))

    member _.menuList (value: 'Element) = Helpers.MakeNode(h,a, "ul", "menu-list", Helpers.ToElems(h,value))
    member _.menuList (children: seq<'Element>) = Helpers.MakeNode(h,a, "ul", "menu-list", Helpers.ToElems(h,children))

    member _.message (value: 'Element) = Helpers.MakeNode(h,a, "article", "message", Helpers.ToElems(h,value))
    member _.message (children: seq<'Element>) = Helpers.MakeNode(h,a, "article", "message", Helpers.ToElems(h,children))

    member _.messageHeader (value: 'Element) = Helpers.MakeNode(h,a, "div", "message-header", Helpers.ToElems(h,value))
    member _.messageHeader (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "message-header", Helpers.ToElems(h,children))

    member _.messageBody (value: string) = Helpers.MakeNode(h,a, "div", "message-body", Helpers.ToElems(h,value))
    member _.messageBody (value: int) = Helpers.MakeNode(h,a, "div", "message-body", Helpers.ToElems(h,value))
    member _.messageBody (value: float) = Helpers.MakeNode(h,a, "div", "message-body", Helpers.ToElems(h,value))
    member _.messageBody (value: 'Element) = Helpers.MakeNode(h,a, "div", "message-body", Helpers.ToElems(h,value))
    member _.messageBody (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "message-body", Helpers.ToElems(h,children))

    member _.modal (value: 'Element) = Helpers.MakeNode(h,a, "div", "modal", Helpers.ToElems(h,value))
    member _.modal (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "modal", Helpers.ToElems(h,children))

    member _.modalBackground (value: 'Element) = Helpers.MakeNode(h,a, "div", "modal-background", Helpers.ToElems(h,value))
    member _.modalBackground (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "modal-background", Helpers.ToElems(h,children))

    member _.modalClose (value: 'Element) = Helpers.MakeNode(h,a, "button", "modal-close", Helpers.ToElems(h,value))
    member _.modalClose (children: seq<'Element>) = Helpers.MakeNode(h,a, "button", "modal-close", Helpers.ToElems(h,children))

    member _.modalContent (value: string) = Helpers.MakeNode(h,a, "div", "modal-content", Helpers.ToElems(h,value))
    member _.modalContent (value: int) = Helpers.MakeNode(h,a, "div", "modal-content", Helpers.ToElems(h,value))
    member _.modalContent (value: float) = Helpers.MakeNode(h,a, "div", "modal-content", Helpers.ToElems(h,value))
    member _.modalContent (value: 'Element) = Helpers.MakeNode(h,a, "div", "modal-content", Helpers.ToElems(h,value))
    member _.modalContent (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "modal-content", Helpers.ToElems(h,children))

    member _.modalCard (value: 'Element) = Helpers.MakeNode(h,a, "div", "modal-card", Helpers.ToElems(h,value))
    member _.modalCard (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "modal-card", Helpers.ToElems(h,children))

    member _.modalCardHead (value: 'Element) = Helpers.MakeNode(h,a, "header", "modal-card-head", Helpers.ToElems(h,value))
    member _.modalCardHead (children: seq<'Element>) = Helpers.MakeNode(h,a, "header", "modal-card-head", Helpers.ToElems(h,children))

    member _.modalCardBody (value: 'Element) = Helpers.MakeNode(h,a, "section", "modal-card-body", Helpers.ToElems(h,value))
    member _.modalCardBody (children: seq<'Element>) = Helpers.MakeNode(h,a, "section", "modal-card-body", Helpers.ToElems(h,children))

    member _.modalCardFoot (value: 'Element) = Helpers.MakeNode(h,a, "footer", "modal-card-foot", Helpers.ToElems(h,value))
    member _.modalCardFoot (children: seq<'Element>) = Helpers.MakeNode(h,a, "footer", "modal-card-foot", Helpers.ToElems(h,children))

    member _.modalCardTitle (value: string) = Helpers.MakeNode(h,a, "p", "modal-card-title", Helpers.ToElems(h,value))
    member _.modalCardTitle (value: int) = Helpers.MakeNode(h,a, "p", "modal-card-title", Helpers.ToElems(h,value))
    member _.modalCardTitle (value: float) = Helpers.MakeNode(h,a, "p", "modal-card-title", Helpers.ToElems(h,value))
    member _.modalCardTitle (value: 'Element) = Helpers.MakeNode(h,a, "p", "modal-card-title", Helpers.ToElems(h,value))
    member _.modalCardTitle (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "modal-card-title", Helpers.ToElems(h,children))

    member _.navbar (value: 'Element) = Helpers.MakeNode(h,a, "nav", "navbar", Helpers.ToElems(h,value))
    member _.navbar (children: seq<'Element>) = Helpers.MakeNode(h,a, "nav", "navbar", Helpers.ToElems(h,children))

    member _.navbarDivider (value: 'Element) = Helpers.MakeNode(h,a, "hr", "navbar-divider", Helpers.ToElems(h,value))
    member _.navbarDivider (children: seq<'Element>) = Helpers.MakeNode(h,a, "hr", "navbar-divider", Helpers.ToElems(h,children))

    member _.navbarMenu (value: 'Element) = Helpers.MakeNode(h,a, "div", "navbar-menu", Helpers.ToElems(h,value))
    member _.navbarMenu (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "navbar-menu", Helpers.ToElems(h,children))

    member _.navbarBurger (value: 'Element) = Helpers.MakeNode(h,a, "a", "navbar-burger", Helpers.ToElems(h,value))
    member _.navbarBurger (children: seq<'Element>) = Helpers.MakeNode(h,a, "a", "navbar-burger", Helpers.ToElems(h,children))

    member _.pagination (value: 'Element) = Helpers.MakeNode(h,a, "nav", "pagination", Helpers.ToElems(h,value))
    member _.pagination (children: seq<'Element>) = Helpers.MakeNode(h,a, "nav", "pagination", Helpers.ToElems(h,children))

    member _.paginationList (value: 'Element) = Helpers.MakeNode(h,a, "ul", "pagination-list", Helpers.ToElems(h,value))
    member _.paginationList (children: seq<'Element>) = Helpers.MakeNode(h,a, "ul", "pagination-list", Helpers.ToElems(h,children))

    member _.paginationEllipsis (value: 'Element) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "span", "pagination-ellipsis", [h.text "…"] @ Helpers.ToElems(h,value))])
    member _.paginationEllipsis (children: seq<'Element>) = Helpers.MakeNode(h,a, "li", "", [Helpers.MakeNode(h,a, "span", "pagination-ellipsis", [h.text "…"] @ Helpers.ToElems(h,children))])

    member _.panel (value: 'Element) = Helpers.MakeNode(h,a, "nav", "panel", Helpers.ToElems(h,value))
    member _.panel (children: seq<'Element>) = Helpers.MakeNode(h,a, "nav", "panel", Helpers.ToElems(h,children))

    member _.panelHeading (value: 'Element) = Helpers.MakeNode(h,a, "p", "panel-heading", Helpers.ToElems(h,value))
    member _.panelHeading (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "panel-heading", Helpers.ToElems(h,children))

    member _.panelTabs (value: 'Element) = Helpers.MakeNode(h,a, "p", "panel-tabs", Helpers.ToElems(h,value))
    member _.panelTabs (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "panel-tabs", Helpers.ToElems(h,children))

    member _.panelIcon (value: 'Element) = Helpers.MakeNode(h,a, "span", "panel-icon", Helpers.ToElems(h,value))
    member _.panelIcon (children: seq<'Element>) = Helpers.MakeNode(h,a, "span", "panel-icon", Helpers.ToElems(h,children))

    member _.tabs (value: 'Element) = Helpers.MakeNode(h,a, "div", "tabs", Helpers.ToElems(h,value))
    member _.tabs (children: seq<'Element>) = Helpers.MakeNode(h,a, "div", "tabs", Helpers.ToElems(h,children))

    member _.tab (value: 'Element) = Helpers.MakeNode(h,a, "li", "tab", Helpers.ToElems(h,value))
    member _.tab (children: seq<'Element>) = Helpers.MakeNode(h,a, "li", "tab", Helpers.ToElems(h,children))

    member _.help (value: string) = Helpers.MakeNode(h,a, "p", "help", Helpers.ToElems(h,value))
    member _.help (value: int) = Helpers.MakeNode(h,a, "p", "help", Helpers.ToElems(h,value))
    member _.help (value: float) = Helpers.MakeNode(h,a, "p", "help", Helpers.ToElems(h,value))
    member _.help (value: 'Element) = Helpers.MakeNode(h,a, "p", "help", Helpers.ToElems(h,value))
    member _.help (children: seq<'Element>) = Helpers.MakeNode(h,a, "p", "help", Helpers.ToElems(h,children))


    member _.button = _button
    member _.title = _title
    member _.subtitle = _subtitle
    member _.control = _control
    member _.field = _field
    member _.fileLabel = _fileLabel
    member _.cardHeaderTitle = _cardHeaderTitle
    member _.cardHeaderIcon = _cardHeaderIcon
    member _.cardFooterItem = _cardFooterItem
    member _.dropdownItem = _dropdownItem
    member _.menuItem = _menuItem
    member _.navbarBrand = _navbarBrand
    member _.navbarStart = _navbarStart
    member _.navbarEnd = _navbarEnd
    member _.navbarItem = _navbarItem
    member _.navbarLink = _navbarLink
    member _.navbarDropdown = _navbarDropdown
    member _.paginationPrevious = _paginationPrevious
    member _.paginationNext = _paginationNext
    member _.paginationLink = _paginationLink
    member _.panelBlock = _panelBlock
    member _.input = _input
    member _.inputLabels = _inputLabels
    member _.text = _text
