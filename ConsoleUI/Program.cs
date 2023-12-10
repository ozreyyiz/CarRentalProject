// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager=new CarManager( new InMemoryCarDal() );

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.Descripion);
//}
Car car=new Car(
    
    );

carManager.Add();