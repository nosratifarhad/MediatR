# MediatR

## More details about the architecture .

* 1 - Application Folder is Application Layer 
    * In This Layer , Have Command And Queries And Handlers .
* 2 - Service Folder is Service Layer 
    * For Data Persistence And Use ORM (Entity FrameWork). 

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
* Go To Application Folder (Layer) And Create Command Or Query and Use down Code in Application Layer .
* You should use "IRequest" for command and query requests , like this :

### Sample Command And CommandHandler

```csharp

// Use IRequest In Command Model
public class CreateProductCommand : IRequest
{
  public string ProductTitle { get; set; }

  public string ProductName { get; set; }
}
    
// Use IRequestHandler In Command Handler
public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
   public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
   {
      var createProductDto = GenereateCreateProductDtoFromaCommand(request);

      await _productService.CreateProduct(createProductDto).ConfigureAwait(false);

      return Unit.Value;
   }
}

```
### Sample Query And QueryHandler

```csharp

// Use IRequest In Query Model 
public class GetProductQuery : IRequest<IEnumerable<ProductVM>>
{
  public int ProductId { get; set; }
}

// Use IRequest In Query Handler
public class GetProductQueryHandler : IRequestHandler<GetProductQuery, IEnumerable<ProductVM>>
{
     public async Task<IEnumerable<ProductVM>> Handle(GetProductQuery request, CancellationToken cancellationToken)
     {
         var productVMList = await _productService.GetProduct().ConfigureAwait(false);

         return productVMList;
     }
}

```
![My Remote Image](https://github.com/nosratifarhad/MediatR/blob/main/imgs/Annotation.jpg)
![My Remote Image](https://github.com/nosratifarhad/MediatR/blob/main/imgs/Annotation1.jpg)
