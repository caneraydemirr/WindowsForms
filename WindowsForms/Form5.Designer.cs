namespace WindowsForms
{
    partial class Form5
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
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_shipCountry = new System.Windows.Forms.TextBox();
            this.tb_shipPostalCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_shipRegion = new System.Windows.Forms.TextBox();
            this.tb_shipCity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_shipAddress = new System.Windows.Forms.TextBox();
            this.tb_deleted = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_shipName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_freight = new System.Windows.Forms.TextBox();
            this.tb_shipVia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_shipDate = new System.Windows.Forms.TextBox();
            this.tb_reqDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_orderDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_customer = new System.Windows.Forms.ComboBox();
            this.cb_employee = new System.Windows.Forms.ComboBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(981, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 110;
            this.label13.Text = "ShipCountry";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(981, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 109;
            this.label14.Text = "ShipPostalCode";
            // 
            // tb_shipCountry
            // 
            this.tb_shipCountry.Location = new System.Drawing.Point(1065, 391);
            this.tb_shipCountry.Name = "tb_shipCountry";
            this.tb_shipCountry.Size = new System.Drawing.Size(120, 20);
            this.tb_shipCountry.TabIndex = 108;
            // 
            // tb_shipPostalCode
            // 
            this.tb_shipPostalCode.Location = new System.Drawing.Point(1065, 365);
            this.tb_shipPostalCode.Name = "tb_shipPostalCode";
            this.tb_shipPostalCode.Size = new System.Drawing.Size(120, 20);
            this.tb_shipPostalCode.TabIndex = 107;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(981, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 106;
            this.label15.Text = "ShipRegion";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(981, 316);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 105;
            this.label16.Text = "ShipCity";
            // 
            // tb_shipRegion
            // 
            this.tb_shipRegion.Location = new System.Drawing.Point(1065, 339);
            this.tb_shipRegion.Name = "tb_shipRegion";
            this.tb_shipRegion.Size = new System.Drawing.Size(120, 20);
            this.tb_shipRegion.TabIndex = 104;
            // 
            // tb_shipCity
            // 
            this.tb_shipCity.Location = new System.Drawing.Point(1065, 313);
            this.tb_shipCity.Name = "tb_shipCity";
            this.tb_shipCity.Size = new System.Drawing.Size(120, 20);
            this.tb_shipCity.TabIndex = 103;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(981, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 102;
            this.label17.Text = "ShipAddress";
            // 
            // tb_shipAddress
            // 
            this.tb_shipAddress.Location = new System.Drawing.Point(1065, 287);
            this.tb_shipAddress.Name = "tb_shipAddress";
            this.tb_shipAddress.Size = new System.Drawing.Size(120, 20);
            this.tb_shipAddress.TabIndex = 101;
            // 
            // tb_deleted
            // 
            this.tb_deleted.Enabled = false;
            this.tb_deleted.Location = new System.Drawing.Point(755, 11);
            this.tb_deleted.Name = "tb_deleted";
            this.tb_deleted.Size = new System.Drawing.Size(120, 20);
            this.tb_deleted.TabIndex = 100;
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Crimson;
            this.btn_delete.Location = new System.Drawing.Point(881, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 30);
            this.btn_delete.TabIndex = 99;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(982, 422);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(81, 30);
            this.btn_update.TabIndex = 98;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(981, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "ShipName";
            // 
            // tb_shipName
            // 
            this.tb_shipName.Location = new System.Drawing.Point(1065, 261);
            this.tb_shipName.Name = "tb_shipName";
            this.tb_shipName.Size = new System.Drawing.Size(120, 20);
            this.tb_shipName.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(981, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Freight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(981, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "ShipVia";
            // 
            // tb_freight
            // 
            this.tb_freight.Location = new System.Drawing.Point(1065, 235);
            this.tb_freight.Name = "tb_freight";
            this.tb_freight.Size = new System.Drawing.Size(120, 20);
            this.tb_freight.TabIndex = 93;
            // 
            // tb_shipVia
            // 
            this.tb_shipVia.Location = new System.Drawing.Point(1065, 209);
            this.tb_shipVia.Name = "tb_shipVia";
            this.tb_shipVia.Size = new System.Drawing.Size(120, 20);
            this.tb_shipVia.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(981, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "ShippedDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(981, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "RequiredDate";
            // 
            // tb_shipDate
            // 
            this.tb_shipDate.Location = new System.Drawing.Point(1065, 183);
            this.tb_shipDate.Name = "tb_shipDate";
            this.tb_shipDate.Size = new System.Drawing.Size(120, 20);
            this.tb_shipDate.TabIndex = 89;
            // 
            // tb_reqDate
            // 
            this.tb_reqDate.Location = new System.Drawing.Point(1065, 157);
            this.tb_reqDate.Name = "tb_reqDate";
            this.tb_reqDate.Size = new System.Drawing.Size(120, 20);
            this.tb_reqDate.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(981, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "OrderDate";
            // 
            // tb_orderDate
            // 
            this.tb_orderDate.Location = new System.Drawing.Point(1065, 131);
            this.tb_orderDate.Name = "tb_orderDate";
            this.tb_orderDate.Size = new System.Drawing.Size(120, 20);
            this.tb_orderDate.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(981, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "EmployeeID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(981, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "CustomerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(981, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "OrderID";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(1065, 53);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(120, 20);
            this.tb_ID.TabIndex = 76;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1103, 422);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 30);
            this.btn_save.TabIndex = 75;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(139, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 30);
            this.btn_search.TabIndex = 74;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(13, 15);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(120, 20);
            this.tb_search.TabIndex = 73;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 411);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cb_customer
            // 
            this.cb_customer.FormattingEnabled = true;
            this.cb_customer.Location = new System.Drawing.Point(1064, 79);
            this.cb_customer.Name = "cb_customer";
            this.cb_customer.Size = new System.Drawing.Size(121, 21);
            this.cb_customer.TabIndex = 111;
            // 
            // cb_employee
            // 
            this.cb_employee.FormattingEnabled = true;
            this.cb_employee.Location = new System.Drawing.Point(1064, 106);
            this.cb_employee.Name = "cb_employee";
            this.cb_employee.Size = new System.Drawing.Size(121, 21);
            this.cb_employee.TabIndex = 112;
            // 
            // btn_exit
            // 
            this.btn_exit.ForeColor = System.Drawing.Color.Crimson;
            this.btn_exit.Location = new System.Drawing.Point(1108, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 30);
            this.btn_exit.TabIndex = 113;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 473);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.cb_employee);
            this.Controls.Add(this.cb_customer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_shipCountry);
            this.Controls.Add(this.tb_shipPostalCode);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_shipRegion);
            this.Controls.Add(this.tb_shipCity);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_shipAddress);
            this.Controls.Add(this.tb_deleted);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_shipName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_freight);
            this.Controls.Add(this.tb_shipVia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_shipDate);
            this.Controls.Add(this.tb_reqDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_orderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_shipCountry;
        private System.Windows.Forms.TextBox tb_shipPostalCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_shipRegion;
        private System.Windows.Forms.TextBox tb_shipCity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_shipAddress;
        private System.Windows.Forms.TextBox tb_deleted;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_shipName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_freight;
        private System.Windows.Forms.TextBox tb_shipVia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_shipDate;
        private System.Windows.Forms.TextBox tb_reqDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_orderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_customer;
        private System.Windows.Forms.ComboBox cb_employee;
        private System.Windows.Forms.Button btn_exit;
    }
}