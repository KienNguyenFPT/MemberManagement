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
    public partial class DetailInfo : Form
    {
        private Member member;

        public DetailInfo(Member member)
        {
            InitializeComponent();
            this.member = member;
            //detailID.Text = selectedMember.MemberID.ToString();
            detailID.Text = member.MemberID.ToString();
            detailName.Text = member.Name;
            detailCity.Text = member.City;
            detailCountry.Text = member.Country;
            detailEmail.Text = member.Email;
            detailPassword.Text = member.Password;
            detailID.Enabled = false;
        }

        public Member getUpdated()
        {
            member.Name = detailName.Text;
            member.City = detailCity.Text;
            member.Country = detailCountry.Text;
            member.Email = detailEmail.Text;
            member.Password = detailPassword.Text;
            return member;
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void DetailInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            member.Name = detailName.Text;
            member.City = detailCity.Text;
            member.Country = detailCountry.Text;
            member.Email = detailEmail.Text;
            member.Password = detailPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();








        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Hide(); 
        }
    }
}
