using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarAdd();
            // CarDelete();
            // CarUpdate();
            // CarGetAll();
            // GetCarDetail();
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 2, CarName = "MERCEDES", ModelYear = 2020, DailyPrice = 300, Description = "Alieye uygun" });
        }
        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId = 1 });
        }
        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 60, ModelYear = 1997, Description = "Yolda Kalabilir", CarName = "ŞAHİN" });
        }
        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
        private static void GetCarDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "-" + car.BrandName + "-" + car.ColorName + "-" + car.CarDailyInPrice);
            }

        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color
            {
                ColorName = "Yellow"
            });
        }
        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorId = 1 });
        }
        private static void ColorUpdate()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Update(new Color
            {
                ColorId = 1,
                ColorName = "Green"
            });

        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Mercedes" });

        }
        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Delete(new Brand { BrandId = 1 });

        }
        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Update(new Brand { BrandId = 1, BrandName = "Opel" });
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "İsrafil",
                LastName = "YİĞİT",
                Email = "israfilyigit@gmail.com",
                Password = "123"

            });

        }
        private static void UserDelete()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Update(new User { Id = 1 });
        }
        private static void UserUpdate()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Update(new User
            {
                Id = 1,
                FirstName = "İsrafil",
                LastName = "YİĞİT",
                Email = "israfilyigit@gmail.com",
                Password = "456"

            });
        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                CompanyName = "ATB"
            });

        }
        private static void CustomerDelete()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Update(new Customer
            {
                UserId = 1
            });

        }
        private static void CustomerUpdate()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Update(new Customer
            {
                UserId = 1,
                CompanyName = "Koç"
            });

        }

        private static void RentalAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = Convert.ToDateTime(10 / 1 / 2021),
                ReturnDate = Convert.ToDateTime(30 / 1 / 2021)
            });

        }
        private static void RentalDelete()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Delete(new Rental
            {
                 Id=1
            });
        }
        private static void RentalUpdate()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Update(new Rental
            {
                Id = 1,
                CarId = 1,
                CustomerId = 1,
                RentDate = Convert.ToDateTime(10 / 1 / 2021),
                ReturnDate = Convert.ToDateTime(29 / 1 / 2021)

            });




            }
    }


}
