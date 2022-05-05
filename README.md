# Feliz.ReactNative
React Native bindings for [Feliz](https://github.com/Zaid-Ajaj/Feliz)

Usage:
```fsharp
module App

open Feliz
open Feliz.ReactNative

[<ReactComponent>]
let Counter() =
    let (count, setCount) = React.useState(0)
    Comp.view [
        Comp.view [
            prop.style [
                style.width 50.
                style.height 50.
                style.backgroundColor "red"
            ]
            prop.onPress (fun _ -> setCount(count + 1))
            prop.text "Increment"
        ]

        Comp.text [
            prop.style [
                style.width 50.
                style.height 50.
                style.backgroundColor "blue"
            ]
            prop.onPress (fun _ -> setCount(count - 1))
            prop.text "Decrement"
        ]

        Comp.text count
    ]
```