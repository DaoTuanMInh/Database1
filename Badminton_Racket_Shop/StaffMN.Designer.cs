namespace Badminton_Racket_Shop
{
    partial class StaffMN
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
            this.tableStaff = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.grStaff = new System.Windows.Forms.GroupBox();
            this.Information = new System.Windows.Forms.GroupBox();
            this.Birth = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.lbPosition = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.GroupBox();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbBirth = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableStaff)).BeginInit();
            this.grStaff.SuspendLayout();
            this.Information.SuspendLayout();
            this.gr.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableStaff
            // 
            this.tableStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableStaff.Location = new System.Drawing.Point(6, 96);
            this.tableStaff.Name = "tableStaff";
            this.tableStaff.RowHeadersWidth = 51;
            this.tableStaff.RowTemplate.Height = 24;
            this.tableStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableStaff.Size = new System.Drawing.Size(655, 370);
            this.tableStaff.TabIndex = 18;
            this.tableStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableStaff_CellContentClick);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(412, 351);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 39);
            this.btExit.TabIndex = 17;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(412, 181);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 39);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(412, 36);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 39);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSearch.Location = new System.Drawing.Point(15, 51);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(238, 41);
            this.tbSearch.TabIndex = 13;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(412, 106);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 39);
            this.btUpdate.TabIndex = 19;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // grStaff
            // 
            this.grStaff.BackColor = System.Drawing.Color.Transparent;
            this.grStaff.Controls.Add(this.Information);
            this.grStaff.Controls.Add(this.tableStaff);
            this.grStaff.Controls.Add(this.tbSearch);
            this.grStaff.Location = new System.Drawing.Point(12, 31);
            this.grStaff.Name = "grStaff";
            this.grStaff.Size = new System.Drawing.Size(1185, 471);
            this.grStaff.TabIndex = 20;
            this.grStaff.TabStop = false;
            this.grStaff.Text = "Manager Staff";
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Information.Controls.Add(this.Birth);
            this.Information.Controls.Add(this.tbPosition);
            this.Information.Controls.Add(this.lbPosition);
            this.Information.Controls.Add(this.gr);
            this.Information.Controls.Add(this.btExit);
            this.Information.Controls.Add(this.lbBirth);
            this.Information.Controls.Add(this.tbPhone);
            this.Information.Controls.Add(this.lbPhone);
            this.Information.Controls.Add(this.tbCode);
            this.Information.Controls.Add(this.lbCode);
            this.Information.Controls.Add(this.cbRole);
            this.Information.Controls.Add(this.tbName);
            this.Information.Controls.Add(this.lbRole);
            this.Information.Controls.Add(this.lbName);
            this.Information.Controls.Add(this.btUpdate);
            this.Information.Controls.Add(this.btDelete);
            this.Information.Controls.Add(this.btAdd);
            this.Information.Location = new System.Drawing.Point(667, 64);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(515, 404);
            this.Information.TabIndex = 21;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(138, 244);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(193, 22);
            this.Birth.TabIndex = 68;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(138, 127);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(193, 22);
            this.tbPosition.TabIndex = 67;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.BackColor = System.Drawing.Color.Transparent;
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPosition.Location = new System.Drawing.Point(21, 124);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(81, 24);
            this.lbPosition.TabIndex = 66;
            this.lbPosition.Text = "Position:";
            // 
            // gr
            // 
            this.gr.Controls.Add(this.tbCName);
            this.gr.Controls.Add(this.label1);
            this.gr.Controls.Add(this.lbPass);
            this.gr.Controls.Add(this.tbPass);
            this.gr.Location = new System.Drawing.Point(14, 294);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(354, 96);
            this.gr.TabIndex = 65;
            this.gr.TabStop = false;
            this.gr.Text = "Change login";
            // 
            // tbCName
            // 
            this.tbCName.Location = new System.Drawing.Point(120, 17);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(193, 22);
            this.tbCName.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Name :";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPass.Location = new System.Drawing.Point(6, 56);
            this.lbPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(109, 25);
            this.lbPass.TabIndex = 49;
            this.lbPass.Text = "Password :";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(120, 59);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(193, 22);
            this.tbPass.TabIndex = 53;
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.BackColor = System.Drawing.Color.Transparent;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBirth.Location = new System.Drawing.Point(24, 240);
            this.lbBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(62, 25);
            this.lbBirth.TabIndex = 62;
            this.lbBirth.Text = "Birth :";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(138, 195);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(193, 22);
            this.tbPhone.TabIndex = 60;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhone.Location = new System.Drawing.Point(13, 195);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(80, 25);
            this.lbPhone.TabIndex = 59;
            this.lbPhone.Text = "Phone :";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(138, 36);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(193, 22);
            this.tbCode.TabIndex = 56;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.BackColor = System.Drawing.Color.Transparent;
            this.lbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCode.Location = new System.Drawing.Point(22, 36);
            this.lbCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(106, 25);
            this.lbCode.TabIndex = 55;
            this.lbCode.Text = "StaffCode:";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(141, 161);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(146, 24);
            this.cbRole.TabIndex = 54;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(138, 80);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 22);
            this.tbName.TabIndex = 52;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRole.Location = new System.Drawing.Point(25, 161);
            this.lbRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(59, 24);
            this.lbRole.TabIndex = 51;
            this.lbRole.Text = "Role :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(22, 77);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(111, 25);
            this.lbName.TabIndex = 48;
            this.lbName.Text = "Full Name :";
            // 
            // StaffMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Badminton_Racket_Shop.Properties.Resources.mu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 504);
            this.Controls.Add(this.grStaff);
            this.Name = "StaffMN";
            this.ShowIcon = false;
            this.Text = "StaffMN";
            this.Load += new System.EventHandler(this.StaffMN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableStaff)).EndInit();
            this.grStaff.ResumeLayout(false);
            this.grStaff.PerformLayout();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.gr.ResumeLayout(false);
            this.gr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableStaff;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.GroupBox grStaff;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.TextBox Birth;
    }
}