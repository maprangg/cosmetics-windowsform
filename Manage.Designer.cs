namespace Q_ERP
{
    partial class Manage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.GridViewManage = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.qERPDataSet1 = new Q_ERP.QERPDataSet1();
            this.cosmeticsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cosmeticsTypeTableAdapter = new Q_ERP.QERPDataSet1TableAdapters.CosmeticsTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewManage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qERPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticsTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewManage
            // 
            this.GridViewManage.AllowUserToAddRows = false;
            this.GridViewManage.AllowUserToDeleteRows = false;
            this.GridViewManage.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridViewManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewManage.GridColor = System.Drawing.Color.Snow;
            this.GridViewManage.Location = new System.Drawing.Point(12, 189);
            this.GridViewManage.Name = "GridViewManage";
            this.GridViewManage.ReadOnly = true;
            this.GridViewManage.RowTemplate.Height = 28;
            this.GridViewManage.Size = new System.Drawing.Size(704, 203);
            this.GridViewManage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(213, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find by ID or Name";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(373, 12);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(231, 26);
            this.tbFind.TabIndex = 2;
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.Snow;
            this.btFind.Font = new System.Drawing.Font("TH SarabunPSK", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btFind.Location = new System.Drawing.Point(613, 9);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 33);
            this.btFind.TabIndex = 3;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(71, 82);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 26);
            this.tbID.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(71, 125);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 26);
            this.tbName.TabIndex = 7;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(254, 82);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(104, 26);
            this.tbQuantity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH SarabunPSK", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(368, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TH SarabunPSK", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(179, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TH SarabunPSK", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(203, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(254, 125);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(104, 26);
            this.tbPrice.TabIndex = 13;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Snow;
            this.btAdd.Font = new System.Drawing.Font("TH SarabunPSK", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btAdd.Location = new System.Drawing.Point(585, 78);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(103, 33);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Snow;
            this.btDelete.Font = new System.Drawing.Font("TH SarabunPSK", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btDelete.Location = new System.Drawing.Point(585, 125);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(103, 33);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // cbType
            // 
            this.cbType.DataSource = this.cosmeticsTypeBindingSource;
            this.cbType.DisplayMember = "Name";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(418, 83);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 28);
            this.cbType.TabIndex = 16;
            this.cbType.ValueMember = "TypeID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbQuantity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbFind);
            this.panel1.Controls.Add(this.btFind);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 171);
            this.panel1.TabIndex = 17;
            // 
            // qERPDataSet1
            // 
            this.qERPDataSet1.DataSetName = "QERPDataSet1";
            this.qERPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cosmeticsTypeBindingSource
            // 
            this.cosmeticsTypeBindingSource.DataMember = "CosmeticsType";
            this.cosmeticsTypeBindingSource.DataSource = this.qERPDataSet1;
            // 
            // cosmeticsTypeTableAdapter
            // 
            this.cosmeticsTypeTableAdapter.ClearBeforeFill = true;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 394);
            this.Controls.Add(this.GridViewManage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewManage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qERPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticsTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewManage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Panel panel1;
        private QERPDataSet1 qERPDataSet1;
        private System.Windows.Forms.BindingSource cosmeticsTypeBindingSource;
        private QERPDataSet1TableAdapters.CosmeticsTypeTableAdapter cosmeticsTypeTableAdapter;
    }
}