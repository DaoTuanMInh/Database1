namespace Badminton_Racket_Shop
{
    partial class StaffForm
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
            this.btCus = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btHis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCus
            // 
            this.btCus.Location = new System.Drawing.Point(58, 122);
            this.btCus.Name = "btCus";
            this.btCus.Size = new System.Drawing.Size(146, 68);
            this.btCus.TabIndex = 0;
            this.btCus.Text = "Manader Customer";
            this.btCus.UseVisualStyleBackColor = true;
            this.btCus.UseWaitCursor = true;
            this.btCus.Click += new System.EventHandler(this.btCus_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(377, 257);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 38);
            this.btExit.TabIndex = 29;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.UseWaitCursor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // btHis
            // 
            this.btHis.Location = new System.Drawing.Point(256, 122);
            this.btHis.Name = "btHis";
            this.btHis.Size = new System.Drawing.Size(146, 68);
            this.btHis.TabIndex = 30;
            this.btHis.Text = "Customer History";
            this.btHis.UseVisualStyleBackColor = true;
            this.btHis.UseWaitCursor = true;
            this.btHis.Click += new System.EventHandler(this.btHis_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Badminton_Racket_Shop.Properties.Resources.mu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 303);
            this.Controls.Add(this.btHis);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCus);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCus;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btHis;
    }
}