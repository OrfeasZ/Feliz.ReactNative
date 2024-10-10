namespace Feliz.ReactNative

open Fable.Core
open Fable.Core.JsInterop

[<StringEnum(CaseRules.LowerFirst)>]
type AppStateEvent =
    | Change
    | MemoryWarning
    | Focus
    | Blur

[<StringEnum(CaseRules.LowerFirst)>]
type AppStateStatus =
    | Active
    | Background
    | Inactive

[<Erase>]
type AppState =
    abstract addEventListener: AppStateEvent -> (AppStateStatus -> unit) -> NativeEventSubscription
    abstract currentState: AppStateStatus

module ReactNative =
    let AppState: AppState = import "AppState" "react-native"
