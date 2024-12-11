namespace Badminton_Racket_Shop
{
    partial class PassChange
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
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lbcomfi = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.btChange = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Location = new System.Drawing.Point(221, 141);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.Size = new System.Drawing.Size(193, 22);
            this.tbConfirmPass.TabIndex = 55;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(221, 92);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(193, 22);
            this.tbNewPass.TabIndex = 54;
            // 
            // lbcomfi
            // 
            this.lbcomfi.AutoSize = true;
            this.lbcomfi.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbcomfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbcomfi.Location = new System.Drawing.Point(21, 138);
            this.lbcomfi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcomfi.Name = "lbcomfi";
            this.lbcomfi.Size = new System.Drawing.Size(182, 25);
            this.lbcomfi.TabIndex = 51;
            this.lbcomfi.Text = "Confirm Password :";
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNewPass.Location = new System.Drawing.Point(52, 92);
            this.lbNewPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(151, 25);
            this.lbNewPass.TabIndex = 50;
            this.lbNewPass.Text = "New password :";
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(108, 205);
            this.btChange.Margin = new System.Windows.Forms.Padding(4);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(117, 46);
            this.btChange.TabIndex = 48;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.UseWaitCursor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(288, 205);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(108, 46);
            this.btClear.TabIndex = 56;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Badminton_Racket_Shop.Properties.Resources.mu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 308);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbConfirmPass);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.lbcomfi);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.btChange);
            this.Name = "PassChange";
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbConfirmPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lbcomfi;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btClear;
    }
}