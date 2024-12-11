namespace Badminton_Racket_Shop
{
    partial class Warehouse_Form
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
            this.btWare = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btWare
            // 
            this.btWare.Location = new System.Drawing.Point(177, 129);
            this.btWare.Name = "btWare";
            this.btWare.Size = new System.Drawing.Size(146, 68);
            this.btWare.TabIndex = 1;
            this.btWare.Text = "Manader WareHouse";
            this.btWare.UseVisualStyleBackColor = true;
            this.btWare.UseWaitCursor = true;
            this.btWare.Click += new System.EventHandler(this.btWare_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(394, 276);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 38);
            this.btExit.TabIndex = 30;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.UseWaitCursor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Warehouse_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Badminton_Racket_Shop.Properties.Resources.mu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 326);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btWare);
            this.Name = "Warehouse_Form";
            this.Text = "Warehouse_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btWare;
        private System.Windows.Forms.Button btExit;
    }
}