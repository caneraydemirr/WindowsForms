namespace WindowsForms
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_compname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_contitle = new System.Windows.Forms.TextBox();
            this.tb_contactname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_postalCode = new System.Windows.Forms.TextBox();
            this.tb_region = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_fax = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_deleted = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(13, 22);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(120, 20);
            this.tb_search.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(139, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 30);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1132, 358);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 30);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(1093, 60);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(120, 20);
            this.tb_ID.TabIndex = 4;
            // 
            // tb_compname
            // 
            this.tb_compname.Location = new System.Drawing.Point(1093, 86);
            this.tb_compname.Name = "tb_compname";
            this.tb_compname.Size = new System.Drawing.Size(120, 20);
            this.tb_compname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1014, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CustomerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1014, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CompanyName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1014, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ContactTitle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1014, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ContactName";
            // 
            // tb_contitle
            // 
            this.tb_contitle.Location = new System.Drawing.Point(1093, 138);
            this.tb_contitle.Name = "tb_contitle";
            this.tb_contitle.Size = new System.Drawing.Size(120, 20);
            this.tb_contitle.TabIndex = 9;
            // 
            // tb_contactname
            // 
            this.tb_contactname.Location = new System.Drawing.Point(1093, 112);
            this.tb_contactname.Name = "tb_contactname";
            this.tb_contactname.Size = new System.Drawing.Size(120, 20);
            this.tb_contactname.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1014, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1014, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address";
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(1093, 190);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(120, 20);
            this.tb_city.TabIndex = 13;
            // 
            // tb_adress
            // 
            this.tb_adress.Location = new System.Drawing.Point(1093, 164);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(120, 20);
            this.tb_adress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1014, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "PostalCode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1014, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Region";
            // 
            // tb_postalCode
            // 
            this.tb_postalCode.Location = new System.Drawing.Point(1093, 242);
            this.tb_postalCode.Name = "tb_postalCode";
            this.tb_postalCode.Size = new System.Drawing.Size(120, 20);
            this.tb_postalCode.TabIndex = 17;
            // 
            // tb_region
            // 
            this.tb_region.Location = new System.Drawing.Point(1093, 216);
            this.tb_region.Name = "tb_region";
            this.tb_region.Size = new System.Drawing.Size(120, 20);
            this.tb_region.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1014, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1014, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Country";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(1093, 294);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(120, 20);
            this.tb_phone.TabIndex = 21;
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(1093, 268);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(120, 20);
            this.tb_country.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1014, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fax";
            // 
            // tb_fax
            // 
            this.tb_fax.Location = new System.Drawing.Point(1093, 320);
            this.tb_fax.Name = "tb_fax";
            this.tb_fax.Size = new System.Drawing.Size(120, 20);
            this.tb_fax.TabIndex = 25;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1017, 358);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(81, 30);
            this.btn_update.TabIndex = 28;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Crimson;
            this.btn_delete.Location = new System.Drawing.Point(881, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 30);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_deleted
            // 
            this.tb_deleted.Enabled = false;
            this.tb_deleted.Location = new System.Drawing.Point(755, 18);
            this.tb_deleted.Name = "tb_deleted";
            this.tb_deleted.Size = new System.Drawing.Size(120, 20);
            this.tb_deleted.TabIndex = 30;
            // 
            // btn_exit
            // 
            this.btn_exit.ForeColor = System.Drawing.Color.Crimson;
            this.btn_exit.Location = new System.Drawing.Point(1158, 8);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 30);
            this.btn_exit.TabIndex = 115;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 404);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tb_deleted);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_fax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_postalCode);
            this.Controls.Add(this.tb_region);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.tb_adress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_contitle);
            this.Controls.Add(this.tb_contactname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_compname);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_compname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_contitle;
        private System.Windows.Forms.TextBox tb_contactname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_postalCode;
        private System.Windows.Forms.TextBox tb_region;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_country;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_fax;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_deleted;
        private System.Windows.Forms.Button btn_exit;
    }
}