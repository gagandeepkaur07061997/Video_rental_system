using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_system
{
    class Database_Class
    {
        private SqlConnection Obj_Conn = new SqlConnection();
        private readonly SqlCommand cmd = new SqlCommand();
        private readonly SqlDataReader Data_Reader;
        private SqlDataAdapter da = new SqlDataAdapter();
        string QueryString;
        public int CustomerID;
        public Database_Class()
        {
            string ConnString = @"Data Source=DESKTOP-19R6C8C\SQLEXPRESS;Initial Catalog=Videorental_system;Integrated Security=True";
            Obj_Conn.ConnectionString = ConnString;
        }

        public DataTable FillCustomer_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Customer";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable FillMovies_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Movies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public DataTable FillRental_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From RentedMovies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public string CustomerInsert(string FName, string LName, string Mobile, string Address)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address, Phone) Values(@FirstName,@LastName,@Address, @Mobile)";
                cmd.Parameters.AddWithValue("@FirstName", FName);
                cmd.Parameters.AddWithValue("@LastName", LName);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                cmd.ExecuteNonQuery();
                return "Customer Data is added Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }

            }
        }
        public string CustomerDelete()
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Obj_Conn;
                QueryString = "Delete from Customer where CustID =@CustID";
                cmd.Parameters.AddWithValue("@CustID", CustomerID);
                cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                cmd.ExecuteNonQuery();
                return "Customer Data Deleted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string CustomerUpdate(string FName, string LName, string Mobile, string Address)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Obj_Conn;
                QueryString = "update Customer set FirstName = @FirstName,LastName = @LastName,Address = @Address, Phone = @Mobile where CustID =@CustID";
                cmd.Parameters.AddWithValue("@FirstName", FName);
                cmd.Parameters.AddWithValue("@LastName", LName);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@CustID", CustomerID);
                cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                cmd.ExecuteNonQuery();
                return "Customer Data Updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)

                {
                    Obj_Conn.Close();
                }

            }

        }
                public string MovieInsert(string Rating_Rating, string Title_Title, string label_rental_cost, string label_year, string label_copies, string label_plot, string label_genre)
                {
                    try
                    {
                        cmd.Parameters.Clear();
                        cmd.Connection = Obj_Conn;
                       
                       QueryString = "Insert into Movie(MovieID,Rating,Title, Year,Rental_Cost, Copies, Plot, Genre) Values(@Rating,@Title,@year,@Copies, @Plot,@Genre)";
                       
                        cmd.Parameters.AddWithValue("@Rating", Rating_Rating);
                        cmd.Parameters.AddWithValue("@Title",Title_Title);
                        cmd.Parameters.AddWithValue("@Rental_cost" , label_rental_cost);
                        cmd.Parameters.AddWithValue("@Year", label_year);
                        cmd.Parameters.AddWithValue("@Copies", label_copies);
                        cmd.Parameters.AddWithValue("@Plot", label_plot);
                        cmd.Parameters.AddWithValue("@Genre", label_genre);
                        cmd.CommandText = QueryString;
                        //connection opened
                        Obj_Conn.Open();
                        // Executed query
                        cmd.ExecuteNonQuery();
                        return "Movie Data is added Successfully";
                    }
                    catch (Exception ex)
                    {
                        // show error Message
                        return ex.Message;
                    }
                    finally
                    {
                        // close connection
                        if (Obj_Conn != null)
                        {
                            Obj_Conn.Close();
                        }
                           }
                         }
                          }
                         }






