namespace ProductStore.DB;

public record Product
{
  public int Id { get; set; }
  public string Name { get; set; }
  public int Quantity { get; set; }
  public string Type { get; set; }
  public string Brand { get; set; }
}

public class ProductDB
{
  private static List<Product> _products = new List<Product>()
   {
     new Product{Id=1, Name="Chapéu"    , Quantity=3,   Type="Acessório",         Brand="Cowboy Selvagem"},
     new Product{Id=2, Name="Escova"    , Quantity=16,  Type="Utensílio",         Brand="Silky Hair"},
     new Product{Id=3, Name="Batedeira" , Quantity=2,   Type="Eletrodoméstico",   Brand="Agressão às Massas"},
   };

  public static List<Product> GetProducts()
  {
    return _products;
  }

  public static Product? GetProduct(int id)
  {
    return _products.SingleOrDefault(product => product.Id == id);
  }

  public static Product CreateProduct(Product product)
  {
    _products.Add(product);
    return product;
  }

  public static Product UpdateProduct(Product update)
  {
    _products = _products.Select(product =>
    {
      if (product.Id == update.Id)
      {
        product.Name = update.Name;
      }
      return product;
    }).ToList();
    return update;
  }

  public static void RemoveProduct(int id)
  {
    _products = _products.FindAll(product => product.Id != id).ToList();
  }
}