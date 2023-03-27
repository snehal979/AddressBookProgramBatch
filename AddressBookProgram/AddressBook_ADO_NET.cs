using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBook_ADO_NET
    {
        List<Contact> addressList = new List<Contact>();
        public static string connectionString = "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog =AddressBook_Ado";
        SqlConnection sqlconnection = new SqlConnection(connectionString);
        /// <summary>
        /// Uc16 -Retrive All Data in Database Using Ado.Net
        /// </summary>
        /// <param name="query"></param>
        public int GetAllAddressBookData(string query)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand(query, this.sqlconnection);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Contact data = new Contact();
                            data.FirstName = dr.GetString(0);
                            data.LastName = dr.GetString(1);
                            data.Address = dr.GetString(2);
                            data.City = dr.GetString(3);
                            data.State = dr.GetString(4);
                            data.Zip = dr.GetInt64(5);
                            data.PhoneNUmber = dr.GetString(6);
                            data.Email = dr.GetString(7);
                            //Add Data in list
                            addressList.Add(data);
                        }
                        foreach (var data in addressList)
                        {
                            Console.WriteLine("Firstame:"+data.FirstName + "  "+"LastName:" + data.LastName + "  "+"Address:" + data.Address + "  "+"City:" + data.City + "  "+"State:" + data.State + "  "+"ZIP:" + data.Zip + "  "+"PhoneNo:" + data.PhoneNUmber+"  "+"Email:"+data.Email);
                        }
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("No Database found");
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.sqlconnection.Close();
            }
        }
    }
}
