namespace Feliz.ReactNative

open Fable.Core

[<Erase>]
type ReactNativeVersion =
    abstract member major: int
    abstract member minor: int
    abstract member patch: int
    abstract member prerelease: int option

[<Erase>]
type PlatformConstants =
    abstract member isTesting: bool
    abstract member reactNativeVersion: ReactNativeVersion

    // Android
    abstract member Version: int
    abstract member Release: string
    abstract member Serial: string
    abstract member Fingerprint: string
    abstract member Model: string
    abstract member Brand: string
    abstract member Manufacturer: string
    abstract member ServerHost: string option

    // iOS
    abstract member uiMode: string
    abstract member forceTouchAvailable: bool
    abstract member interfaceIdiom: string
    abstract member osVersion: string
    abstract member systemName: string

[<StringEnum; RequireQualifiedAccess>]
type OS =
    | [<CompiledName("ios")>] IOS
    | [<CompiledName("android")>] Android
    | [<CompiledName("windows")>] Windows
    | [<CompiledName("macos")>] MacOS
    | [<CompiledName("web")>] Web

[<Import("Platform", "react-native")>]
module Platform =
    let constants: PlatformConstants = jsNative
    let isIpad: bool = jsNative
    let isTV: bool = jsNative
    let isTesting: bool = jsNative
    let OS: OS = jsNative
    let Version: U2<int, string> = jsNative
