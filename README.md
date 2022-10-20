# NetWolf

## What is NetWolf?
1. Do you use Mathematica extensively or wolfram engine/script/kernel/one/alpha?
2. Are you looking for an **easy** and **cross-platform** library to integrate wolfram into your software?
3. Don't you want to remember the syntax of the commands and the lexicon created for the wolfram language (WL)?

NetWolf is exactly what you need and didn't know you needed.

NetWolf is an open source c# library that allows you to fully interact with wolfram language by integrating all more than 6500 buildin symbols of engine. Unlike the c# library *NETLink* developed by Wolfram but usable only on Windows platform, NetWolf is developed in .NET Core and therefore usable on Windows, Linux, MacOS and all OS supported by .NET Core.

## How to use NetWolf?
The code can be compiled by running the command
```
dotnet build
```
and the **NetWolf.dll** library will be produced.
The library can be imported into your project and used. Here are some examples:

### Perform a simple operation (sum)
```
using NetWolf; //import the library
Link link = new Link();  //class link
Engine en = link.Engine;  //get the engine
en.Execute("17+5");  //use the engine to Execute a command
```
At the end, the value of property Text of en (en.Text) will be 22.

### Perform more complex operations
1. Reduction of an expression $\sin\left(x\right)^2+\cos\left(x\right)^2$
```
en.Execute("Sin[x]^2+Cos[x]^2==1).Reduce();
```
The value of en.Text is the boolen string 'True'.

2. Exact integration $\int_{2}^3 x^2 dx$
```
en.Integrate("x^2", "{x, 2, 3}");
```

3. Numerical integration $\int_{2}^3 x^e dx$
```
en.NIntegrate("x^E", "{x, 2, 3}")
```

4. Exact integration and than its numerical evaluation $\int_{2}^3 x^2 dx$
```
en.Integrate("x^2", "{x, 2, 3}")
en.N();
//is the same as en.Integrate("x^2", "{x, 2, 3}").N();
```

### Draw and export a plot
```
en.Plot("Sqrt[Log[1+x^2]]", "{x, Sin[3], 90}");  //create a plot
en.Export("plot.jpg");  //export a plot
```