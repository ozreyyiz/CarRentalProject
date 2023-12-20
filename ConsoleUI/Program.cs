// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
ColorManager colorManager = new ColorManager(new EfColorDal());


//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.Description);
//}

//ColorAddTest(colorManager);

foreach (var car in carManager.GetCarDetail())
{
    Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.CarDailyPrice + " / " + car.CarDescription + " / " + car.ColorName);
}

static void ColorAddTest(ColorManager colorManager)
{
    Color color = new Color();
    color.ColorName = "White";
    color.ColorId = 1;

    colorManager.Add(color);
}
