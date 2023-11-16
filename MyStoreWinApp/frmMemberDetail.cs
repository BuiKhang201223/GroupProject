using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        //-----------------------------------------
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member MemberInfor { get; set; }
        //----------------------------------------------
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = 0;
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//update mode
            {
                //Show member to perform updating
                txtMemberID.Text = MemberInfor.MemberId.ToString();
                txtMemberName.Text = MemberInfor.MemberName;
                cboCity.Text = MemberInfor.City;
                txtEmail.Text = MemberInfor.Email;
                cboCountry.Text = MemberInfor.Country;
                txtPassword.Text = MemberInfor.Password;
            }
        }

        static bool IsValidEmail(string email)
        {
            // Define a regular expression for a simple email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                    bool isValidEmail = IsValidEmail(txtEmail.Text);
                    if (isValidEmail)
                    {
                    var member = new Member
                    {
                        MemberId = int.Parse(txtMemberID.Text),
                        MemberName = txtMemberName.Text,
                        City = cboCity.Text,
                        Email = txtEmail.Text,
                        Country = cboCountry.Text,
                        Password = txtPassword.Text,
                    };
                    if (InsertOrUpdate == false)
                    {
                        if (MemberRepository.GetMemberByID(member.MemberId) != null)
                        {
                            MessageBox.Show("Member is already existed.", "member existed", MessageBoxButtons.OK);
                            return;
                        }
                        MemberRepository.InsertMember(member);
                    }
                    else
                    {
                        MemberRepository.UpdateMember(member);
                    }
                }
                else
                {
                    MessageBox.Show("Email wrong format.", "Wrong", MessageBoxButtons.OK);
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
