using BOL;
using MySql.Data.MySqlClient;
using System.Data;
namespace DAL;
public class DbManager
{
    public static string para=@"server=localhost;port=3306;user=root;password=kunal@8998;database=cartab";
        public static List<Car> GetAllCars(){

            List<Car> list = new List<Car>();
            MySqlConnection con = new MySqlConnection();
             con.ConnectionString=para;
             try{
              string query="select * from cartable";
             DataSet dataset=new DataSet();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            cmd.CommandText=query;
            MySqlDataAdapter data=new MySqlDataAdapter();
            data.SelectCommand=cmd;
            data.Fill(dataset);
            DataTable table=dataset.Tables[0];
            DataRowCollection row=table.Rows;
              foreach(DataRow i in row)
            {
                int CarID=int.Parse(i["CarID"].ToString());
                string CarName=(i["CarName"].ToString());
               string Company=(i["Company"].ToString());
               string Type=(i["Type"].ToString());

            Car std=new Car
            {
                CarID=CarID,
                CarName=CarName,
                Company=Company,
                Type=Type

            };
            list.Add(std);
            }

        }catch(Exception ex){
            Console.WriteLine(ex);
        }
        finally{
            con.Close();
        }
        return list;

        }

}
