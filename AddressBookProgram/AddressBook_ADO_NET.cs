using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBook_ADO_NET
    {
        List<Contact> addressList = new List<Contact>();
        List<Contact> address_TDD = new List<Contact>(); //Multi Thread
        Contact contact = new Contact(); //multi thread
        public static  string connectionString = "Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog =AddressBook_Ado";
        SqlConnection sqlconnection = new SqlConnection(connectionString);
      
        /// <summary>
        /// Uc16 -Retrive All Data in sql Using Ado.Net
        /// Uc18
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
                            Console.WriteLine("FirstName:"+data.FirstName + "  "+"LastName:" + data.LastName + "  "+"Address:" + data.Address + "  "+"City:" + data.City + "  "+"State:" + data.State + "  "+"ZIP:" + data.Zip + "  "+"PhoneNo:" + data.PhoneNUmber+"  "+"Email:"+data.Email);
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
        /// <summary>
        /// UC17 Update data From Sql
        /// </summary>
        /// <param name="payRoll"></param>
        /// <exception cref="Exception"></exception>
        public string UpdateRecordFromAddressBook(string query)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand(query, this.sqlconnection);
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                    if (a>0)
                    {
                        Console.WriteLine("Update data in the employeePayRoleTable serivces");
                        return "Update";
                    }
                    else
                    {
                        Console.WriteLine("Not Update data in the employeePayRoleTable serivces");
                        return "NotUpdate";
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
        /// <summary>
        /// UC19 AggregateOrScalarFunction (count)
        /// </summary>
        public int AggGetAllEmployee(string query)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand(query, this.sqlconnection);
                    int b = (int)command.ExecuteScalar();
                    return b;
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
        /// <summary>
        /// Uc20 Add Address Contact
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void AddRecordEmployee( string query)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand(query, this.sqlconnection);
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                    if (a>0)
                    {
                        Console.WriteLine("Data Add in the employeePayRoleTable serivces");
                    }
                    else
                    {
                        Console.WriteLine("Not Data Add in the employeePayRoleTable serivces");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid Input");
            }
            finally
            {
                this.sqlconnection.Close();
            }
        }
        /// <summary>
        /// Uc21 Add Address Contact Multi Threading
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void AddRecordEmployee_WithThread(string query)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand(query, this.sqlconnection);
                    command.CommandType = CommandType.Text;
                    int a = command.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    Task thread = new Task(() =>
                    {
                        Console.WriteLine(" Employee being added ");
                        if (a>0)
                        {
                            Console.WriteLine("Employee added");
                        }
                    });
                    thread.Start();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
       
        }
    }
}
