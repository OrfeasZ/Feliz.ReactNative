namespace Feliz.ReactNative

open System
open Feliz
open Fable.Core
open Fable.Core.JsInterop

type ReactChildren =
    abstract toArray: ReactElement -> ReactElement seq
    abstract toArray: ReactElement seq -> ReactElement seq

type IReactApi =
    abstract Children: ReactChildren
    abstract createElement: comp: obj * props: obj -> ReactElement
    abstract createElement: comp: obj * props: obj * [<ParamList>] children: ReactElement seq -> ReactElement
    abstract forwardRef: render: Func<'props, IRefValue<'t>, ReactElement> -> ('props -> IRefValue<'t> -> ReactElement)

[<RequireQualifiedAccess>]
module Interop =
    let reactApi: IReactApi = importDefault "react"

    let inline mkStyle (key: string) (value: 'a) : IStyleAttribute = unbox<IStyleAttribute> (key, value)

    let mkAttr = PropHelper.mkAttr

    [<Emit "undefined">]
    let undefined: obj = jsNative

    let createElement (_element: obj) (_props: obj) : ReactElement = import "createElement" "react"

    let inline createElementFromName (name: string) (properties: IReactProperty list) : ReactElement =
        createElement (import name "react-native") (createObj !!properties)

    let inline createElementFromNameWithChildren (name: string) (children: seq<ReactElement>) =
        createElement
            (import name "react-native")
            (createObj [ "children", reactApi.Children.toArray (Array.ofSeq children) ])