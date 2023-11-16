using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var members = memberRepository.GetMembers();
            bool isMem = false;

            foreach (var i in members)
            {
                if (i.MemberName.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text))
                {
                    isMem = true;
                    frmMemberDetail frm = new frmMemberDetail
                    {
                        Text = "Update member",
                        InsertOrUpdate = true,
                        MemberInfor = i,
                        MemberRepository = memberRepository
                    };
                    MessageBox.Show("Login Successfully as a member!", "Login Successfully!", MessageBoxButtons.OK);
                    this.Hide();
                    frm.FormClosed += (s, args) => this.Show();
                    frm.ShowDialog();
                    break;

                }
                else if (txtUserName.Text.Equals("admin@gmail.com") && txtPassword.Text.Equals("1"))
                {
                    frmMemberManagement frm = new frmMemberManagement()
                    {
                        isAdmin = true
                    };
                    isMem = true;
                    MessageBox.Show("Login Successfully as a admin!", "Login Successfully!", MessageBoxButtons.OK);
                    this.Hide();
                    frm.FormClosed += (s, args) => this.Show();
                    frm.ShowDialog();
                    break;

                }
            }
            if (!isMem)
            {
                MessageBox.Show("Wrong user name or password, please try again", "Login Failed!");
                this.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}