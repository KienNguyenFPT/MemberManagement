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
    public partial class InforForm : Form
    {
        private Member member;
        public InforForm(Member member)
        {
            InitializeComponent();
            //detailID.Text = selectedMember.MemberID.ToString();
            detailID.Text = member.MemberID.ToString();
            detailName.Text = member.Name;
            detailCity.Text = member.City;
            detailCountry.Text = member.Country;
            detailEmail.Text = member.Email;
            detailPassword.Text = member.Password;
            detailID.Enabled = false;
            this.member = member;
        }

        private void detailCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InforForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            member.Name = detailName.Text;
            member.City = detailCity.Text;
            member.Country = detailCountry.Text;
            member.Email = detailEmail.Text;
            member.Password = detailPassword.Text;

            // Display a success message
            MessageBox.Show("Update successful!");

            // Update the form controls with the updated information
            detailName.Text = member.Name;
            detailCity.Text = member.City;
            detailCountry.Text = member.Country;
            detailEmail.Text = member.Email;
            detailPassword.Text = member.Password;

        }
    }
}
