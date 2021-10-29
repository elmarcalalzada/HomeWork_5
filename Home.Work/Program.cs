using System;

namespace Home.Work
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Product classi yaradin ve asagidaki xususiyyetleri olsun Name - mehsulun adini ifade eden xususiyyet BrandName - Mehsulun brand adi
            //Price - Mehsulun qiymeti.
            #region Product

            Product product1 = new Product
            {
                Name = "Winston Compact",
                BrandName = "Winston",
                Price = 3.4
            };

            Product product2 = new Product
            {
                Name = "LD Compact",
                BrandName = "LD",
                Price = 2.8
            };

            Product product3 = new Product
            {
                Name = "SOBRANIE Gold",
                BrandName = "SOBRANIE",
                Price = 3.9
            };

            Product product4 = new Product
            {
                Name = "Marlbro Gold",
                BrandName = "Marlbro",
                Price = 5

            };
            Product product5 = new Product
            {
                Name = "Parlament",
                BrandName = "Parlament",
                Price = 6
            };
            #endregion

            //3.Vehicle class-i yaradin Color ve Name xususiyyetleri olsun.Car classi yaradin Vehicleden miras alsin ve elave olaraq Brand,Model xususiyyetleri olsun
            #region Car

            Car car1 = new Car
            {
                Name = "Mercedes-Benz",
                Model = "170V",
                Brand = "Mercedes",
                Color = "Black",
                Engine = "2400"
            };

            Car car2 = new Car
            {
                Name = "Bentley Continental",
                Model = "Continental",
                Brand = "Bentley Motors Limited",
                Color = "Gray",
                Engine = "6000"
            };

            Car car3 = new Car
            {
                Name = "Rolls-Royce Wraith",
                Model = "Wraith",
                Brand = "Rolls-Royce",
                Color = "Black" ,
                Engine = "6500"
            };

            Car car4 = new Car
            {
                Name = "Lexus LX 570",
                Model = "LX 570",
                Brand = "Lexus",
                Color = "Black",
                Engine = "5700"
            };

            Car car5 = new Car
            {
                Name = "BMW X5 M",
                Model = "X5 M",
                Brand = "BMW",
                Color = "Silver",
                Engine = "4400"
            };
            #endregion

            Car[] cars = new Car[] { car1, car2, car3, car4, car5 };
            foreach (var car in cars)
            {
                Console.WriteLine($"BrandName-{car.Brand}, Name-{car.Name}, Model-{car.Model},  Color-{car.Color}, Engine-{car.Engine} ");
            }
        }

    }
}