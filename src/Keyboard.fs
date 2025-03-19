namespace Feliz.ReactNative

open Fable.Core
open Fable.Core.JS

[<Import("Keyboard", "react-native")>]
module Keyboard =
    let dismiss: unit -> unit = jsNative