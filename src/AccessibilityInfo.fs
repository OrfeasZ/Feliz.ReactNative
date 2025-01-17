namespace Feliz.ReactNative

open Fable.Core

[<Import("AccessibilityInfo", "react-native")>]
module AccessibilityInfo =
    let announceForAccessibility: string -> unit = jsNative