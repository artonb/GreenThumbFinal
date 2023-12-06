using GreenThumbFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumbFinal.Database
{
    internal class GreenThumbDbContext : DbContext
    {
        public GreenThumbDbContext()
        {

        }
        public DbSet<Instructions> Instructions { get; set; }
        public DbSet<Plants> Plants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GreenThumbDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructions>().HasData(
            new Instructions
            {
                InstructionId = 1,
                Info = "Consistent Watering, establish consistent watering and use room temperature water.",
                PlantsId = 1
            },
            new Instructions
            {
                InstructionId = 2,
                Info = "Consistent Watering, establish consistent watering and use room temperature water.",
                PlantsId = 3
            },
            new Instructions
            {
                InstructionId = 3,
                Info = "Consistent Watering, establish consistent watering and use room temperature water.",
                PlantsId = 4
            },
            new Instructions
            {
                InstructionId = 4,
                Info = "Consistent Watering, establish consistent watering and use room temperature water.",
                PlantsId = 6
            },
            new Instructions
            {
                InstructionId = 5,
                Info = "Consistent Watering, establish consistent watering and use room temperature water.",
                PlantsId = 7
            },
            new Instructions
            {
                InstructionId = 6,
                Info = "Consistent Watering, establish consistent watering and use room temperature water.",
                PlantsId = 8
            },
            new Instructions
            {
                InstructionId = 7,
                Info = "Consistent Watering, establish consistent watering and use room temperature water.",
                PlantsId = 9
            },
            new Instructions
            {
                InstructionId = 8,
                Info = "Consistent Watering, establish consistent watering and use room temperature water.",
                PlantsId = 11
            },
            new Instructions
            {
                InstructionId = 9,
                Info = "Consistent Watering, establish consistent watering and use room temperature water.",
                PlantsId = 12
            },
            new Instructions
            {
                InstructionId = 10,
                Info = "Light Requirements, this plant require full sun.",
                PlantsId = 1
            },
            new Instructions
            {
                InstructionId = 11,
                Info = "Light Requirements, this plant require full sun.",
                PlantsId = 2
            },
            new Instructions
            {
                InstructionId = 12,
                Info = "Light Requirements, this plant require full sun.",
                PlantsId = 3
            },
            new Instructions
            {
                InstructionId = 13,
                Info = "Light Requirements, this plant require full sun.",
                PlantsId = 6
            },
            new Instructions
            {
                InstructionId = 14,
                Info = "Light Requirements, this plant require full sun.",
                PlantsId = 8
            },
            new Instructions
            {
                InstructionId = 15,
                Info = "Light Requirements, this plant require full sun.",
                PlantsId = 9
            },
            new Instructions
            {
                InstructionId = 16,
                Info = "Light Requirements, this plant require full sun.",
                PlantsId = 10
            },
            new Instructions
            {
                InstructionId = 17,
                Info = "Light Requirements, this plant require full sun.",
                PlantsId = 12
            },
            new Instructions
            {
                InstructionId = 18,
                Info = "Fertilization, follow a fertilization schedule suitable for your plants.",
                PlantsId = 2
            },
            new Instructions
            {
                InstructionId = 19,
                Info = "Fertilization, follow a fertilization schedule suitable for your plants.",
                PlantsId = 4
            },
            new Instructions
            {
                InstructionId = 20,
                Info = "Fertilization, follow a fertilization schedule suitable for your plants.",
                PlantsId = 6
            },
            new Instructions
            {
                InstructionId = 21,
                Info = "Fertilization, follow a fertilization schedule suitable for your plants.",
                PlantsId = 8
            },
            new Instructions
            {
                InstructionId = 22,
                Info = "Fertilization, follow a fertilization schedule suitable for your plants.",
                PlantsId = 10
            },
            new Instructions
            {
                InstructionId = 23,
                Info = "Fertilization, follow a fertilization schedule suitable for your plants.",
                PlantsId = 12
            },
            new Instructions
            {
                InstructionId = 24,
                Info = "Rotate Plants, rotate indoor plants periodically to ensure all sides receive adequate light.",
                PlantsId = 4
            },
            new Instructions
            {
                InstructionId = 25,
                Info = "Rotate Plants, rotate indoor plants periodically to ensure all sides receive adequate light.",
                PlantsId = 8
            },
            new Instructions
            {
                InstructionId = 26,
                Info = "Rotate Plants, rotate indoor plants periodically to ensure all sides receive adequate light.",
                PlantsId = 12
            },
            new Instructions
            {
                InstructionId = 27,
                Info = "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.",
                PlantsId = 1
            },
            new Instructions
            {
                InstructionId = 28,
                Info = "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.",
                PlantsId = 3
            },
            new Instructions
            {
                InstructionId = 29,
                Info = "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.",
                PlantsId = 5
            },
            new Instructions
            {
                InstructionId = 30,
                Info = "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.",
                PlantsId = 7
            },
            new Instructions
            {
                InstructionId = 31,
                Info = "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.",
                PlantsId = 9
            },
            new Instructions
            {
                InstructionId = 32,
                Info = "Humidity, use a humidifier or mist the plant occasionally to maintain adequate moisture.",
                PlantsId = 11
            },
            new Instructions
            {
                InstructionId = 33,
                Info = "Remove Dead Leaves and Flowers, regularly remove dead or yellowing leaves and spent flowers.",
                PlantsId = 5
            },
            new Instructions
            {
                InstructionId = 34,
                Info = "Remove Dead Leaves and Flowers, regularly remove dead or yellowing leaves and spent flowers.",
                PlantsId = 9
            },
            new Instructions
            {
                InstructionId = 35,
                Info = "Remove Dead Leaves and Flowers, regularly remove dead or yellowing leaves and spent flowers.",
                PlantsId = 12
            }
            );


            modelBuilder.Entity<Plants>().HasData(
            new Plants
            {
                PlantsId = 1,
                Name = "Marijuana"
            },
            new Plants
            {
                PlantsId = 2,
                Name = "Papaver somniferum"
            },
            new Plants
            {
                PlantsId = 3,
                Name = "Erythroxylum coca"
            },
            new Plants
            {
                PlantsId = 4,
                Name = "Psilocybe spp."
            },
            new Plants
            {
                PlantsId = 5,
                Name = "Lophophora williamsii"
            },
            new Plants
            {
                PlantsId = 6,
                Name = "Catha edulis"
            },
            new Plants
            {
                PlantsId = 7,
                Name = "Mitragyna speciosa"
            },
            new Plants
            {
                PlantsId = 8,
                Name = "Salvia"
            },
            new Plants
            {
                PlantsId = 9,
                Name = "Amanita muscaria"
            },
            new Plants
            {
                PlantsId = 10,
                Name = "Lactuca virosa"
            },
            new Plants
            {
                PlantsId = 11,
                Name = "Piper methysticum"
            },
            new Plants
            {
                PlantsId = 12,
                Name = "Areca catechu"
            }
            );
        }
    }
}


