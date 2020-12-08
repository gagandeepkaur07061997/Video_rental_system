using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_system
{
   public class Database_Class
    {
        private SqlConnection Obj_Conn = new SqlConnection();
        private readonly SqlCommand cmd = new SqlCommand();
        private readonly SqlDataReader Data_Reader;
        private SqlDataAdapter da = new SqlDataAdapter();
        string QueryString;
        public  string ConnString = @"Data Source=DESKTOP-19R6C8C\SQLEXPRESS;Initial Catalog=Videorental_system;Integrated Security=True";
        
        public int CustomerID, MovieID, Rental_ID;
        public Database_Class()
        {
            string ConnString = @"Data Source=DESKTOP-19R6C8C\SQLEXPRESS;Initial Catalog=Videorental_system;Integrated Security=True";
            Obj_Conn.ConnectionString = ConnString;
        }

        public DataTable FillCustomer_Data()// code to fill the customer data in its DGV//
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
        public DataTable FillMovies_Data()//code to load movies data in its DGV//
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

        public DataTable FillRental_Data()//code to show the data of rental in its DGV//
        {
            DataTable dt = new DataTable();
            QueryString = "select * From All_Rented";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public string CustomerInsert(string FName, string LName, string Mobile, string Address)// code to fill the customer data in the tabel on selecting or typing any data//
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
        public string CustomerDelete()// code to delete the customer data from its DGV on selecting or typing any data//
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Obj_Conn;

                cmd.CommandText = "Customer_Delete";
                cmd.CommandType = CommandType.StoredProcedure;

                //QueryString = "Delete from Customer where CustID =@CustID";

                cmd.Parameters.AddWithValue("@CustID", CustomerID);
                //cmd.CommandText = QueryString;
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
        public string CustomerUpdate(string FName, string LName, string Mobile, string Address)//code to update the customer data in its DGV on selecting or typing any data//
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
        public string Movieinsert(string Rating, string Title, string year, string rental_cost, string copies, string plot, string genre)//code to insert the movie data in its DGV on selecting or typing any data//
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Obj_Conn;

                QueryString = "Insert into Movies(Rating,Title,Rental_Cost,Year,Copies, Plot, Genre) Values(@Rating,@Title,@Rental_cost,@year,@Copies, @Plot,@Genre)";

                cmd.Parameters.AddWithValue("@Rating", Rating);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Rental_cost", rental_cost);

                cmd.Parameters.AddWithValue("@Copies", copies);
                cmd.Parameters.AddWithValue("@Plot", plot);
                cmd.Parameters.AddWithValue("@Genre", genre);
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
        public string MovieDelete()//code is called to delete the movie data in its DGV on selecting or typing any data//
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Obj_Conn;

                QueryString = "Delete from Movies where MovieID = @MovieID";

                cmd.Parameters.AddWithValue("@MovieID", MovieID);
                cmd.CommandText = QueryString;
                Obj_Conn.Open();
                cmd.ExecuteNonQuery();

                return "Movie Data Deleted Successfully";
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
        public string updatemovie(string Rating, string Title, string year, string rental_cost, string copies, string plot, string genre)//code is called to update the movie data in its DGV on selecting or typing any data//
        {
            try
            {
                cmd.Parameters.AddWithValue("@Rating", Rating);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Rental_cost", rental_cost);

                cmd.Parameters.AddWithValue("@Copies", copies);
                cmd.Parameters.AddWithValue("@Plot", plot);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                cmd.ExecuteNonQuery();
                return "Movie data Updated Successfully";
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
        public DataTable Rental_Load()//code is linked to insert the rental data in DGV//

        {
            DataTable dt = new DataTable();
            QueryString = "select * FromAll_Rented";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public DataTable FillAll_Rented_out()//code is linked to fill data of All rented out button//
        {
            DataTable dt = new DataTable();
            QueryString = "select * From All_Rented_out";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public string IssueMovie(DateTime Issue_date)//code is called to show data of issued movie to the customer//
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Obj_Conn;
                QueryString = "Insert into RentedMovies(MovieIDFK,CustIDFK,DateRented,DateReturned) values(@MovieID,@CustID,@Issue_date,Null)";
                cmd.Parameters.AddWithValue("@CustID", CustomerID);
                cmd.Parameters.AddWithValue("@MovieID", MovieID);
                cmd.Parameters.AddWithValue("@Issue_date", Issue_date);
                cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                cmd.ExecuteNonQuery();
                return "Movies issued to customer";
            }
            catch (Exception ex)
            {
                // code to show error Message
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

        //code to fill the customer data by using update query
        public string ReturnMovie(DateTime Return_Date)//code is called to show data of returned movie//
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = Obj_Conn;
                QueryString = "Update RentedMovies set DateReturned=@Return_date where RMID = @RMID";
                cmd.Parameters.AddWithValue("@Return_date", Return_Date);
                cmd.Parameters.AddWithValue("@RMID", Rental_ID);
                cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                cmd.ExecuteNonQuery();
                return "Movies returned from customer";
            }
            catch (Exception ex)
            {
                // code to show error Message
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

        public DataTable FillPopular_Customer_Data()//code is called to fill the popular customer data//
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Popular_Customer";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public DataTable FillPopular_movie_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Popular_movie";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
    }
}

         
    
    


        






