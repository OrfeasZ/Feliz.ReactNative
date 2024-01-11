namespace Feliz.ReactNative

open Fable.Core
open Fable.Core.JsInterop
open Feliz.ReactNative.Animation.Types

[<Erase>]
type GestureState = {|
    stateID: int
    moveX: float
    moveY: float
    x0: float
    y0: float
    dx: float
    dy: float
    vx: float
    vy: float
    numberActiveTouches: int
|}

[<Erase>]
type PanResponder =
    static member inline create (config: seq<IPanResponderProp>): {| panHandlers: obj |} =
        let inline panResponderModule() = import "PanResponder" "react-native"
        panResponderModule?create (createObj !!config)


[<Erase>]
module gestureProp =
    [<Erase>]
    type pan =
        static member inline onMoveShouldSetPanResponder (f: PressEvent * GestureState -> bool) =
            unbox<IPanResponderProp> ("onMoveShouldSetPanResponder", f)

        static member inline onMoveShouldSetPanResponderCapture (f: PressEvent * GestureState -> bool) =
            unbox<IPanResponderProp> ("onMoveShouldSetPanResponderCapture", f)

        static member inline onStartShouldSetPanResponder (f: PressEvent * GestureState -> bool) =
            unbox<IPanResponderProp> ("onStartShouldSetPanResponder", f)

        static member inline onStartShouldSetPanResponderCapture (f: PressEvent * GestureState -> bool) =
            unbox<IPanResponderProp> ("onStartShouldSetPanResponderCapture", f)

        static member inline onPanResponderReject (f: PressEvent * GestureState -> unit) =
            unbox<IPanResponderProp> ("onPanResponderReject", f)

        static member inline onPanResponderGrant (f: PressEvent * GestureState -> unit) =
            unbox<IPanResponderProp> ("onPanResponderGrant", f)

        static member inline onPanResponderStart (f: PressEvent * GestureState -> unit) =
            unbox<IPanResponderProp> ("onPanResponderStart", f)

        static member inline onPanResponderEnd (f: PressEvent * GestureState -> unit) =
            unbox<IPanResponderProp> ("onPanResponderEnd", f)

        static member inline onPanResponderRelease (f: PressEvent * GestureState -> unit) =
            unbox<IPanResponderProp> ("onPanResponderRelease", f)

        static member inline onPanResponderMove (f: PressEvent * GestureState -> unit) =
            unbox<IPanResponderProp> ("onPanResponderMove", f)

        static member inline onPanResponderMoveAnimEvent (f: _ -> AnimEvent) =
            unbox<IPanResponderProp> ("onPanResponderMove", f)

        static member inline onPanResponderTerminate (f: PressEvent * GestureState -> unit) =
            unbox<IPanResponderProp> ("onPanResponderTerminate", f)

        static member inline onPanResponderTerminationRequest (f: PressEvent * GestureState -> bool) =
            unbox<IPanResponderProp> ("onPanResponderTerminationRequest", f)

        static member inline onShouldBlockNativeResponder (f: PressEvent * GestureState -> bool) =
            unbox<IPanResponderProp> ("onShouldBlockNativeResponder", f)

