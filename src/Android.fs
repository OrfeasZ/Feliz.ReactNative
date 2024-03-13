namespace Feliz.ReactNative

open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type NativeEventSubscription =
    abstract remove: unit -> unit

[<Erase>]
type BackHandler =
    abstract addEventListener: string -> (unit -> bool) -> NativeEventSubscription
    abstract exitApp: unit -> unit
    abstract removeEventListener: string -> (unit -> bool) -> unit

module Android =
    let BackHandler: BackHandler = import "BackHandler" "react-native"
