// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
RentalManager rentalManager = new RentalManager(new EfRentalDal());



//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.Description);
//}

//ColorAddTest(colorManager);

//GetCarDetailFonk(carManager);

var rental = new Rental();


rental.CarId = 2;
rental.CustomerId = 1;
rental.RentDate = DateTime.Now;
rental.ReturnDate = null;

var result= rentalManager.Add(rental);


Console.WriteLine(result.Message);


static void ColorAddTest(ColorManager colorManager)
{
    Color color = new Color();
    color.ColorName = "White";
    color.ColorId = 1;

    colorManager.Add(color);
}

static void GetCarDetailFonk(CarManager carManager)
{
    var result = carManager.GetCarDetail();

    if (result.Success)
    {
        foreach (var car in carManager.GetCarDetail().Data)
        {
            Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.CarDailyPrice + " / " + car.CarDescription + " / " + car.ColorName);
        }
    }

    else
    {
        Console.WriteLine(result.Message);
    }
}