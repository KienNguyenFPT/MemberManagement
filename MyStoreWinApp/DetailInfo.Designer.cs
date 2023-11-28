namespace MyStoreWinApp
{
    partial class DetailInfo
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
            btnCancel = new Button();
            btnUpdate = new Button();
            detailPassword = new TextBox();
            detailEmail = new TextBox();
            detailCountry = new TextBox();
            detailCity = new TextBox();
            detailName = new TextBox();
            detailID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            id = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(390, 427);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(251, 427);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnSave_Click;
            // 
            // detailPassword
            // 
            detailPassword.Location = new Point(390, 346);
            detailPassword.Name = "detailPassword";
            detailPassword.Size = new Size(265, 27);
            detailPassword.TabIndex = 25;
            // 
            // detailEmail
            // 
            detailEmail.Location = new Point(48, 346);
            detailEmail.Name = "detailEmail";
            detailEmail.Size = new Size(271, 27);
            detailEmail.TabIndex = 23;
            // 
            // detailCountry
            // 
            detailCountry.Location = new Point(390, 250);
            detailCountry.Name = "detailCountry";
            detailCountry.Size = new Size(265, 27);
            detailCountry.TabIndex = 21;
            // 
            // detailCity
            // 
            detailCity.Location = new Point(48, 250);
            detailCity.Name = "detailCity";
            detailCity.Size = new Size(185, 27);
            detailCity.TabIndex = 19;
            // 
            // detailName
            // 
            detailName.Location = new Point(390, 133);
            detailName.Name = "detailName";
            detailName.Size = new Size(265, 27);
            detailName.TabIndex = 17;
            // 
            // detailID
            // 
            detailID.Location = new Point(48, 133);
            detailID.Name = "detailID";
            detailID.Size = new Size(185, 27);
            detailID.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(390, 303);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 24;
            label7.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 303);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 22;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 194);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 20;
            label5.Text = "Member Country:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 194);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 18;
            label4.Text = "Member City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 98);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 16;
            label3.Text = "Member Name:";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(48, 98);
            id.Name = "id";
            id.Size = new Size(87, 20);
            id.TabIndex = 14;
            id.Text = "Member ID:";
            id.Click += id_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 22);
            label1.Name = "label1";
            label1.Size = new Size(247, 23);
            label1.TabIndex = 28;
            label1.Text = "MEMBER INFORMATION";
            // 
            // DetailInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 500);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(detailPassword);
            Controls.Add(detailEmail);
            Controls.Add(detailCountry);
            Controls.Add(detailCity);
            Controls.Add(detailName);
            Controls.Add(detailID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(id);
            Name = "DetailInfo";
            Text = "DetailInfo";
            Load += DetailInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private TextBox detailPassword;
        private TextBox detailEmail;
        private TextBox detailCountry;
        private TextBox detailCity;
        private TextBox detailName;
        private TextBox detailID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label id;
        private Label label1;
    }
}