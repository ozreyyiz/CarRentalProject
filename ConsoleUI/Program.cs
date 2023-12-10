// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager=new CarManager( new InMemoryCarDal() );
ColorManager colorManager=new ColorManager(new EfColorDal());


//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.Descripion);
//}

Color color=new Color();
color.ColorName = "La";
color.ColorId = 10;

colorManager.Add(color);
