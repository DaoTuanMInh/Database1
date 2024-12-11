namespace Badminton_Racket_Shop
{
    partial class WarehouseMN
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
            this.tableWareHouse = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.Information = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btExit = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbBirth = new System.Windows.Forms.Label();
            this.tbPQ = new System.Windows.Forms.TextBox();
            this.lbIQ = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.MNwarehouse = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableWareHouse)).BeginInit();
            this.Information.SuspendLayout();
            this.MNwarehouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableWareHouse
            // 
            this.tableWareHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableWareHouse.Location = new System.Drawing.Point(9, 85);
            this.tableWareHouse.Name = "tableWareHouse";
            this.tableWareHouse.RowHeadersWidth = 51;
            this.tableWareHouse.RowTemplate.Height = 24;
            this.tableWareHouse.Size = new System.Drawing.Size(629, 362);
            this.tableWareHouse.TabIndex = 24;
            this.tableWareHouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableWareHouse_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSearch.Location = new System.Drawing.Point(9, 38);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(279, 41);
            this.tbSearch.TabIndex = 19;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged_1);
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Information.Controls.Add(this.cbCategory);
            this.Information.Controls.Add(this.btExit);
            this.Information.Controls.Add(this.tbPrice);
            this.Information.Controls.Add(this.lbBirth);
            this.Information.Controls.Add(this.tbPQ);
            this.Information.Controls.Add(this.lbIQ);
            this.Information.Controls.Add(this.tbCode);
            this.Information.Controls.Add(this.lbCode);
            this.Information.Controls.Add(this.tbName);
            this.Information.Controls.Add(this.lbPrice);
            this.Information.Controls.Add(this.lbName);
            this.Information.Controls.Add(this.btUpdate);
            this.Information.Controls.Add(this.btDelete);
            this.Information.Controls.Add(this.btAdd);
            this.Information.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Information.Location = new System.Drawing.Point(644, 101);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(532, 346);
            this.Information.TabIndex = 25;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(211, 256);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(192, 24);
            this.cbCategory.TabIndex = 71;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(437, 297);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(80, 39);
            this.btExit.TabIndex = 27;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(211, 144);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(193, 22);
            this.tbPrice.TabIndex = 66;
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.BackColor = System.Drawing.Color.Transparent;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBirth.Location = new System.Drawing.Point(34, 256);
            this.lbBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(122, 25);
            this.lbBirth.TabIndex = 62;
            this.lbBirth.Text = "CategoryID :";
            // 
            // tbPQ
            // 
            this.tbPQ.Location = new System.Drawing.Point(211, 195);
            this.tbPQ.Name = "tbPQ";
            this.tbPQ.Size = new System.Drawing.Size(193, 22);
            this.tbPQ.TabIndex = 60;
            // 
            // lbIQ
            // 
            this.lbIQ.AutoSize = true;
            this.lbIQ.BackColor = System.Drawing.Color.Transparent;
            this.lbIQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIQ.Location = new System.Drawing.Point(7, 191);
            this.lbIQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIQ.Name = "lbIQ";
            this.lbIQ.Size = new System.Drawing.Size(181, 25);
            this.lbIQ.TabIndex = 59;
            this.lbIQ.Text = "Inventory Quantity :";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(211, 39);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(193, 22);
            this.tbCode.TabIndex = 56;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.BackColor = System.Drawing.Color.Transparent;
            this.lbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCode.Location = new System.Drawing.Point(34, 39);
            this.lbCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(108, 25);
            this.lbCode.TabIndex = 55;
            this.lbCode.Text = "ItemCode :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(211, 88);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 22);
            this.tbName.TabIndex = 52;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.Location = new System.Drawing.Point(57, 144);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(63, 24);
            this.lbPrice.TabIndex = 51;
            this.lbPrice.Text = "Price :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(34, 88);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(117, 25);
            this.lbName.TabIndex = 48;
            this.lbName.Text = "Item Name :";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(423, 106);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 39);
            this.btUpdate.TabIndex = 19;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(423, 187);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 39);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(423, 39);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 39);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // MNwarehouse
            // 
            this.MNwarehouse.BackColor = System.Drawing.Color.Transparent;
            this.MNwarehouse.Controls.Add(this.Information);
            this.MNwarehouse.Controls.Add(this.tableWareHouse);
            this.MNwarehouse.Controls.Add(this.tbSearch);
            this.MNwarehouse.Location = new System.Drawing.Point(3, 27);
            this.MNwarehouse.Name = "MNwarehouse";
            this.MNwarehouse.Size = new System.Drawing.Size(1182, 455);
            this.MNwarehouse.TabIndex = 26;
            this.MNwarehouse.TabStop = false;
            this.MNwarehouse.Text = "Manage WareHouse";
            // 
            // WarehouseMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Badminton_Racket_Shop.Properties.Resources.mu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 479);
            this.Controls.Add(this.MNwarehouse);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WarehouseMN";
            this.Text = "WarehouseMN";
            this.Load += new System.EventHandler(this.WareHouseMN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableWareHouse)).EndInit();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.MNwarehouse.ResumeLayout(false);
            this.MNwarehouse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableWareHouse;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.TextBox tbPQ;
        private System.Windows.Forms.Label lbIQ;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.GroupBox MNwarehouse;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}