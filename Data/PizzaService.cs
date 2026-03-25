namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        // Call your data access technology here
        // Returning an empty array for now so the code compiles
        // return Task.FromResult(Array.Empty<Pizza>());

        Pizza[] mockPizzas = new Pizza[]
        {
            new Pizza { PizzaId = 1, Name = "The Baconatorizor", Description = "It has EVERY kind of bacon", Price = 11.99M, Vegetarian = false, Vegan = false },
            new Pizza { PizzaId = 2, Name = "Margherita", Description = "Traditional Italian pizza with tomatoes and basil", Price = 9.99M, Vegetarian = true, Vegan = false },
            new Pizza { PizzaId = 3, Name = "Basic Cheese Pizza", Description = "It's cheesy and delicious. Why wouldn't you want one?", Price = 7.99M, Vegetarian = true, Vegan = false }
        };
        return Task.FromResult(mockPizzas);
    }
}
