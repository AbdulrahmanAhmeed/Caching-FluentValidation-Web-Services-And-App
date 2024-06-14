using Northwind.EntityModels;

namespace FluentValidation.Validators;

public class ProductValidator : AbstractValidator<Product>
{
  public ProductValidator()
  {
    RuleFor(product => product.ProductId)
      .NotEmpty(); // Not default(long) which is 0.

    RuleFor(order => order.ProductName)
      .NotNull()
      .WithName("Name"); // Use Name instead of CustomerName in messages.

   

   

    RuleFor(order => order.UnitPrice)
      .GreaterThan(0);

    

    
  }
}
