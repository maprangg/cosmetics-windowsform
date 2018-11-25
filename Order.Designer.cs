namespace Q_ERP
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.btAdd = new System.Windows.Forms.Button();
            this.btbill = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.lbamount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Snow;
            this.btAdd.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btAdd.Location = new System.Drawing.Point(547, 21);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(107, 40);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btbill
            // 
            this.btbill.BackColor = System.Drawing.Color.Snow;
            this.btbill.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btbill.Location = new System.Drawing.Point(547, 360);
            this.btbill.Name = "btbill";
            this.btbill.Size = new System.Drawing.Size(107, 46);
            this.btbill.TabIndex = 2;
            this.btbill.Text = "BILL";
            this.btbill.UseVisualStyleBackColor = false;
            this.btbill.Click += new System.EventHandler(this.btbill_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.LightSalmon;
            this.Total.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Total.Location = new System.Drawing.Point(25, 28);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(61, 37);
            this.Total.TabIndex = 3;
            this.Total.Text = "Total";
            // 
            // lbamount
            // 
            this.lbamount.AutoSize = true;
            this.lbamount.BackColor = System.Drawing.Color.LightSalmon;
            this.lbamount.Font = new System.Drawing.Font("TH SarabunPSK", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbamount.Location = new System.Drawing.Point(167, 28);
            this.lbamount.Name = "lbamount";
            this.lbamount.Size = new System.Drawing.Size(31, 43);
            this.lbamount.TabIndex = 4;
            this.lbamount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(330, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bath";
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.Snow;
            this.btsave.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btsave.Location = new System.Drawing.Point(547, 106);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(107, 43);
            this.btsave.TabIndex = 6;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.LightSalmon;
            this.lbname.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbname.Location = new System.Drawing.Point(42, 133);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(57, 33);
            this.lbname.TabIndex = 7;
            this.lbname.Text = "NAME";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.BackColor = System.Drawing.Color.LightSalmon;
            this.lbtype.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbtype.Location = new System.Drawing.Point(172, 133);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(50, 33);
            this.lbtype.TabIndex = 8;
            this.lbtype.Text = "TYPE";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.BackColor = System.Drawing.Color.LightSalmon;
            this.lbprice.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbprice.Location = new System.Drawing.Point(301, 133);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(55, 33);
            this.lbprice.TabIndex = 9;
            this.lbprice.Text = "PRICE";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("TH SarabunPSK", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.quantity.Location = new System.Drawing.Point(397, 107);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(74, 36);
            this.quantity.TabIndex = 10;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listView1.Location = new System.Drawing.Point(46, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(622, 170);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Snow;
            this.btBack.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btBack.Location = new System.Drawing.Point(434, 383);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(116, 46);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.btsave);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btbill);
            this.panel1.Controls.Add(this.lbamount);
            this.panel1.Location = new System.Drawing.Point(28, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 415);
            this.panel1.TabIndex = 13;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.lbtype);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btbill;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label lbamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel panel1;
    }
}