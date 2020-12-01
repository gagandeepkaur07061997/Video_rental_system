using System.Windows.Forms;

namespace Video_rental_system
{
    partial class Videorental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Movie_Rental = new System.Windows.Forms.TabControl();
            this.tab_customer = new System.Windows.Forms.TabPage();
            this.DGV_customer = new System.Windows.Forms.DataGridView();
            this.tab_movie = new System.Windows.Forms.TabPage();
            this.DGV_movie = new System.Windows.Forms.DataGridView();
            this.tab_rental = new System.Windows.Forms.TabPage();
            this.DGV_rental = new System.Windows.Forms.DataGridView();
            this.customer_panel = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.Address_no = new System.Windows.Forms.TextBox();
            this.Mobile_Number = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.label_customer_details = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.moile_number = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.F_Name = new System.Windows.Forms.Label();
            this.rental_panel = new System.Windows.Forms.Panel();
            this.btn_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_rental_details = new System.Windows.Forms.Label();
            this.btn_update_rental = new System.Windows.Forms.Button();
            this.btn_Delete_rental = new System.Windows.Forms.Button();
            this.btn_Add_rental = new System.Windows.Forms.Button();
            this.label_movie_details = new System.Windows.Forms.Label();
            this.label_movie_name = new System.Windows.Forms.Label();
            this.Rating_Rating = new System.Windows.Forms.Label();
            this.Title_Title = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_copies = new System.Windows.Forms.Label();
            this.label_plot = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.text_rating = new System.Windows.Forms.TextBox();
            this.text_title = new System.Windows.Forms.TextBox();
            this.text_year = new System.Windows.Forms.TextBox();
            this.text_copies = new System.Windows.Forms.TextBox();
            this.text_plot = new System.Windows.Forms.TextBox();
            this.text_genre = new System.Windows.Forms.TextBox();
            this.btn_add_movie = new System.Windows.Forms.Button();
            this.btn_delete_movie = new System.Windows.Forms.Button();
            this.btn_update_movie = new System.Windows.Forms.Button();
            this.label_rental_cost = new System.Windows.Forms.Label();
            this.text_rental_cost = new System.Windows.Forms.TextBox();
            this.movie_panel = new System.Windows.Forms.Panel();
            this.Movie_Rental.SuspendLayout();
            this.tab_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_customer)).BeginInit();
            this.tab_movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_movie)).BeginInit();
            this.tab_rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_rental)).BeginInit();
            this.customer_panel.SuspendLayout();
            this.rental_panel.SuspendLayout();
            this.movie_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Movie_Rental
            // 
            this.Movie_Rental.Controls.Add(this.tab_customer);
            this.Movie_Rental.Controls.Add(this.tab_movie);
            this.Movie_Rental.Controls.Add(this.tab_rental);
            this.Movie_Rental.Location = new System.Drawing.Point(345, 12);
            this.Movie_Rental.Name = "Movie_Rental";
            this.Movie_Rental.SelectedIndex = 0;
            this.Movie_Rental.Size = new System.Drawing.Size(512, 282);
            this.Movie_Rental.TabIndex = 0;
            // 
            // tab_customer
            // 
            this.tab_customer.BackColor = System.Drawing.Color.Yellow;
            this.tab_customer.Controls.Add(this.DGV_customer);
            this.tab_customer.Location = new System.Drawing.Point(4, 22);
            this.tab_customer.Name = "tab_customer";
            this.tab_customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_customer.Size = new System.Drawing.Size(504, 256);
            this.tab_customer.TabIndex = 0;
            this.tab_customer.Text = "Customer";
            // 
            // DGV_customer
            // 
            this.DGV_customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGV_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_customer.Location = new System.Drawing.Point(6, 6);
            this.DGV_customer.Name = "DGV_customer";
            this.DGV_customer.Size = new System.Drawing.Size(492, 247);
            this.DGV_customer.TabIndex = 0;
            this.DGV_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_customer_CellContentClick_1);
            this.DGV_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_customer_CellContentClick_1);
            // 
            // tab_movie
            // 
            this.tab_movie.BackColor = System.Drawing.Color.Yellow;
            this.tab_movie.Controls.Add(this.DGV_movie);
            this.tab_movie.Location = new System.Drawing.Point(4, 22);
            this.tab_movie.Name = "tab_movie";
            this.tab_movie.Padding = new System.Windows.Forms.Padding(3);
            this.tab_movie.Size = new System.Drawing.Size(504, 256);
            this.tab_movie.TabIndex = 1;
            this.tab_movie.Text = "Movie";
            // 
            // DGV_movie
            // 
            this.DGV_movie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DGV_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_movie.Location = new System.Drawing.Point(6, 6);
            this.DGV_movie.Name = "DGV_movie";
            this.DGV_movie.Size = new System.Drawing.Size(492, 244);
            this.DGV_movie.TabIndex = 0;
            // 
            // tab_rental
            // 
            this.tab_rental.BackColor = System.Drawing.Color.Yellow;
            this.tab_rental.Controls.Add(this.DGV_rental);
            this.tab_rental.Location = new System.Drawing.Point(4, 22);
            this.tab_rental.Name = "tab_rental";
            this.tab_rental.Padding = new System.Windows.Forms.Padding(3);
            this.tab_rental.Size = new System.Drawing.Size(504, 256);
            this.tab_rental.TabIndex = 2;
            this.tab_rental.Text = "Rental";
            // 
            // DGV_rental
            // 
            this.DGV_rental.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DGV_rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_rental.Location = new System.Drawing.Point(6, 6);
            this.DGV_rental.Name = "DGV_rental";
            this.DGV_rental.Size = new System.Drawing.Size(492, 238);
            this.DGV_rental.TabIndex = 0;
            // 
            // customer_panel
            // 
            this.customer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customer_panel.Controls.Add(this.btn_update);
            this.customer_panel.Controls.Add(this.btn_delete);
            this.customer_panel.Controls.Add(this.btn_add);
            this.customer_panel.Controls.Add(this.Address_no);
            this.customer_panel.Controls.Add(this.Mobile_Number);
            this.customer_panel.Controls.Add(this.Last_Name);
            this.customer_panel.Controls.Add(this.First_Name);
            this.customer_panel.Controls.Add(this.label_customer_details);
            this.customer_panel.Controls.Add(this.Address_label);
            this.customer_panel.Controls.Add(this.moile_number);
            this.customer_panel.Controls.Add(this.L_Name);
            this.customer_panel.Controls.Add(this.F_Name);
            this.customer_panel.Location = new System.Drawing.Point(12, 12);
            this.customer_panel.Name = "customer_panel";
            this.customer_panel.Size = new System.Drawing.Size(327, 192);
            this.customer_panel.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_update.Location = new System.Drawing.Point(240, 103);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 31);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_delete.Location = new System.Drawing.Point(240, 65);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 28);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add.Location = new System.Drawing.Point(240, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 29);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Address_no
            // 
            this.Address_no.Location = new System.Drawing.Point(93, 138);
            this.Address_no.Name = "Address_no";
            this.Address_no.Size = new System.Drawing.Size(100, 20);
            this.Address_no.TabIndex = 8;
            // 
            // Mobile_Number
            // 
            this.Mobile_Number.Location = new System.Drawing.Point(93, 105);
            this.Mobile_Number.Name = "Mobile_Number";
            this.Mobile_Number.Size = new System.Drawing.Size(100, 20);
            this.Mobile_Number.TabIndex = 7;
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(93, 73);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(100, 20);
            this.Last_Name.TabIndex = 6;
            // 
            // First_Name
            // 
            this.First_Name.BackColor = System.Drawing.Color.White;
            this.First_Name.Location = new System.Drawing.Point(93, 35);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(100, 20);
            this.First_Name.TabIndex = 5;
            // 
            // label_customer_details
            // 
            this.label_customer_details.AutoSize = true;
            this.label_customer_details.BackColor = System.Drawing.Color.Yellow;
            this.label_customer_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_customer_details.Location = new System.Drawing.Point(63, 9);
            this.label_customer_details.Name = "label_customer_details";
            this.label_customer_details.Size = new System.Drawing.Size(118, 15);
            this.label_customer_details.TabIndex = 4;
            this.label_customer_details.Text = "CUSTOMER DETAILS";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Address_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Address_label.Location = new System.Drawing.Point(12, 141);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(47, 15);
            this.Address_label.TabIndex = 3;
            this.Address_label.Text = "Address";
            // 
            // moile_number
            // 
            this.moile_number.AutoSize = true;
            this.moile_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.moile_number.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moile_number.Location = new System.Drawing.Point(12, 108);
            this.moile_number.Name = "moile_number";
            this.moile_number.Size = new System.Drawing.Size(60, 15);
            this.moile_number.TabIndex = 2;
            this.moile_number.Text = "Mobile No.";
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.L_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L_Name.Location = new System.Drawing.Point(12, 73);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(60, 15);
            this.L_Name.TabIndex = 1;
            this.L_Name.Text = "Last Name";
            // 
            // F_Name
            // 
            this.F_Name.AutoSize = true;
            this.F_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.F_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.F_Name.Location = new System.Drawing.Point(12, 35);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(37, 15);
            this.F_Name.TabIndex = 0;
            this.F_Name.Text = "Name";
            // 
            // rental_panel
            // 
            this.rental_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rental_panel.Controls.Add(this.btn_dateTimePicker2);
            this.rental_panel.Controls.Add(this.btn_dateTimePicker);
            this.rental_panel.Controls.Add(this.textBox9);
            this.rental_panel.Controls.Add(this.textBox8);
            this.rental_panel.Controls.Add(this.label13);
            this.rental_panel.Controls.Add(this.label12);
            this.rental_panel.Controls.Add(this.label11);
            this.rental_panel.Controls.Add(this.label10);
            this.rental_panel.Controls.Add(this.label_rental_details);
            this.rental_panel.Controls.Add(this.btn_update_rental);
            this.rental_panel.Controls.Add(this.btn_Delete_rental);
            this.rental_panel.Controls.Add(this.btn_Add_rental);
            this.rental_panel.Location = new System.Drawing.Point(432, 311);
            this.rental_panel.Name = "rental_panel";
            this.rental_panel.Size = new System.Drawing.Size(405, 160);
            this.rental_panel.TabIndex = 3;
            // 
            // btn_dateTimePicker2
            // 
            this.btn_dateTimePicker2.Location = new System.Drawing.Point(115, 124);
            this.btn_dateTimePicker2.Name = "btn_dateTimePicker2";
            this.btn_dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.btn_dateTimePicker2.TabIndex = 11;
            // 
            // btn_dateTimePicker
            // 
            this.btn_dateTimePicker.Location = new System.Drawing.Point(115, 95);
            this.btn_dateTimePicker.Name = "btn_dateTimePicker";
            this.btn_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.btn_dateTimePicker.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(115, 67);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(115, 38);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(17, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Returned Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(17, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Issue Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(17, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Movie Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Customer Name";
            // 
            // label_rental_details
            // 
            this.label_rental_details.AutoSize = true;
            this.label_rental_details.BackColor = System.Drawing.Color.Yellow;
            this.label_rental_details.Location = new System.Drawing.Point(132, 10);
            this.label_rental_details.Name = "label_rental_details";
            this.label_rental_details.Size = new System.Drawing.Size(73, 13);
            this.label_rental_details.TabIndex = 3;
            this.label_rental_details.Text = "Rental Details";
            // 
            // btn_update_rental
            // 
            this.btn_update_rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_update_rental.Location = new System.Drawing.Point(327, 116);
            this.btn_update_rental.Name = "btn_update_rental";
            this.btn_update_rental.Size = new System.Drawing.Size(75, 23);
            this.btn_update_rental.TabIndex = 2;
            this.btn_update_rental.Text = "Update";
            this.btn_update_rental.UseVisualStyleBackColor = false;
            // 
            // btn_Delete_rental
            // 
            this.btn_Delete_rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Delete_rental.Location = new System.Drawing.Point(321, 70);
            this.btn_Delete_rental.Name = "btn_Delete_rental";
            this.btn_Delete_rental.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete_rental.TabIndex = 1;
            this.btn_Delete_rental.Text = "Delete";
            this.btn_Delete_rental.UseVisualStyleBackColor = false;
            // 
            // btn_Add_rental
            // 
            this.btn_Add_rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Add_rental.Location = new System.Drawing.Point(321, 27);
            this.btn_Add_rental.Name = "btn_Add_rental";
            this.btn_Add_rental.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_rental.TabIndex = 0;
            this.btn_Add_rental.Text = "Add";
            this.btn_Add_rental.UseVisualStyleBackColor = false;
            // 
            // label_movie_details
            // 
            this.label_movie_details.AutoSize = true;
            this.label_movie_details.BackColor = System.Drawing.Color.Yellow;
            this.label_movie_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_movie_details.Location = new System.Drawing.Point(63, 19);
            this.label_movie_details.Name = "label_movie_details";
            this.label_movie_details.Size = new System.Drawing.Size(73, 15);
            this.label_movie_details.TabIndex = 0;
            this.label_movie_details.Text = "Movie Details";
            // 
            // label_movie_name
            // 
            this.label_movie_name.AutoSize = true;
            this.label_movie_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_movie_name.Location = new System.Drawing.Point(9, 38);
            this.label_movie_name.Name = "label_movie_name";
            this.label_movie_name.Size = new System.Drawing.Size(2, 15);
            this.label_movie_name.TabIndex = 1;
            // 
            // Rating_Rating
            // 
            this.Rating_Rating.AutoSize = true;
            this.Rating_Rating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rating_Rating.Location = new System.Drawing.Point(9, 69);
            this.Rating_Rating.Name = "Rating_Rating";
            this.Rating_Rating.Size = new System.Drawing.Size(43, 15);
            this.Rating_Rating.TabIndex = 2;
            this.Rating_Rating.Text = " Rating";
            // 
            // Title_Title
            // 
            this.Title_Title.AutoSize = true;
            this.Title_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title_Title.Location = new System.Drawing.Point(10, 101);
            this.Title_Title.Name = "Title_Title";
            this.Title_Title.Size = new System.Drawing.Size(29, 15);
            this.Title_Title.TabIndex = 3;
            this.Title_Title.Text = "Title";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_year.Location = new System.Drawing.Point(9, 131);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(31, 15);
            this.label_year.TabIndex = 4;
            this.label_year.Text = "Year";
            // 
            // label_copies
            // 
            this.label_copies.AutoSize = true;
            this.label_copies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_copies.Location = new System.Drawing.Point(11, 176);
            this.label_copies.Name = "label_copies";
            this.label_copies.Size = new System.Drawing.Size(41, 15);
            this.label_copies.TabIndex = 5;
            this.label_copies.Text = "Copies";
            // 
            // label_plot
            // 
            this.label_plot.AutoSize = true;
            this.label_plot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_plot.Location = new System.Drawing.Point(13, 202);
            this.label_plot.Name = "label_plot";
            this.label_plot.Size = new System.Drawing.Size(27, 15);
            this.label_plot.TabIndex = 6;
            this.label_plot.Text = "Plot";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_genre.Location = new System.Drawing.Point(10, 230);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(38, 15);
            this.label_genre.TabIndex = 7;
            this.label_genre.Text = "Genre";
            // 
            // text_rating
            // 
            this.text_rating.Location = new System.Drawing.Point(111, 64);
            this.text_rating.Name = "text_rating";
            this.text_rating.Size = new System.Drawing.Size(100, 20);
            this.text_rating.TabIndex = 9;
            // 
            // text_title
            // 
            this.text_title.Location = new System.Drawing.Point(111, 90);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(100, 20);
            this.text_title.TabIndex = 10;
            // 
            // text_year
            // 
            this.text_year.Location = new System.Drawing.Point(111, 116);
            this.text_year.Name = "text_year";
            this.text_year.Size = new System.Drawing.Size(100, 20);
            this.text_year.TabIndex = 11;
            // 
            // text_copies
            // 
            this.text_copies.Location = new System.Drawing.Point(111, 168);
            this.text_copies.Name = "text_copies";
            this.text_copies.Size = new System.Drawing.Size(100, 20);
            this.text_copies.TabIndex = 12;
            // 
            // text_plot
            // 
            this.text_plot.Location = new System.Drawing.Point(110, 193);
            this.text_plot.Name = "text_plot";
            this.text_plot.Size = new System.Drawing.Size(100, 20);
            this.text_plot.TabIndex = 13;
            // 
            // text_genre
            // 
            this.text_genre.Location = new System.Drawing.Point(111, 222);
            this.text_genre.Name = "text_genre";
            this.text_genre.Size = new System.Drawing.Size(100, 20);
            this.text_genre.TabIndex = 14;
            // 
            // btn_add_movie
            // 
            this.btn_add_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_movie.Location = new System.Drawing.Point(240, 54);
            this.btn_add_movie.Name = "btn_add_movie";
            this.btn_add_movie.Size = new System.Drawing.Size(75, 23);
            this.btn_add_movie.TabIndex = 15;
            this.btn_add_movie.Text = "Add";
            this.btn_add_movie.UseVisualStyleBackColor = false;
            this.btn_add_movie.Click += new System.EventHandler(this.btn_add_movie_Click);
            // 
            // btn_delete_movie
            // 
            this.btn_delete_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_delete_movie.Location = new System.Drawing.Point(240, 101);
            this.btn_delete_movie.Name = "btn_delete_movie";
            this.btn_delete_movie.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_movie.TabIndex = 16;
            this.btn_delete_movie.Text = "Delete";
            this.btn_delete_movie.UseVisualStyleBackColor = false;
            this.btn_delete_movie.Click += new System.EventHandler(this.btn_delete_movie_Click);
            // 
            // btn_update_movie
            // 
            this.btn_update_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_update_movie.Location = new System.Drawing.Point(240, 146);
            this.btn_update_movie.Name = "btn_update_movie";
            this.btn_update_movie.Size = new System.Drawing.Size(75, 23);
            this.btn_update_movie.TabIndex = 17;
            this.btn_update_movie.Text = "Update";
            this.btn_update_movie.UseVisualStyleBackColor = false;
            // 
            // label_rental_cost
            // 
            this.label_rental_cost.AutoSize = true;
            this.label_rental_cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_rental_cost.Location = new System.Drawing.Point(10, 151);
            this.label_rental_cost.Name = "label_rental_cost";
            this.label_rental_cost.Size = new System.Drawing.Size(66, 15);
            this.label_rental_cost.TabIndex = 18;
            this.label_rental_cost.Text = "Rental_cost";
            // 
            // text_rental_cost
            // 
            this.text_rental_cost.Location = new System.Drawing.Point(111, 142);
            this.text_rental_cost.Name = "text_rental_cost";
            this.text_rental_cost.Size = new System.Drawing.Size(100, 20);
            this.text_rental_cost.TabIndex = 19;
            // 
            // movie_panel
            // 
            this.movie_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.movie_panel.Controls.Add(this.text_rental_cost);
            this.movie_panel.Controls.Add(this.label_rental_cost);
            this.movie_panel.Controls.Add(this.btn_update_movie);
            this.movie_panel.Controls.Add(this.btn_delete_movie);
            this.movie_panel.Controls.Add(this.btn_add_movie);
            this.movie_panel.Controls.Add(this.text_genre);
            this.movie_panel.Controls.Add(this.text_plot);
            this.movie_panel.Controls.Add(this.text_copies);
            this.movie_panel.Controls.Add(this.text_year);
            this.movie_panel.Controls.Add(this.text_title);
            this.movie_panel.Controls.Add(this.text_rating);
            this.movie_panel.Controls.Add(this.label_genre);
            this.movie_panel.Controls.Add(this.label_plot);
            this.movie_panel.Controls.Add(this.label_copies);
            this.movie_panel.Controls.Add(this.label_year);
            this.movie_panel.Controls.Add(this.Title_Title);
            this.movie_panel.Controls.Add(this.Rating_Rating);
            this.movie_panel.Controls.Add(this.label_movie_name);
            this.movie_panel.Controls.Add(this.label_movie_details);
            this.movie_panel.Location = new System.Drawing.Point(12, 210);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(327, 261);
            this.movie_panel.TabIndex = 2;
            // 
            // Videorental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Video_rental_system.Properties.Resources.Abccccc;
            this.ClientSize = new System.Drawing.Size(857, 483);
            this.Controls.Add(this.rental_panel);
            this.Controls.Add(this.movie_panel);
            this.Controls.Add(this.customer_panel);
            this.Controls.Add(this.Movie_Rental);
            this.Name = "Videorental";
            this.Text = "Form1";
            this.Movie_Rental.ResumeLayout(false);
            this.tab_customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_customer)).EndInit();
            this.tab_movie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_movie)).EndInit();
            this.tab_rental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_rental)).EndInit();
            this.customer_panel.ResumeLayout(false);
            this.customer_panel.PerformLayout();
            this.rental_panel.ResumeLayout(false);
            this.rental_panel.PerformLayout();
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Movie_Rental;
        private System.Windows.Forms.TabPage tab_customer;
        private System.Windows.Forms.TabPage tab_movie;
        private System.Windows.Forms.TabPage tab_rental;
        private System.Windows.Forms.DataGridView DGV_rental;
        private System.Windows.Forms.DataGridView DGV_customer;
        private System.Windows.Forms.DataGridView DGV_movie;
        private System.Windows.Forms.Panel customer_panel;
        private System.Windows.Forms.Label label_customer_details;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label moile_number;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label F_Name;
        private System.Windows.Forms.TextBox Address_no;
        private System.Windows.Forms.TextBox Mobile_Number;
        private System.Windows.Forms.TextBox Last_Name;
        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel rental_panel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_rental_details;
        private System.Windows.Forms.Button btn_update_rental;
        private System.Windows.Forms.Button btn_Delete_rental;
        private System.Windows.Forms.Button btn_Add_rental;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker btn_dateTimePicker2;
        private System.Windows.Forms.DateTimePicker btn_dateTimePicker;
        private DataGridViewCellEventHandler DGV_customer_CellContentClick;
        private Label label_movie_details;
        private Label label_movie_name;
        private Label Rating_Rating;
        private Label Title_Title;
        private Label label_year;
        private Label label_copies;
        private Label label_plot;
        private Label label_genre;
        private TextBox text_rating;
        private TextBox text_title;
        private TextBox text_year;
        private TextBox text_copies;
        private TextBox text_plot;
        private TextBox text_genre;
        private Button btn_add_movie;
        private Button btn_delete_movie;
        private Button btn_update_movie;
        private Label label_rental_cost;
        private TextBox text_rental_cost;
        private Panel movie_panel;
    }
}

