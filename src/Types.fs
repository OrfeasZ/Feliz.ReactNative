namespace Feliz.ReactNative

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop

type ComponentLayout =
    {| width: float
       height: float
       x: float
       y: float |}

type LayoutEvent =
    { layout: ComponentLayout
      target: float }

type PressEvent =
    { changedTouches: PressEvent[]
      identifier: float
      locationX: float
      locationY: float
      pageX: float
      pageY: float
      target: float
      timestamp: float
      touches: PressEvent[] }

[<StringEnum; RequireQualifiedAccess>]
type AccessibilityRole =
    | Adjustable
    | Alert
    | Button
    | Checkbox
    | Combobox
    | Header
    | Image
    | Imagebutton
    | Keyboardkey
    | Link
    | Menu
    | Menubar
    | Menuitem
    | None
    | Progressbar
    | Radio
    | Radiogroup
    | Scrollbar
    | Search
    | Spinbutton
    | Summary
    | Switch
    | Tab
    | Tablist
    | Text
    | Timer
    | Togglebutton
    | Toolbar

type AccessibilityActions = { name: string; label: string option }

type TextLayout =
    { capHeight: float
      ascender: float
      descender: float
      width: float
      height: float
      xHeight: float
      x: float
      y: float }

type TextLayoutEvent = { lines: TextLayout[]; target: float }

type ImageLoadEvent =
    { source:
        {| uri: string
           width: float
           height: float |} }


type IRect =
    interface
    end

[<Erase>]
type Rect =
    static member inline top(value: float) = unbox<IRect> ("top", value)
    static member inline left(value: float) = unbox<IRect> ("left", value)
    static member inline right(value: float) = unbox<IRect> ("right", value)
    static member inline bottom(value: float) = unbox<IRect> ("bottom", value)

type IImageSource =
    interface
    end

type IImageSourceProp =
    interface
    end

type IImageCacheEnum =
    interface
    end

module ImageSource =
    [<Erase>]
    type cache =
        static member inline default' = unbox<IImageCacheEnum> "default"
        static member inline reload = unbox<IImageCacheEnum> "reload"
        static member inline forceCache = unbox<IImageCacheEnum> "force-cache"
        static member inline onlyIfCached = unbox<IImageCacheEnum> "only-if-cached"

    [<Erase>]
    type prop =
        static member inline uri(value: string) = unbox<IImageSourceProp> ("uri", value)

        static member inline width(value: float) =
            unbox<IImageSourceProp> ("width", value)

        static member inline height(value: float) =
            unbox<IImageSourceProp> ("height", value)

        static member inline scale(value: float) =
            unbox<IImageSourceProp> ("scale", value)

        /// Only on iOS.
        static member inline bundle(value: float) =
            unbox<IImageSourceProp> ("bundle", value)

        static member inline method(value: string) =
            unbox<IImageSourceProp> ("method", value)

        static member inline headers(value: obj) =
            unbox<IImageSourceProp> ("headers", value)

        static member inline body(value: string) = unbox<IImageSourceProp> ("body", value)

        static member inline cache(value: IImageCacheEnum) =
            unbox<IImageSourceProp> ("cache", value)

[<Erase>]
type ImageSource =
    static member inline local(path: string) =
        unbox<IImageSource> (importDefault path)

type ViewToken =
    { item: {| key: string |}
      key: string
      index: int
      isViewable: bool }

type IViewabilityConfig =
    interface
    end

[<Erase>]
type ViewabilityConfig =
    static member inline minimumViewTime(value: float) =
        unbox<IViewabilityConfig> ("minimumViewTime", value)

    static member inline viewAreaCoveragePercentThreshold(value: float) =
        unbox<IViewabilityConfig> ("viewAreaCoveragePercentThreshold", value)

    static member inline itemVisiblePercentThreshold(value: float) =
        unbox<IViewabilityConfig> ("itemVisiblePercentThreshold", value)

    static member inline waitForInteraction(value: bool) =
        unbox<IViewabilityConfig> ("waitForInteraction", value)

type IRippleConfig =
    interface
    end

[<Erase>]
type RippleConfig =
    static member inline color(value: string) = unbox<IRippleConfig> ("color", value)

    static member inline borderless(value: bool) =
        unbox<IRippleConfig> ("borderless", value)

    static member inline radius(value: float) = unbox<IRippleConfig> ("radius", value)

    static member inline foreground(value: bool) =
        unbox<IRippleConfig> ("foreground", value)

type FlatListItem<'Item> =
    { index: int
      item: 'Item
      separators:
          {| highlight: (unit -> unit)
             newProps: 'Item
             select: string
             unhighlight: (unit -> unit)
             updateProps: (unit -> unit) |} }

type ITransform =
    interface
    end

[<Erase>]
type transform =
    static member inline matrix(value: seq<float>) =
        unbox<ITransform> (createObj [ "matrix", value ])

    static member inline perspective(value: float) =
        unbox<ITransform> (createObj [ "perspective", value ])

    static member inline rotate(value: string) =
        unbox<ITransform> (createObj [ "rotate", value ])

    static member inline rotateX(value: string) =
        unbox<ITransform> (createObj [ "rotateX", value ])

    static member inline rotateY(value: string) =
        unbox<ITransform> (createObj [ "rotateY", value ])

    static member inline rotateZ(value: string) =
        unbox<ITransform> (createObj [ "rotateZ", value ])

    static member inline scale(value: float) =
        unbox<ITransform> (createObj [ "scale", value ])

    static member inline scaleX(value: float) =
        unbox<ITransform> (createObj [ "scaleX", value ])

    static member inline scaleY(value: float) =
        unbox<ITransform> (createObj [ "scaleY", value ])

    static member inline translateX(value: float) =
        unbox<ITransform> (createObj [ "translateX", value ])

    static member inline translateY(value: float) =
        unbox<ITransform> (createObj [ "translateY", value ])

    static member inline skewX(value: string) =
        unbox<ITransform> (createObj [ "skewX", value ])

    static member inline skewY(value: string) =
        unbox<ITransform> (createObj [ "skewY", value ])

[<Erase>]
type ScrollOptions =
    {| x: float option
       y: float option
       animated: bool option |}

[<Erase>]
type ScrollToEndOptions = {| animated: bool option |}

[<Erase>]
type NativeMethods =
    /// <summary>
    /// Determines the location on screen, width, and height of the given view and
    /// returns the values via an async callback. Note that these measurements are not available until after the rendering
    /// has been completed in native. If you need the measurements as soon as
    /// possible, consider using the <c>onLayout</c> instead.
    /// </summary>
    /// <param name="onSuccess">The callback called when the element successfully measures. The callback returns values for x, y, width, height, pageX and pageY.</param>
    abstract measure: (float -> float -> float -> float -> float -> float -> unit) -> unit

    /// <summary>
    /// Determines the location of the given view in the window and returns the
    /// values via an async callback. If the React root view is embedded in
    /// another native view, this will give you the absolute coordinates.
    /// Note that these measurements are not available until after the rendering
    /// has been completed in native.
    /// </summary>
    /// <param name="onSuccess">The callback called when the element successfully measures. The callback returns values for x, y, width and height.</param>
    abstract measureInWindow: (float -> float -> float -> float -> unit) -> unit

    /// <summary>
    /// Measures the view relative an ancestor,
    /// specified as <c>relativeToNativeComponentRef</c>. This means that the returned x, y
    /// are relative to the origin x, y of the ancestor view.
    /// Can also be called with a <c>relativeNativeNodeHandle</c> but is deprecated.
    /// </summary>
    /// <param name="relativeToNativeComponentRef">The ancestor element.</param>
    /// <param name="onSuccess">The callback called when the element successfully measures. The callback returns values for x, y, width and height.</param>
    /// <param name="onError">The callback called when an error occurred.</param>
    abstract measureLayout: HTMLElement -> (float -> float -> float -> float -> unit) -> (unit -> unit) option -> unit

[<Erase>]
type View =
    inherit HTMLElement
    inherit NativeMethods

[<Erase>]
type Pressable =
    inherit View

[<Erase>]
type ScrollView =
    inherit View
    abstract flushScrollIndicators: unit -> unit
    abstract scrollTo: ScrollOptions -> unit
    abstract scrollToEnd: ScrollToEndOptions -> unit
