using DrivingSchool.Model.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchool.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<DrivingCategory>()
                .HasData(
                new DrivingCategory { CategoryId = 1, CategoryName = "А" },
                new DrivingCategory { CategoryId = 2, CategoryName = "B" },
                new DrivingCategory { CategoryId = 3, CategoryName = "C" },
                new DrivingCategory { CategoryId = 4, CategoryName = "CE" },
                new DrivingCategory { CategoryId = 5, CategoryName = "D" }
                );

            builder.Entity<Service>()
                .HasData(
                new Service { Id = 1, Description = "Дополнительное занятие по вождению на категорию \"А\" 15 рублей" },
                new Service { Id = 2, Description = "Дополнительное занятие по управлению автомобилем категории \"В\" 35 руб" },
                new Service { Id = 3, Description = "Дополнительное занятие по управлению автомобилем категории \"С\" 40 руб" },
                new Service { Id = 4, Description = "Дополнительное занятие по управлению составом транспортных средств категории \"СЕ\" 40 руб" },
                new Service { Id = 5, Description = "Дополнительное занятие по управлению автобусом (категория «D») 40 руб" }
                );
        }
    }
}
