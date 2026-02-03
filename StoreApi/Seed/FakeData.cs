using Bogus;
using StoreApi.Model;

namespace StoreApi.Seed;

public static class FakeData
{
    public static List<Product> GenerateFakeProducts(int count = 20)
    {
        string[] categories = { "Категория 1", "Категория 2", "Категория 3", "Категория 4", "Категория 5" };
        string[] specialTag = { "Рекомендуемый", "Новинка", "Топ за свои деньги" };

        return new Faker<Product>("ru")
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Description, f => f.Lorem.Sentence())
            .RuleFor(p => p.Category, f => f.PickRandom(categories))
            .RuleFor(p => p.SpecialTag, f => f.PickRandom(specialTag))
            .RuleFor(p => p.Price, f => Math.Round(f.Random.Double(1, 1000), 2))
            .RuleFor(p => p.ImageUrl, f => f.Image.PicsumUrl())
            .Generate(count);
    }
}