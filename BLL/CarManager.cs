using BOL;
using DAL;
namespace BLL;
public class CarManager
{

    //we have to store data from db into list
    public List<Car> GetCarsData()
    {
        List<Car> carlst=new List<Car>();
        carlst = DbManager.GetAllCars();
        return carlst;
    }
  
}
