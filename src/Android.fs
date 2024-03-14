namespace Feliz.ReactNative

open Fable.Core
open Fable.Core.JsInterop

[<StringEnum(CaseRules.LowerFirst)>]
type BackPressEventName = | HardwareBackPress

[<Erase>]
type NativeEventSubscription =
    abstract remove: unit -> unit

[<Erase>]
type BackHandler =
    abstract addEventListener: BackPressEventName -> (unit -> bool) -> NativeEventSubscription
    abstract exitApp: unit -> unit
    abstract removeEventListener: BackPressEventName -> (unit -> bool) -> unit

module Android =
    let BackHandler: BackHandler = import "BackHandler" "react-native"
