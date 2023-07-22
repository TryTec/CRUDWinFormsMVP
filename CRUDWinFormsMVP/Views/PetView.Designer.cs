namespace CRUDWinFormsMVP.Views
{
    partial class PetView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPetList = new System.Windows.Forms.TabPage();
            this.DgvPet = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TabPetDetail = new System.Windows.Forms.TabPage();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPetColour = new System.Windows.Forms.TextBox();
            this.TxtPetType = new System.Windows.Forms.TextBox();
            this.TxtPetName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPetID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPet)).BeginInit();
            this.TabPetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PETS";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPetList);
            this.TabControl1.Controls.Add(this.TabPetDetail);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 45);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(884, 516);
            this.TabControl1.TabIndex = 1;
            // 
            // TabPetList
            // 
            this.TabPetList.Controls.Add(this.DgvPet);
            this.TabPetList.Controls.Add(this.BtnDelete);
            this.TabPetList.Controls.Add(this.BtnEdit);
            this.TabPetList.Controls.Add(this.BtnAddNew);
            this.TabPetList.Controls.Add(this.BtnSearch);
            this.TabPetList.Controls.Add(this.TxtSearch);
            this.TabPetList.Controls.Add(this.label2);
            this.TabPetList.Location = new System.Drawing.Point(4, 29);
            this.TabPetList.Name = "TabPetList";
            this.TabPetList.Padding = new System.Windows.Forms.Padding(3);
            this.TabPetList.Size = new System.Drawing.Size(876, 483);
            this.TabPetList.TabIndex = 0;
            this.TabPetList.Text = "Pet list";
            this.TabPetList.UseVisualStyleBackColor = true;
            // 
            // DgvPet
            // 
            this.DgvPet.AllowUserToAddRows = false;
            this.DgvPet.AllowUserToDeleteRows = false;
            this.DgvPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPet.Location = new System.Drawing.Point(8, 70);
            this.DgvPet.Name = "DgvPet";
            this.DgvPet.ReadOnly = true;
            this.DgvPet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvPet.Size = new System.Drawing.Size(771, 405);
            this.DgvPet.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(785, 152);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 35);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(785, 111);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(85, 35);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddNew.Location = new System.Drawing.Point(785, 70);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(85, 35);
            this.BtnAddNew.TabIndex = 2;
            this.BtnAddNew.Text = "Add new";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Location = new System.Drawing.Point(785, 29);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(85, 35);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(8, 33);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(771, 26);
            this.TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search pet:";
            // 
            // TabPetDetail
            // 
            this.TabPetDetail.Controls.Add(this.BtnCancel);
            this.TabPetDetail.Controls.Add(this.BtnSave);
            this.TabPetDetail.Controls.Add(this.TxtPetColour);
            this.TabPetDetail.Controls.Add(this.TxtPetType);
            this.TabPetDetail.Controls.Add(this.TxtPetName);
            this.TabPetDetail.Controls.Add(this.label6);
            this.TabPetDetail.Controls.Add(this.TxtPetID);
            this.TabPetDetail.Controls.Add(this.label5);
            this.TabPetDetail.Controls.Add(this.label4);
            this.TabPetDetail.Controls.Add(this.label3);
            this.TabPetDetail.Location = new System.Drawing.Point(4, 29);
            this.TabPetDetail.Name = "TabPetDetail";
            this.TabPetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.TabPetDetail.Size = new System.Drawing.Size(876, 483);
            this.TabPetDetail.TabIndex = 1;
            this.TabPetDetail.Text = "Pet detail";
            this.TabPetDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(125, 198);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(85, 35);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(30, 198);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(85, 35);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPetColour
            // 
            this.TxtPetColour.Location = new System.Drawing.Point(30, 156);
            this.TxtPetColour.Name = "TxtPetColour";
            this.TxtPetColour.Size = new System.Drawing.Size(366, 26);
            this.TxtPetColour.TabIndex = 1;
            // 
            // TxtPetType
            // 
            this.TxtPetType.Location = new System.Drawing.Point(218, 104);
            this.TxtPetType.Name = "TxtPetType";
            this.TxtPetType.Size = new System.Drawing.Size(178, 26);
            this.TxtPetType.TabIndex = 1;
            // 
            // TxtPetName
            // 
            this.TxtPetName.Location = new System.Drawing.Point(30, 104);
            this.TxtPetName.Name = "TxtPetName";
            this.TxtPetName.Size = new System.Drawing.Size(178, 26);
            this.TxtPetName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pet colour:";
            // 
            // TxtPetID
            // 
            this.TxtPetID.Location = new System.Drawing.Point(30, 52);
            this.TxtPetID.Name = "TxtPetID";
            this.TxtPetID.ReadOnly = true;
            this.TxtPetID.Size = new System.Drawing.Size(178, 26);
            this.TxtPetID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pet type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pet name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pet ID:";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(845, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PetView";
            this.Text = "PetView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPetList.ResumeLayout(false);
            this.TabPetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPet)).EndInit();
            this.TabPetDetail.ResumeLayout(false);
            this.TabPetDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage TabPetList;
        private System.Windows.Forms.TabPage TabPetDetail;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvPet;
        private System.Windows.Forms.TextBox TxtPetID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtPetColour;
        private System.Windows.Forms.TextBox TxtPetType;
        private System.Windows.Forms.TextBox TxtPetName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClose;
    }
}