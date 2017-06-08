# oscSimpleExample lesson outline

* the readme.md file and [Markdown](https://daringfireball.net/projects/markdown/syntax)
* ### OSC Basics
  * use TouchOSC or CleanOSC -- install on your device
  * OSC is a  protocol for communicating realtime data across a network.
  * how OSC messages are formatted, e.g.:

    /1/xy1 0.5 0.5
  * typically, OSC sends numbers as decimal numbers that range from 0.0 to 1.0. TouchOSC allows you to configure this range to anything you like.
  * the url is arbitrary, but must start with a "/", and follow the url format. Each slash usually indicates a level of hierarchy. In the case of TouchOSC, the first level "/1" means a page of a multipage interface.
  * the sender always must set a proper network address and port. On a local network, this would be like:

      10.0.4.141:8000
  * where 10.0.1.141 is the IP address and 8000 is the port. The port is somewhat arbitrary, but be aware that there are many ports that are already reserved for other uses. For example, port "80" is the standard port for websites. See this page for more info http://www.webopedia.com/quick_ref/portnumbers.asp
* ### Code overview
  * the OSCReceiveSimple.cs file can be used as a template for your own code. See also the included UniOSCEventTargetImplementation.cs from UniOSC as another template.
  * the public "range" variable is a multiplier for the values that come in from the OSC message, allowing you to scale the amount of movement without changing values send in OSC.
  * the code checks to make sure there are values included in the OSC message by using "msg.Data.Count" which reports how many arguments there are
  * if the values are available, the code uses them (multiplied by range) to set the new x and y values for the position of the gameObject. the "z" value is left alone.
