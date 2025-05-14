namespace Feliz.ReactNative

open Fable.Core

[<Import("PixelRatio", "react-native")>]
module PixelRatio =
    let get: unit -> float = jsNative
    let getFontScale: unit -> float = jsNative
    let getPixelSizeForLayoutSize: float -> float = jsNative
    let roundToNearestPixel: float -> float = jsNative