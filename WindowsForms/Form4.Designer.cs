namespace WindowsForms
{
    partial class Form4
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
            this.tb_deleted = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_postalCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_region = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_hDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_bDate = new System.Windows.Forms.TextBox();
            this.tb_toc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_fName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lName = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_photoPath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_reportsTo = new System.Windows.Forms.TextBox();
            this.tb_notes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_extension = new System.Windows.Forms.TextBox();
            this.tb_hPhone = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_deleted
            // 
            this.tb_deleted.Enabled = false;
            this.tb_deleted.Location = new System.Drawing.Point(755, 13);
            this.tb_deleted.Name = "tb_deleted";
            this.tb_deleted.Size = new System.Drawing.Size(120, 20);
            this.tb_deleted.TabIndex = 59;
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Crimson;
            this.btn_delete.Location = new System.Drawing.Point(881, 7);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 30);
            this.btn_delete.TabIndex = 58;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(984, 514);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(81, 30);
            this.btn_update.TabIndex = 57;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(981, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Postal Code";
            // 
            // tb_postalCode
            // 
            this.tb_postalCode.Location = new System.Drawing.Point(1060, 315);
            this.tb_postalCode.Name = "tb_postalCode";
            this.tb_postalCode.Size = new System.Drawing.Size(120, 20);
            this.tb_postalCode.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(981, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Region";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(981, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "City";
            // 
            // tb_region
            // 
            this.tb_region.Location = new System.Drawing.Point(1060, 289);
            this.tb_region.Name = "tb_region";
            this.tb_region.Size = new System.Drawing.Size(120, 20);
            this.tb_region.TabIndex = 52;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(1060, 263);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(120, 20);
            this.tb_city.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(981, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(981, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "HireDate";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(1060, 237);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(120, 20);
            this.tb_address.TabIndex = 48;
            // 
            // tb_hDate
            // 
            this.tb_hDate.Location = new System.Drawing.Point(1060, 211);
            this.tb_hDate.Name = "tb_hDate";
            this.tb_hDate.Size = new System.Drawing.Size(120, 20);
            this.tb_hDate.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(981, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "BirthDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(981, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "TitleOfCourtesy";
            // 
            // tb_bDate
            // 
            this.tb_bDate.Location = new System.Drawing.Point(1060, 185);
            this.tb_bDate.Name = "tb_bDate";
            this.tb_bDate.Size = new System.Drawing.Size(120, 20);
            this.tb_bDate.TabIndex = 44;
            // 
            // tb_toc
            // 
            this.tb_toc.Location = new System.Drawing.Point(1060, 159);
            this.tb_toc.Name = "tb_toc";
            this.tb_toc.Size = new System.Drawing.Size(120, 20);
            this.tb_toc.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(981, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(981, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "First Name";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(1060, 133);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(120, 20);
            this.tb_title.TabIndex = 40;
            // 
            // tb_fName
            // 
            this.tb_fName.Location = new System.Drawing.Point(1060, 107);
            this.tb_fName.Name = "tb_fName";
            this.tb_fName.Size = new System.Drawing.Size(120, 20);
            this.tb_fName.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(981, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(981, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "EmployeeID";
            // 
            // tb_lName
            // 
            this.tb_lName.Location = new System.Drawing.Point(1060, 81);
            this.tb_lName.Name = "tb_lName";
            this.tb_lName.Size = new System.Drawing.Size(120, 20);
            this.tb_lName.TabIndex = 36;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(1060, 55);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(120, 20);
            this.tb_ID.TabIndex = 35;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1099, 514);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 30);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(139, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 30);
            this.btn_search.TabIndex = 33;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(13, 17);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(120, 20);
            this.tb_search.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 501);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(981, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "PhotoPath";
            // 
            // tb_photoPath
            // 
            this.tb_photoPath.Location = new System.Drawing.Point(1060, 471);
            this.tb_photoPath.Name = "tb_photoPath";
            this.tb_photoPath.Size = new System.Drawing.Size(120, 20);
            this.tb_photoPath.TabIndex = 70;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(981, 448);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "ReportsTo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(981, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Notes";
            // 
            // tb_reportsTo
            // 
            this.tb_reportsTo.Location = new System.Drawing.Point(1060, 445);
            this.tb_reportsTo.Name = "tb_reportsTo";
            this.tb_reportsTo.Size = new System.Drawing.Size(120, 20);
            this.tb_reportsTo.TabIndex = 67;
            // 
            // tb_notes
            // 
            this.tb_notes.Location = new System.Drawing.Point(1060, 419);
            this.tb_notes.Name = "tb_notes";
            this.tb_notes.Size = new System.Drawing.Size(120, 20);
            this.tb_notes.TabIndex = 66;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(981, 396);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "Extension";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(981, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "HomePhone";
            // 
            // tb_extension
            // 
            this.tb_extension.Location = new System.Drawing.Point(1060, 393);
            this.tb_extension.Name = "tb_extension";
            this.tb_extension.Size = new System.Drawing.Size(120, 20);
            this.tb_extension.TabIndex = 63;
            // 
            // tb_hPhone
            // 
            this.tb_hPhone.Location = new System.Drawing.Point(1060, 367);
            this.tb_hPhone.Name = "tb_hPhone";
            this.tb_hPhone.Size = new System.Drawing.Size(120, 20);
            this.tb_hPhone.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(981, 344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "Country";
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(1060, 341);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(120, 20);
            this.tb_country.TabIndex = 60;
            // 
            // btn_exit
            // 
            this.btn_exit.ForeColor = System.Drawing.Color.Crimson;
            this.btn_exit.Location = new System.Drawing.Point(1118, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 30);
            this.btn_exit.TabIndex = 114;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 575);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_photoPath);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_reportsTo);
            this.Controls.Add(this.tb_notes);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_extension);
            this.Controls.Add(this.tb_hPhone);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.tb_deleted);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_postalCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_region);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_hDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_bDate);
            this.Controls.Add(this.tb_toc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.tb_fName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_lName);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_deleted;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_postalCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_region;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_hDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_bDate;
        private System.Windows.Forms.TextBox tb_toc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_fName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_lName;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_photoPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_reportsTo;
        private System.Windows.Forms.TextBox tb_notes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_extension;
        private System.Windows.Forms.TextBox tb_hPhone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_country;
        private System.Windows.Forms.Button btn_exit;
    }
}