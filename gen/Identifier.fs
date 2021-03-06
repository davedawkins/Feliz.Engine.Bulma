module Identifier

open System

let upperFirst (str : string) =
    str.[0..0].ToUpper() + str.[1..]

let kebabToPascalCamelCase (str : string) (isPascalCase : bool)=
    if String.IsNullOrEmpty(str) then str
    else
        let isUpper = Char.IsUpper
        let n = str.Length
        let builder = System.Text.StringBuilder()
        let appendCh (s:char) = builder.Append(s) |> ignore
        let rec loop i upper=
            let j, nextIsUpper =
                let ch : Char = str.[i]
                if (ch = '-') then
                    i + 1, true
                else
                    appendCh (if upper then Char.ToUpper(ch) else Char.ToLower(ch))
                    i + 1, false
            if j >= n then builder.ToString()
            else loop j nextIsUpper
        loop 0 isPascalCase

type System.String with
    member x.KebabToCamelCase() = kebabToPascalCamelCase x false
    member x.KebabToPascalCase() = kebabToPascalCamelCase x true
    member x.UpperFirst() = upperFirst x

