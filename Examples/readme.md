# Unity Examples

## unityPhone.touchosc

An interface template for the these examples that used by the mobile app [TouchOSC](https://hexler.net/software/touchosc). These templates are designed on a computer, using the TouchOSC Editor, then transferred to the mobile device.

A free alternative to TouchOSC is [CleanOSC](    * https://itunes.apple.com/us/app/clean-osc/id1235192209?mt=8), which has a minimal visual interface, but can perform similar functions as TouchOSC.

## oscSimpleExample

A barebones example of a script, using the [UniOSC plugin](http://uniosc.monoflow.org) asset, that receives an OSC message with two arguments and translates that into x,y movement of the gameObject.

The example code draws on this [gist](    * https://gist.github.com/naojitaniguchi/58afae51ee98c5da38718bc70b2a609d) by @naojitaniguchi.

## animationState

An example of using the [Unity Animation Controller](https://unity3d.com/learn/tutorials/topics/animation/animator-controller?playlist=17099) to manage gameObject state, and control which animations are running.

The example uses UniOSC to recieve OSC messages to make changes to the current state.

Further non-animation uses of the built-in Unity statement management can be found in the Medium post [Don’t Re-invent Finite State Machines: How to Repurpose Unity’s Animator](https://medium.com/the-unity-developers-handbook/dont-re-invent-finite-state-machines-how-to-repurpose-unity-s-animator-7c6c421e5785) by Darren Tsung.
