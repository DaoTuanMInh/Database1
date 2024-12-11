namespace Badminton_Racket_Shop
{
    partial class ImportMN
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
            this.MNwarehouse = new System.Windows.Forms.GroupBox();
            this.Information = new System.Windows.Forms.GroupBox();
            this.tbEID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbQI = new System.Windows.Forms.TextBox();
            this.lbPI = new System.Windows.Forms.Label();
            this.tbItemid = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tableWareHouse = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.MNwarehouse.SuspendLayout();
            this.Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableWareHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // MNwarehouse
            // 
            this.MNwarehouse.BackColor = System.Drawing.Color.Transparent;
            this.MNwarehouse.Controls.Add(this.Information);
            this.MNwarehouse.Controls.Add(this.tableWareHouse);
            this.MNwarehouse.Controls.Add(this.tbSearch);
            this.MNwarehouse.Location = new System.Drawing.Point(3, 28);
            this.MNwarehouse.Name = "MNwarehouse";
            this.MNwarehouse.Size = new System.Drawing.Size(1116, 453);
            this.MNwarehouse.TabIndex = 27;
            this.MNwarehouse.TabStop = false;
            this.MNwarehouse.Text = "Manage Import";
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Information.Controls.Add(this.tbEID);
            this.Information.Controls.Add(this.label3);
            this.Information.Controls.Add(this.tbdate);
            this.Information.Controls.Add(this.label2);
            this.Information.Controls.Add(this.btExit);
            this.Information.Controls.Add(this.tbCost);
            this.Information.Controls.Add(this.tbQI);
            this.Information.Controls.Add(this.lbPI);
            this.Information.Controls.Add(this.tbItemid);
            this.Information.Controls.Add(this.lbPrice);
            this.Information.Controls.Add(this.lbName);
            this.Information.Controls.Add(this.btUpdate);
            this.Information.Controls.Add(this.btDelete);
            this.Information.Controls.Add(this.btAdd);
            this.Information.Location = new System.Drawing.Point(563, 89);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(541, 348);
            this.Information.TabIndex = 25;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // tbEID
            // 
            this.tbEID.Location = new System.Drawing.Point(210, 137);
            this.tbEID.Name = "tbEID";
            this.tbEID.Size = new System.Drawing.Size(193, 22);
            this.tbEID.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "EmployeeID :";
            // 
            // tbdate
            // 
            this.tbdate.Location = new System.Drawing.Point(210, 90);
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(193, 22);
            this.tbdate.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Import Date:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(432, 298);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 39);
            this.btExit.TabIndex = 28;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(210, 245);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(193, 22);
            this.tbCost.TabIndex = 66;
            // 
            // tbQI
            // 
            this.tbQI.Location = new System.Drawing.Point(210, 193);
            this.tbQI.Name = "tbQI";
            this.tbQI.Size = new System.Drawing.Size(193, 22);
            this.tbQI.TabIndex = 63;
            // 
            // lbPI
            // 
            this.lbPI.AutoSize = true;
            this.lbPI.BackColor = System.Drawing.Color.Transparent;
            this.lbPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPI.Location = new System.Drawing.Point(19, 193);
            this.lbPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPI.Name = "lbPI";
            this.lbPI.Size = new System.Drawing.Size(172, 25);
            this.lbPI.TabIndex = 61;
            this.lbPI.Text = "QuantityImported :";
            // 
            // tbItemid
            // 
            this.tbItemid.Location = new System.Drawing.Point(210, 34);
            this.tbItemid.Name = "tbItemid";
            this.tbItemid.Size = new System.Drawing.Size(193, 22);
            this.tbItemid.TabIndex = 52;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.Location = new System.Drawing.Point(49, 242);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(109, 24);
            this.lbPrice.TabIndex = 51;
            this.lbPrice.Text = "ImportCost :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(48, 34);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 25);
            this.lbName.TabIndex = 48;
            this.lbName.Text = "ItemID :";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(432, 90);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 39);
            this.btUpdate.TabIndex = 19;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(432, 153);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 39);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(432, 30);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 39);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tableWareHouse
            // 
            this.tableWareHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableWareHouse.Location = new System.Drawing.Point(9, 81);
            this.tableWareHouse.Name = "tableWareHouse";
            this.tableWareHouse.RowHeadersWidth = 51;
            this.tableWareHouse.RowTemplate.Height = 24;
            this.tableWareHouse.Size = new System.Drawing.Size(548, 362);
            this.tableWareHouse.TabIndex = 24;
            this.tableWareHouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableWareHouse_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSearch.Location = new System.Drawing.Point(9, 34);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(279, 41);
            this.tbSearch.TabIndex = 19;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // ImportMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Badminton_Racket_Shop.Properties.Resources.mu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 484);
            this.Controls.Add(this.MNwarehouse);
            this.Name = "ImportMN";
            this.Text = "ImportMN";
            this.Load += new System.EventHandler(this.ImportMN_Load);
            this.MNwarehouse.ResumeLayout(false);
            this.MNwarehouse.PerformLayout();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableWareHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MNwarehouse;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbQI;
        private System.Windows.Forms.Label lbPI;
        private System.Windows.Forms.TextBox tbItemid;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView tableWareHouse;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEID;
    }
}