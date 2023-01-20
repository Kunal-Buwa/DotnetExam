using System.Collections.Generic;
namespace Car.Models;


public class Carmanager
{
    public static List<Cars> GetAllCars()
    {
        List<Cars> allcars= new List<Cars>();

        allcars.Add(new Cars ("sedan","maruti","black","10000"));
         allcars.Add(new Cars ("hatchback","Scoda","blue","12000"));
          allcars.Add(new Cars ("sedan","TATA","red","14000"));
           allcars.Add(new Cars ("hatchback","hyundai","white","18000"));
            allcars.Add(new Cars ("suv","ford","green","20000"));
            return allcars;
    }

}