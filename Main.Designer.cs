namespace Q_ERP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btorder = new System.Windows.Forms.Button();
            this.btmanage = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btorder
            // 
            this.btorder.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.btorder, "btorder");
            this.btorder.Name = "btorder";
            this.btorder.UseVisualStyleBackColor = false;
            this.btorder.Click += new System.EventHandler(this.btorder_Click);
            // 
            // btmanage
            // 
            this.btmanage.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.btmanage, "btmanage");
            this.btmanage.Name = "btmanage";
            this.btmanage.UseVisualStyleBackColor = false;
            this.btmanage.Click += new System.EventHandler(this.btmanage_Click);
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.btexit, "btexit");
            this.btexit.Name = "btexit";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.btexit);
            this.panel1.Controls.Add(this.btmanage);
            this.panel1.Controls.Add(this.btorder);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btorder;
        private System.Windows.Forms.Button btmanage;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Panel panel1;
    }
}