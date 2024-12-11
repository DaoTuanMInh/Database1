namespace Badminton_Racket_Shop
{
    partial class CustomerMN
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
            this.tableCustomer = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.Information = new System.Windows.Forms.GroupBox();
            this.tbBirth = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.grCus = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomer)).BeginInit();
            this.Information.SuspendLayout();
            this.grCus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableCustomer
            // 
            this.tableCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCustomer.Location = new System.Drawing.Point(9, 83);
            this.tableCustomer.Name = "tableCustomer";
            this.tableCustomer.RowHeadersWidth = 51;
            this.tableCustomer.RowTemplate.Height = 24;
            this.tableCustomer.Size = new System.Drawing.Size(659, 376);
            this.tableCustomer.TabIndex = 25;
            this.tableCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCustomer_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSearch.Location = new System.Drawing.Point(9, 37);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 41);
            this.tbSearch.TabIndex = 20;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Information.Controls.Add(this.tbBirth);
            this.Information.Controls.Add(this.btExit);
            this.Information.Controls.Add(this.tbAddress);
            this.Information.Controls.Add(this.lbBirth);
            this.Information.Controls.Add(this.lbAddress);
            this.Information.Controls.Add(this.tbPhone);
            this.Information.Controls.Add(this.lbPhone);
            this.Information.Controls.Add(this.tbCode);
            this.Information.Controls.Add(this.lbCode);
            this.Information.Controls.Add(this.tbName);
            this.Information.Controls.Add(this.lbName);
            this.Information.Controls.Add(this.btUpdate);
            this.Information.Controls.Add(this.btDelete);
            this.Information.Controls.Add(this.btAdd);
            this.Information.Location = new System.Drawing.Point(673, 73);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(517, 386);
            this.Information.TabIndex = 26;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // tbBirth
            // 
            this.tbBirth.Location = new System.Drawing.Point(161, 189);
            this.tbBirth.Name = "tbBirth";
            this.tbBirth.Size = new System.Drawing.Size(193, 22);
            this.tbBirth.TabIndex = 66;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(411, 338);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 39);
            this.btExit.TabIndex = 28;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(134, 245);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(255, 112);
            this.tbAddress.TabIndex = 63;
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.BackColor = System.Drawing.Color.Transparent;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBirth.Location = new System.Drawing.Point(71, 186);
            this.lbBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(62, 25);
            this.lbBirth.TabIndex = 62;
            this.lbBirth.Text = "Birth :";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAddress.Location = new System.Drawing.Point(31, 241);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(96, 25);
            this.lbAddress.TabIndex = 61;
            this.lbAddress.Text = "Address :";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(161, 134);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(193, 22);
            this.tbPhone.TabIndex = 60;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhone.Location = new System.Drawing.Point(53, 131);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(80, 25);
            this.lbPhone.TabIndex = 59;
            this.lbPhone.Text = "Phone :";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(161, 38);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(193, 22);
            this.tbCode.TabIndex = 56;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.BackColor = System.Drawing.Color.Transparent;
            this.lbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCode.Location = new System.Drawing.Point(7, 34);
            this.lbCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(156, 25);
            this.lbCode.TabIndex = 55;
            this.lbCode.Text = "Customer Code:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(161, 76);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 22);
            this.tbName.TabIndex = 52;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(31, 76);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(111, 25);
            this.lbName.TabIndex = 48;
            this.lbName.Text = "Full Name :";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(397, 101);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 39);
            this.btUpdate.TabIndex = 19;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(397, 172);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 39);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(397, 30);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 39);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grCus
            // 
            this.grCus.BackColor = System.Drawing.Color.Transparent;
            this.grCus.Controls.Add(this.tableCustomer);
            this.grCus.Controls.Add(this.Information);
            this.grCus.Controls.Add(this.tbSearch);
            this.grCus.Location = new System.Drawing.Point(3, 29);
            this.grCus.Name = "grCus";
            this.grCus.Size = new System.Drawing.Size(1193, 460);
            this.grCus.TabIndex = 27;
            this.grCus.TabStop = false;
            this.grCus.Text = "Manage Customer";
            // 
            // CustomerMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Badminton_Racket_Shop.Properties.Resources.mu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 497);
            this.Controls.Add(this.grCus);
            this.Name = "CustomerMN";
            this.Text = "CustomerMN";
            this.Load += new System.EventHandler(this.CustomerMN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomer)).EndInit();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.grCus.ResumeLayout(false);
            this.grCus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableCustomer;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox grCus;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbBirth;
    }
}