namespace WindowsForms
{
    partial class Form6
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
            this.btn_shippers = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_shippers
            // 
            this.btn_shippers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_shippers.Location = new System.Drawing.Point(46, 41);
            this.btn_shippers.Name = "btn_shippers";
            this.btn_shippers.Size = new System.Drawing.Size(136, 50);
            this.btn_shippers.TabIndex = 0;
            this.btn_shippers.Text = "Shippers";
            this.btn_shippers.UseVisualStyleBackColor = true;
            this.btn_shippers.Click += new System.EventHandler(this.btn_shippers_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_customers.Location = new System.Drawing.Point(204, 41);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(136, 50);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "Customers";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_employees.Location = new System.Drawing.Point(46, 111);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(136, 50);
            this.btn_employees.TabIndex = 2;
            this.btn_employees.Text = "Employees";
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_orders.Location = new System.Drawing.Point(204, 111);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(136, 50);
            this.btn_orders.TabIndex = 3;
            this.btn_orders.Text = "Orders";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 209);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.btn_employees);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_shippers);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_shippers;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_orders;
    }
}