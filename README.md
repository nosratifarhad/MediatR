# MediatR

1 - Application Folder
    _ Application Layer 
       _ In This Layer , Handel Command And Queries .
       
2 -  Service Folder
    _ Service Layer 
       _ For Data Persistence And Use ORM (Entity FrameWork).

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

// IRequest or command requests
public class CreateProductCommand : IRequest
{
    public string ProductTitle { get; set; }

    public string ProductName { get; set; }
}

// IRequest for get requests
public class GetProductQuery : IRequest<IEnumerable<ProductVM>>
{
    public int ProductId { get; set; }
}

```


