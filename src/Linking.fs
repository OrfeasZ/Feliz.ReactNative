namespace Feliz.ReactNative

open Fable.Core
open Fable.Core.JS

type LinkingEvent = {| url: string |}

type EventSubscription = {| remove: unit -> unit |}

[<Import("Linking", "react-native")>]
module Linking =
    let addEventListener: System.Func<string, (LinkingEvent -> unit), EventSubscription> =
        jsNative

    let canOpenURL: string -> Promise<bool> = jsNative
    let getInitialURL: unit -> Promise<string option> = jsNative
    let openURL: string -> Promise<unit> = jsNative
