namespace Badminton_Racket_Shop
{
    partial class AD
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
            this.btMNstaff = new System.Windows.Forms.Button();
            this.btMNCustomer = new System.Windows.Forms.Button();
            this.btMNWareHouse = new System.Windows.Forms.Button();
            this.AdminFe = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btMNimport = new System.Windows.Forms.Button();
            this.AdminFe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMNstaff
            // 
            this.btMNstaff.Location = new System.Drawing.Point(18, 68);
            this.btMNstaff.Name = "btMNstaff";
            this.btMNstaff.Size = new System.Drawing.Size(183, 39);
            this.btMNstaff.TabIndex = 0;
            this.btMNstaff.Text = "Manage Staff";
            this.btMNstaff.UseVisualStyleBackColor = true;
            this.btMNstaff.Click += new System.EventHandler(this.btMNstaff_Click);
            // 
            // btMNCustomer
            // 
            this.btMNCustomer.Location = new System.Drawing.Point(249, 68);
            this.btMNCustomer.Name = "btMNCustomer";
            this.btMNCustomer.Size = new System.Drawing.Size(183, 39);
            this.btMNCustomer.TabIndex = 1;
            this.btMNCustomer.Text = "Manage Customer";
            this.btMNCustomer.UseVisualStyleBackColor = true;
            this.btMNCustomer.Click += new System.EventHandler(this.btMNCustomer_Click);
            // 
            // btMNWareHouse
            // 
            this.btMNWareHouse.Location = new System.Drawing.Point(18, 141);
            this.btMNWareHouse.Name = "btMNWareHouse";
            this.btMNWareHouse.Size = new System.Drawing.Size(183, 39);
            this.btMNWareHouse.TabIndex = 2;
            this.btMNWareHouse.Text = "Manage WareHouse";
            this.btMNWareHouse.UseVisualStyleBackColor = true;
            this.btMNWareHouse.Click += new System.EventHandler(this.btMNWareHouse_Click);
            // 
            // AdminFe
            // 
            this.AdminFe.BackColor = System.Drawing.Color.Transparent;
            this.AdminFe.Controls.Add(this.btExit);
            this.AdminFe.Controls.Add(this.btMNimport);
            this.AdminFe.Controls.Add(this.btMNWareHouse);
            this.AdminFe.Controls.Add(this.btMNCustomer);
            this.AdminFe.Controls.Add(this.btMNstaff);
            this.AdminFe.Location = new System.Drawing.Point(12, 12);
            this.AdminFe.Name = "AdminFe";
            this.AdminFe.Size = new System.Drawing.Size(448, 284);
            this.AdminFe.TabIndex = 4;
            this.AdminFe.TabStop = false;
            this.AdminFe.Text = "Admin feature";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(338, 227);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 38);
            this.btExit.TabIndex = 28;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btMNimport
            // 
            this.btMNimport.Location = new System.Drawing.Point(249, 141);
            this.btMNimport.Name = "btMNimport";
            this.btMNimport.Size = new System.Drawing.Size(183, 39);
            this.btMNimport.TabIndex = 4;
            this.btMNimport.Text = "Manager History";
            this.btMNimport.UseVisualStyleBackColor = true;
            this.btMNimport.Click += new System.EventHandler(this.btMNimport_Click);
            // 
            // AD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Badminton_Racket_Shop.Properties.Resources.mu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 308);
            this.Controls.Add(this.AdminFe);
            this.Name = "AD";
            this.Text = "Admin";
            this.AdminFe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMNstaff;
        private System.Windows.Forms.Button btMNCustomer;
        private System.Windows.Forms.Button btMNWareHouse;
        private System.Windows.Forms.GroupBox AdminFe;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btMNimport;
    }
}