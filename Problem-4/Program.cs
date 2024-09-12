public record Product(string Name, string Category, int Price, bool IsAvailable = true, Guid Id = default)
{
    public Guid Id { get; init; } = Guid.NewGuid();
}
public record Customer(string Name, string Email, Guid Id = default)
{
    public Guid Id { get; init; } = Guid.NewGuid();
}
public record Order(Customer customer, List<Product> products, Guid Id = default)
{
    public Guid Id { get; init; } = Guid.NewGuid();
}

class ECommerceManager
{
    List<Product> products = new List<Product>();
    List<Customer> customers = new List<Customer>();
    List<Order> orders = new List<Order>();
    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine($"Product '{product.Name}' added to the store.");

    }
    public void DeleteProduct(string name)
    {
        if (products.Any(product => product.Name == name))
        {
            products.Remove(products.FirstOrDefault(product => product.Name == name));
            Console.WriteLine($"Product removed successfully.");
        }
        else
        {
            Console.WriteLine($"There is no product with this name");
        }
    }
    public void DisplayAllProducts()
    {
        Console.WriteLine($"\nStore Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"Product {{ Id = {product.Id}, Name = {product.Name}, Category = {product.Category}, Price = {product.Price}, IsAvailable = {product.IsAvailable} }}");
        }
    }
    public void SearchForProductByName(string name)
    {
        Console.WriteLine($"\nSearching for products with '{name}':");
        var foundProduct = products.FirstOrDefault(product => product.Name == name);
        Console.WriteLine($"Product {{ Id = {foundProduct.Id}, Name = {foundProduct.Name}, Category = {foundProduct.Category}, Price = {foundProduct.Price}, IsAvailable = {foundProduct.IsAvailable} }}");

    }
    public void SearchForProductByCategory(string category)
    {
        var foundProduct = from product in products
                           where product.Category == category
                           select product;
        foreach (var product in foundProduct)
        {
            Console.WriteLine($"Product {{ Id = {product.Id}, Name = {product.Name}, Category = {product.Category}, Price = {product.Price}, IsAvailable = {product.IsAvailable} }}");
        }
    }
    public void SearchForProductByPrice(int price)
    {
        var foundProduct = from product in products
                           where product.Price == price
                           select product;
        foreach (var product in foundProduct)
        {
            Console.WriteLine($"Product {{ Id = {product.Id}, Name = {product.Name}, Category = {product.Category}, Price = {product.Price}, IsAvailable = {product.IsAvailable} }}");
        }
    }
    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
        Console.WriteLine($"Customer '{customer.Name}' added to the store.");
    }
    public void DeleteCustomer(string name)
    {
        if (customers.Any(customer => customer.Name == name))
        {
            customers.Remove(customers.FirstOrDefault(customer => customer.Name == name));
            Console.WriteLine($"Customer removed successfully.");
        }
        else
        {
            Console.WriteLine($"There is no customer with this name");
        }
    }
    public void DisplayAllCustomers()
    {
        Console.WriteLine($"\nStore Customers:");
        foreach (var customer in customers)
        {
            Console.WriteLine($"Customer {{ Id = {customer.Id}, Name = {customer.Name}, Email = {customer.Email} }}");
        }
    }
    public void SearchForCustomerByName(string name)
    {
        Console.WriteLine($"Searching for customer with '{name}':");
        var foundCustomer = customers.FirstOrDefault(customer => customer.Name == name);
        Console.WriteLine($"Customer {{ Id = {foundCustomer.Id}, Name = {foundCustomer.Name}, Email = {foundCustomer.Email} }}");
    }
    public void SearchForCustomerByEmail(string email)
    {
        Console.WriteLine($"Searching for customer with '{email}':");
        var foundCustomer = customers.FirstOrDefault(customer => customer.Email == email);
        Console.WriteLine($"Customer {{ Id = {foundCustomer.Id}, Name = {foundCustomer.Name}, Email = {foundCustomer.Email} }}");
    }
    public void PlaceOrder(Customer customer, params Product[] products)
    {
        Console.WriteLine($"\nPlacing an order:");
        List<Product> allProducts = new List<Product>();
        foreach (var product in products)
        {
            allProducts.Add(product);
        }
        Order order1 = new Order(customer, allProducts);
        orders.Add(order1);
        Console.WriteLine($"Order placed successfully for customer '{customer.Name}'.");
    }
    public void DisplayAllOrders()
    {
        Console.WriteLine($"\nDisplaying all orders:");
        foreach (var order in orders)
        {
            int total = 0;
            foreach (var product in order.products)
            {
                total = total + product.Price;
            }
            Console.WriteLine($"Order ID: {order.Id}, Customer: {order.customer.Name}, Total: ${total}, Date: [{DateTime.Now.ToShortDateString()}]");
            foreach (var product in order.products)
            {
                Console.WriteLine($"- {product.Name} (${product.Price})");
            }
        }
    }
}
class App
{
    public static void Main(string[] args)
    {
        ECommerceManager store = new ECommerceManager();
        Product product1 = new Product("Laptop", "Electronics", 1200);
        Product product2 = new Product("Phone", "Electronics", 800);
        Product product3 = new Product("Book", "Books", 20);
        store.AddProduct(product1);
        store.AddProduct(product2);
        store.AddProduct(product3);

        Customer customer1 = new Customer("Alice Johnson", "alice@example.com");
        Customer customer2 = new Customer("Bob Smith", "bob@example.com");
        store.AddCustomer(customer1);
        store.AddCustomer(customer2);

        store.DisplayAllProducts();
        store.DisplayAllCustomers();

        store.SearchForProductByName("Phone");
        store.PlaceOrder(customer1, product1, product2);
        store.DisplayAllOrders();
    }
}
