# Queries

This Queries library provides generic IQuery interfaces.

## Installation

Available on [nuget](https://www.nuget.org/packages/ReneWiersma.Queries/)

	PM> Install-Package ReneWiersma.Queries

### Example of IQuery implementation

```csharp
public class ExampleQuery : IQuery<string>
{
    public string Execute()
    {
        return "Some value";
    }
}
```

### Example of IQuery implementation with input paramater
The IQuery supports only one input parameter. If a query needs multiple input parameters, bundle them in a Parameter object.
```csharp
public class ExampleInputQuery : IQuery<int, string>
{
    public string Execute(int number)
    {
        return $"Here are {number} values";
    }
}
```
