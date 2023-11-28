using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>
        {
            new User { Email = "admin@fstore.com", Password = "admin@@", Role = "Admin" },
            new User { Email = "kien@gmail.com", Password = "1234567", Role = "Member" },
            new User { Email = "huy1@gmail.com", Password = "123456", Role = "Member" }
        };

        List<Member> members = new List<Member> {
           new Member { MemberID = 1, Name = "Trung Hieu", City = "Gia Lai", Country = "America", Email = "kien@gmail.com", Password = "1234567" },
           new Member { MemberID = 2, Name = "Hoang Huy", City = "HCM", Country = "VietNam", Email = "huy1@gmail.com", Password = "123456" },



        };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private User AuthenticateUser(string email, string password)
        {
            User user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPassword.Text;
            User authenticatedUser = AuthenticateUser(email, password);
            if (authenticatedUser != null)
            {
                if (authenticatedUser.Role == "Admin")
                {
                    MemberManegementsForm mm = new MemberManegementsForm();
                    //mn.StartPosition = FormStartPosition.CenterScreen;
                    mm.StartPosition = FormStartPosition.CenterScreen;  
                    mm.Show();
                    this.Hide();
                }
                else
                {
                    Member member = members.FirstOrDefault(m => m.Email == email);
                    if (member != null)
                    {
                        // Open the DetailInfo form with the authenticated member's details
                        InforForm inf = new InforForm(member);
                        inf.StartPosition = FormStartPosition.CenterScreen;
                        inf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Member not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong email or password. Please try again.");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
