using Microsoft.EntityFrameworkCore;
namespace HoptSport.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate(); }
            if(!context.Products.Any()){
                context.Products.AddRange(
                new Product
                {
                    Name = "Мяч", Description = "Круглый", Category = "Мячи", Price = 100
                },
                new Product
                {
                    Name = "Лодка", Description = "Резиновая удобная", Category = "Рыболовство", Price = 1000
                },
                new Product
                {
                    Name = "Спасательный жилет", Description = "Оранжевый", Category = "Рыболовство", Price = 200
                },
                new Product
                {
                    Name = "Гантели", Description = "Тяжелые", Category = "Спорт", Price = 2000
                },
                new Product
                {
                    Name = "Эспандер", Description = "Полезный", Category = "Спорт", Price = 100
                },
                new Product
                {
                    Name = "Турник", Description = "Домашний", Category = "Уют", Price = 400
                },
                new Product
                {
                    Name = "Кросовки", Description = "Беговые", Category = "Спорт", Price = 800
                });
                context.SaveChanges();
            }
        }
    }
}
