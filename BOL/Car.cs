namespace BOL;
public class Car
{
    public int CarID {get;set;}
    public string CarName {get;set;}
    public string Company {get;set;}
    public string Type {get;set;}


    public Car()
    {
        this.CarID=20;
        this.CarName="Innova";
        this.Company="Toyota";
        this.Type="Crossover";
    }
     public Car(int CarID,string CarName,string Company,string Type)
    {
        this.CarID=CarID;
        this.CarName=CarName;
        this.Company=Company;
        this.Type=Type;
    }

}
