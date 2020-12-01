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
        }
        public void Customer_Load()
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
        public void Movies_Load()
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
        public void Rental_Load()
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

        private void btn_add_Click(object sender, EventArgs e)
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

        private void btn_delete_Click(object sender, EventArgs e)
        {

            string message = Obj_Data.CustomerDelete();
            MessageBox.Show(message);
            First_Name.Text = "";
            Last_Name.Text = "";
            Mobile_Number.Text = "";
            Address_no.Text = "";
            Customer_Load();
        }

        private void btn_update_Click(object sender, EventArgs e)
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

        private void DGV_customer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                    label_customer_details.Text = DGV_customer.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + DGV_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong", ex.Message);
                }
            }

        private void btn_add_movie_Click(object sender, EventArgs e)
        {
            

                if (text_rating.Text != "" && text_title.Text != "" && text_year.Text != "" && text_rental_cost.Text != "" && text_copies.Text != "" && text_plot.Text != "" && text_genre.Text != "")
                {
                 string message = Obj_Data.MovieInsert( text_rating.Text, text_title.Text, text_year.Text, text_rental_cost.Text, text_copies.Text, text_plot.Text, text_genre.Text);
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

        private void btn_delete_movie_Click(object sender, EventArgs e)
        {
            
                string message = Obj_Data.CustomerDelete();
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
        }
    }

    
    

    
    
        
        
        

        

    

