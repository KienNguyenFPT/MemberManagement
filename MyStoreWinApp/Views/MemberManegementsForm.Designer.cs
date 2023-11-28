namespace MyStoreWinApp
{
    partial class MemberManegementsForm
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
            txtPassword = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            tabDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtEmail = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            id = new Label();
            tabControl1 = new TabPage();
            btnByCountry = new Button();
            label9 = new Label();
            label8 = new Label();
            txtByCountry = new TextBox();
            txtByCity = new TextBox();
            btnLoad = new Button();
            btnSort = new Button();
            btnByCity = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridMember = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCity = new DataGridViewTextBoxColumn();
            colCountry = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            tagControl = new TabControl();
            btnClose = new Button();
            panel1.SuspendLayout();
            tabDetail.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMember).BeginInit();
            tagControl.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(384, 276);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(265, 27);
            txtPassword.TabIndex = 11;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 23);
            label1.TabIndex = 0;
            label1.Text = "MEMBERS MANAGEMENT";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 40);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // tabDetail
            // 
            tabDetail.Controls.Add(btnCancel);
            tabDetail.Controls.Add(btnSave);
            tabDetail.Controls.Add(txtPassword);
            tabDetail.Controls.Add(txtEmail);
            tabDetail.Controls.Add(txtCountry);
            tabDetail.Controls.Add(txtCity);
            tabDetail.Controls.Add(txtName);
            tabDetail.Controls.Add(txtID);
            tabDetail.Controls.Add(label7);
            tabDetail.Controls.Add(label6);
            tabDetail.Controls.Add(label5);
            tabDetail.Controls.Add(label4);
            tabDetail.Controls.Add(label3);
            tabDetail.Controls.Add(id);
            tabDetail.Location = new Point(4, 29);
            tabDetail.Name = "tabDetail";
            tabDetail.Padding = new Padding(3);
            tabDetail.Size = new Size(994, 509);
            tabDetail.TabIndex = 1;
            tabDetail.Text = "Member detail";
            tabDetail.UseVisualStyleBackColor = true;
            tabDetail.Click += tabPage2_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(425, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(263, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(42, 276);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 27);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(384, 180);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(265, 27);
            txtCountry.TabIndex = 7;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(42, 180);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(185, 27);
            txtCity.TabIndex = 5;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(384, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 27);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(42, 63);
            txtID.Name = "txtID";
            txtID.Size = new Size(185, 27);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(384, 233);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 10;
            label7.Text = "Password:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 233);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 8;
            label6.Text = "Email:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 124);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 6;
            label5.Text = "Member Country:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 124);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 4;
            label4.Text = "Member City:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 28);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Member Name:";
            label3.Click += label3_Click;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(42, 28);
            id.Name = "id";
            id.Size = new Size(87, 20);
            id.TabIndex = 0;
            id.Text = "Member ID:";
            id.Click += id_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(btnClose);
            tabControl1.Controls.Add(btnByCountry);
            tabControl1.Controls.Add(label9);
            tabControl1.Controls.Add(label8);
            tabControl1.Controls.Add(txtByCountry);
            tabControl1.Controls.Add(txtByCity);
            tabControl1.Controls.Add(btnLoad);
            tabControl1.Controls.Add(btnSort);
            tabControl1.Controls.Add(btnByCity);
            tabControl1.Controls.Add(btnDelete);
            tabControl1.Controls.Add(btnEdit);
            tabControl1.Controls.Add(btnAdd);
            tabControl1.Controls.Add(dataGridMember);
            tabControl1.Controls.Add(btnSearch);
            tabControl1.Controls.Add(txtSearch);
            tabControl1.Controls.Add(label2);
            tabControl1.Location = new Point(4, 29);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Padding(3);
            tabControl1.Size = new Size(994, 509);
            tabControl1.TabIndex = 0;
            tabControl1.Text = "Member List";
            tabControl1.UseVisualStyleBackColor = true;
            tabControl1.Click += tabControl1_Click;
            // 
            // btnByCountry
            // 
            btnByCountry.Location = new Point(732, 132);
            btnByCountry.Name = "btnByCountry";
            btnByCountry.Size = new Size(140, 27);
            btnByCountry.TabIndex = 14;
            btnByCountry.Text = "Filter Country";
            btnByCountry.TextAlign = ContentAlignment.MiddleLeft;
            btnByCountry.UseVisualStyleBackColor = true;
            btnByCountry.Click += btnByCountry_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 111);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 13;
            label9.Text = "Filter by Country";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 65);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 12;
            label8.Text = "Filter by City";
            // 
            // txtByCountry
            // 
            txtByCountry.Location = new Point(18, 132);
            txtByCountry.Name = "txtByCountry";
            txtByCountry.Size = new Size(670, 27);
            txtByCountry.TabIndex = 11;
            txtByCountry.TextChanged += textBox2_TextChanged;
            // 
            // txtByCity
            // 
            txtByCity.Location = new Point(18, 81);
            txtByCity.Name = "txtByCity";
            txtByCity.Size = new Size(670, 27);
            txtByCity.TabIndex = 10;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(18, 479);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(852, 367);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(94, 29);
            btnSort.TabIndex = 8;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += button2_Click;
            // 
            // btnByCity
            // 
            btnByCity.Location = new Point(732, 81);
            btnByCity.Name = "btnByCity";
            btnByCity.Size = new Size(140, 27);
            btnByCity.TabIndex = 7;
            btnByCity.Text = "Filter City";
            btnByCity.TextAlign = ContentAlignment.MiddleLeft;
            btnByCity.UseVisualStyleBackColor = true;
            btnByCity.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(852, 306);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(852, 250);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(852, 196);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridMember
            // 
            dataGridMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMember.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colCity, colCountry, colEmail, colPassword });
            dataGridMember.Location = new Point(18, 196);
            dataGridMember.Name = "dataGridMember";
            dataGridMember.RowHeadersWidth = 51;
            dataGridMember.RowTemplate.Height = 29;
            dataGridMember.Size = new Size(808, 277);
            dataGridMember.TabIndex = 3;
            dataGridMember.CellContentClick += dgv_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "Member ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 125;
            // 
            // colCity
            // 
            colCity.HeaderText = "City";
            colCity.MinimumWidth = 6;
            colCity.Name = "colCity";
            colCity.Width = 125;
            // 
            // colCountry
            // 
            colCountry.HeaderText = "Country";
            colCountry.MinimumWidth = 6;
            colCountry.Name = "colCountry";
            colCountry.Width = 125;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.Width = 125;
            // 
            // colPassword
            // 
            colPassword.HeaderText = "Password";
            colPassword.MinimumWidth = 6;
            colPassword.Name = "colPassword";
            colPassword.Width = 125;
            // 
            // btnSearch
            // 
            btnSearch.ImageAlign = ContentAlignment.BottomRight;
            btnSearch.Location = new Point(732, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(670, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 12);
            label2.Name = "label2";
            label2.Size = new Size(215, 20);
            label2.TabIndex = 0;
            label2.Text = "Search member (By ID/Name): ";
            label2.Click += label2_Click_1;
            // 
            // tagControl
            // 
            tagControl.Controls.Add(tabControl1);
            tagControl.Controls.Add(tabDetail);
            tagControl.Dock = DockStyle.Fill;
            tagControl.Location = new Point(0, 40);
            tagControl.Name = "tagControl";
            tagControl.SelectedIndex = 0;
            tagControl.Size = new Size(1002, 542);
            tagControl.TabIndex = 2;
            tagControl.SelectedIndexChanged += tagControl_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(852, 424);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MemberManegementsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 582);
            Controls.Add(tagControl);
            Controls.Add(panel1);
            Name = "MemberManegementsForm";
            Text = "MemberManegementsForm";
            Load += MemberManegementsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabDetail.ResumeLayout(false);
            tabDetail.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMember).EndInit();
            tagControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabPage tabDetail;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtEmail;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtName;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label id;
        private TabPage tabControl1;
        private Button btnSort;
        private Button btnByCity;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dataGridMember;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCity;
        private DataGridViewTextBoxColumn colCountry;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPassword;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private TabControl tagControl;
        private TextBox txtPassword;
        private Button btnLoad;
        private TextBox txtByCountry;
        private TextBox txtByCity;
        private Label label9;
        private Label label8;
        private Button btnByCountry;
        private Button btnClose;
    }
}