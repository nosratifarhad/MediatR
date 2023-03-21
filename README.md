# MediatR

### first You need to install the following packages :

```
NuGet\Install-Package MediatR.Extensions.Microsoft.DependencyInjection 
```
### You must pass the "Assembly" when adding the MediatR service to project , like this

```csharp
//services.AddMediatR(Assembly.GetExecutingAssembly());
services.AddMediatR(typeof(Program).Assembly);
```
### And the Final level for use "MediatR" : 
### You should use "IRequest" for command and query requests , like this :

```csharp

// ICommand  or command requests
public class CreateProductCommand : IRequest
{
    public string ProductTitle { get; set; }

    public string ProductName { get; set; }
}

// IQuery for get requests
public class GetProductQuery : IRequest<IEnumerable<ProductVM>>
{
    public int ProductId { get; set; }
}

```


