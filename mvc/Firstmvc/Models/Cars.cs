namespace Car.Models;

public class Cars{
    public string type{get;set;}
    public string company{get;set;}
    public string color{get;set;}
    
    public string price{get;set;}

public Cars(string type,
    string company,
     string color,
     
     string price)
{
     this.type=type;
      this.company=company;
      this.color=color;
     
      this.price=price;
     
     

}


}