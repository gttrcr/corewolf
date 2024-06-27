# CoreWolf

## Overview
CoreWolf is an open-source C# library designed to seamlessly integrate the Wolfram Language into your software applications. Whether you use Mathematica, Wolfram Engine, Wolfram Script, Wolfram Kernel, Wolfram One, or Wolfram Alpha extensively, CoreWolf provides an easy and cross-platform solution.

Unlike the C# library *NETLink* developed by Wolfram, which is limited to the Windows platform, CoreWolf is developed in .NET Core, making it usable on Windows, Linux, macOS, and all other OSs supported by .NET Core.

## Features
- **Cross-Platform**: Developed in .NET Core, compatible with Windows, Linux, macOS, and more.
- **Extensive Integration**: Access and utilize over 6500 built-in symbols of the Wolfram Engine.
- **Ease of Use**: Simplifies the syntax and command lexicon of the Wolfram Language for easier use.

## Installation
Clone the repository and build the library using the following command:
```sh
git clone git@github.com:gttrcr/corewolf.git
cd corewolf
dotnet build -c Release
```
This will produce the **CoreWolf/bin/Release/net8.0/CoreWolf.dll** file, which can be imported into your project.
Or download the package from nuget [https://www.nuget.org/packages/CoreWolf](https://www.nuget.org/packages/CoreWolf).

## Usage
Here are some examples demonstrating how to use CoreWolf in your projects.

### usings
```csharp
using CoreWolf;  //Core library
using CoreWolf.Types;  //Types namespace of the core library
```

### Sum
```csharp
Engine en = new();  //Get the instance of the engine
en.Execute("17 + 5"); // Execute a command
Console.WriteLine(en.Text);  // The value of en.Text will be 22
```
The result of the computation is always in the `Text` property of the `Engine` class.

### Expression Reduction
```csharp
en.Execute("Sin[x]^2 + Cos[x]^2").Reduce();
Console.WriteLine(en.Text);  // The value of en.Text is the boolean string 'True'
```

### Exact Integration
```csharp
en.Integrate("x^2", "{x, 2, 3}");
```

### Numerical Integration
```csharp
en.NIntegrate("x^E", "{x, 2, 3}");
```

### Exact Integration and Numerical Evaluation
```csharp
en.Integrate("x^2", "{x, 2, 3}");
en.N();  // This is equivalent to en.Integrate("x^2", "{x, 2, 3}").N();
```

### Drawing and Exporting a Plot
```csharp
en.Plot("Sqrt[Log[1 + x^2]]", "{x, Sin[3], 90}"); // Create a plot
en.Export("plot.jpg"); // Export the plot as a .jpg file
```
As always, you can concatenate every function. The previous example is equivalent to the following code
```csharp
en.Plot("Sqrt[Log[1 + x^2]]", "{x, Sin[3], 90}").Export("plot.jpg");
```

## Contribution
Contributions are welcome! Please open issues and submit pull requests to help improve CoreWolf.

### Building a New Library
To build a new version of the CoreWolf library, follow these steps:
```sh
cd Scraper
dotnet run Scraper
cd ../CoreWolf
rm -rf bin obj
cp ../README.md .
dotnet pack -c Release
```

## License
This project is licensed under the MIT License. See the LICENSE file for more details.
