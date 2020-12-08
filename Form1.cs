using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_system
{
    public partial class Videorental : Form
    {
        Database_Class Obj_Data = new Database_Class();

        public Videorental()

        {
            InitializeComponent();
            Customer_Load();
            Movies_Load();
            Rental_Load();
            popularcustomer_load();
            popularmovie_load();
        }
        public void Customer_Load()//code to show customer data in DGV of customer//
        {
            DGV_customer.DataSource = null;
            try
            {
                DGV_customer.DataSource = Obj_Data.FillCustomer_Data();
                DGV_customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Movies_Load()//code to show movie data in DGV of movie//
        {
            DGV_movie.DataSource = null;
            try
            {
                DGV_movie.DataSource = Obj_Data.FillMovies_Data();
                DGV_movie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Rental_Load()//code to show data of movie in DGV of movie//
        {
            DGV_rental.DataSource = null;
            try
            {
                DGV_rental.DataSource = Obj_Data.FillRental_Data();
                DGV_rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)//code to add the data od customer on buton click//
        {

            if (First_Name.Text != "" && Last_Name.Text != "" && Address_no.Text != "" && Mobile_Number.Text != "")
            {
                string message = Obj_Data.CustomerInsert(First_Name.Text, Last_Name.Text, Mobile_Number.Text, Address_no.Text);
                MessageBox.Show(message);
                First_Name.Text = "";
                Last_Name.Text = "";
                Mobile_Number.Text = "";
                Address_no.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)//code to delete the data of customer on button click//
        {

            string message = Obj_Data.CustomerDelete();
            MessageBox.Show(message);
            First_Name.Text = "";
            Last_Name.Text = "";
            Mobile_Number.Text = "";
            Address_no.Text = "";
            Customer_Load();
        }

        private void btn_update_Click(object sender, EventArgs e)//code to update the data of customer on button click//
        {

            if (First_Name.Text != "" && Last_Name.Text != "" && Address_no.Text != "" && Mobile_Number.Text != "")
            {
                string message = Obj_Data.CustomerUpdate(First_Name.Text, Last_Name.Text, Mobile_Number.Text, Address_no.Text);
                MessageBox.Show(message);
                First_Name.Text = "";
                Last_Name.Text = "";
                Mobile_Number.Text = "";
                Address_no.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show(" All the fileds are required");
            }
        }

        private void DGV_customer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)//code to show data in rental and customer tabel while selecting from the DGV of customer//
        {

            try
            {
                string newvalue = DGV_customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.CustomerID = Convert.ToInt32(DGV_customer.Rows[e.RowIndex].Cells[0].Value);
                First_Name.Text = DGV_customer.Rows[e.RowIndex].Cells[1].Value.ToString();
                Last_Name.Text = DGV_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                Mobile_Number.Text = DGV_customer.Rows[e.RowIndex].Cells[4].Value.ToString();
                Address_no.Text = DGV_customer.Rows[e.RowIndex].Cells[3].Value.ToString();
                Customer_Name.Text = DGV_customer.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + DGV_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }


        private void DGV_movie_CellContentClick(object sender, DataGridViewCellEventArgs e)//code to show data in rental and movie tabel while selecting from the DGV of movie//

        {

            try
            {
                string newvalue = DGV_movie.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.MovieID = Convert.ToInt32(DGV_customer.Rows[e.RowIndex].Cells[0].Value);
                text_rating.Text = DGV_movie.Rows[e.RowIndex].Cells[1].Value.ToString();
                text_title.Text = DGV_movie.Rows[e.RowIndex].Cells[2].Value.ToString();
                text_year.Text = DGV_movie.Rows[e.RowIndex].Cells[3].Value.ToString();
                text_rental_cost.Text = DGV_movie.Rows[e.RowIndex].Cells[4].Value.ToString();
                text_copies.Text = DGV_movie.Rows[e.RowIndex].Cells[5].Value.ToString();
                text_plot.Text = DGV_movie.Rows[e.RowIndex].Cells[6].Value.ToString();
                text_genre.Text = DGV_movie.Rows[e.RowIndex].Cells[7].Value.ToString();
                Movie_Name.Text = DGV_movie.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }

        }

        private void btn_add_movie_Click(object sender, EventArgs e)//code to add data of movie on button click//

        {

            if (text_rating.Text != "" && text_title.Text != "" && text_year.Text != "" && text_rental_cost.Text != "" && text_copies.Text != "" && text_plot.Text != "" && text_genre.Text != "")
            {
                string message = Obj_Data.Movieinsert(text_rating.Text, text_title.Text, text_year.Text, text_rental_cost.Text, text_copies.Text, text_plot.Text, text_genre.Text);
                MessageBox.Show(message);

                text_rating.Text = "";
                text_title.Text = "";
                text_year.Text = "";
                text_rental_cost.Text = "";
                text_copies.Text = "";
                text_plot.Text = "";
                text_genre.Text = "";
                Movies_Load();
            }
            else
            {
                MessageBox.Show("All the fileds are required");
            }
        }

        private void btn_delete_movie_Click(object sender, EventArgs e)//code to add delete data of movie on button click//
        {

            string message = Obj_Data.MovieDelete();
            MessageBox.Show(message);
            text_rating.Text = "";
            text_title.Text = "";
            text_year.Text = "";
            text_rental_cost.Text = "";
            text_copies.Text = "";
            text_plot.Text = "";
            text_genre.Text = "";
            Movies_Load();

        }

        private void btn_update_movie_Click(object sender, EventArgs e)//code to update data of movie on button click//
        {

            if (text_rating.Text != "" && text_title.Text != "" && text_year.Text != "" && text_rental_cost.Text != "" && text_copies.Text != "" && text_plot.Text != "" && text_genre.Text != "")
            {
                string message = Obj_Data.updatemovie(text_rating.Text, text_title.Text, text_year.Text, text_rental_cost.Text, text_copies.Text, text_plot.Text, text_genre.Text);
                MessageBox.Show(message);
                text_rating.Text = "";
                text_title.Text = "";
                text_year.Text = "";
                text_rental_cost.Text = "";
                text_copies.Text = "";
                text_plot.Text = "";
                text_genre.Text = "";
                Movies_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
        }


        private void All_Rented_Click(object sender, EventArgs e)//code to load the data of All rentaled in its DGV//
        {
            Rental_Load();
        }

        private void Rented_out_Click(object sender, EventArgs e)//code to load the data of rentaled out in its DGV//
        {

            DGV_rental.DataSource = null;
            try
            {
                DGV_rental.DataSource = Obj_Data.FillAll_Rented_out();
                DGV_rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void issue_rental_Click(object sender, EventArgs e)// code to issue movie to any customer on button click//
        {

            if (Movie_Name.Text != "" && Customer_Name.Text != "")
            {
                string message = Obj_Data.IssueMovie(Convert.ToDateTime(btn_dateTimePicker.Text));
                MessageBox.Show(message);
                text_rating.Text = "";
                text_title.Text = "";
                text_year.Text = "";
                text_rental_cost.Text = "";
                text_copies.Text = "";
                text_plot.Text = "";
                text_genre.Text = "";
                Movie_Name.Text = "";
                First_Name.Text = "";
                Last_Name.Text = "";
                Mobile_Number.Text = "";
                Address_no.Text = "";
                Customer_Name.Text = "";

                Rental_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details//
                MessageBox.Show("Please fill all the required details and add the new details by clicking Add button");
            }
        }

        private void rental_returned_Click(object sender, EventArgs e)//code to load data of returened movie of any customer on button click//
        {
            
                if (movie_name_rental.Text != "" && customer_name_rental.Text != "")
                {
                    string message = Obj_Data.ReturnMovie(Convert.ToDateTime(btn_dateTimePicker2.Text));
                    MessageBox.Show(message);
                text_rating.Text = "";
                text_title.Text = "";
                text_year.Text = "";
                text_rental_cost.Text = "";
                text_copies.Text = "";
                text_plot.Text = "";
                text_genre.Text = "";
                movie_name_rental.Text = "";
                F_Name.Text = "";
                L_Name.Text = "";
                moile_number.Text = "";
                Address_label.Text = "";
                customer_name_rental.Text = "";
                
                Rental_Load();
                }
                else
                {
                    // code to show the message if user did not fill all the details//
                    MessageBox.Show("Please fill all the required details and add the new details by clicking Add button");
                }
            }

        private void DGV_rental_CellContentClick(object sender, DataGridViewCellEventArgs e)//code to add data of rental in its DGV //
        {
            try
            {
                string newvalue = DGV_rental.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.Rental_ID = Convert.ToInt32(DGV_rental.Rows[e.RowIndex].Cells[6].Value);
                Customer_Name.Text = DGV_rental.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + DGV_rental.Rows[e.RowIndex].Cells[1].Value.ToString();
                Movie_Name.Text = DGV_rental.Rows[e.RowIndex].Cells[2].Value.ToString();
                btn_dateTimePicker.Text = DGV_rental.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);//code to show message//
            }
        }

        public void popularcustomer_load()//code to show popular customer//
        {
            DGV_Popularcustomer.DataSource = null;
            try
            {
                DGV_Popularcustomer.DataSource = Obj_Data.FillPopular_Customer_Data();
                DGV_Popularcustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void popularmovie_load()//code to show the data of popular movie//
        {
            DGV_Popularmovie.DataSource = null;
            try
            {
                DGV_Popularmovie.DataSource = Obj_Data.FillPopular_movie_Data();
                DGV_Popularmovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
    }
    
    

















