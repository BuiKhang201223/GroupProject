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
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var admin = new Member
            {
                Email = config["DefaultAccount:Email"],
                Password = config["DefaultAccount:password"]
            };



            // add employees to richtextbox


            var members = memberRepository.GetMembers();
            bool isMem = false;

            foreach (var i in members)
            {
                if (i.MemberName.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text))
                {
                    //    frmMemberManagement frm = new frmMemberManagement()
                    //{
                    //    isAdmin = false
                    //};
                    isMem = true;
                    frmMemberDetail frm = new frmMemberDetail
                    {
                        Text = "Update member",
                        InsertOrUpdate = true,
                        MemberInfor = i,
                        MemberRepository = memberRepository
                    };
                    MessageBox.Show("Login Successfully!", "Login Successfully!", MessageBoxButtons.OK);
                    this.Hide();
                    frm.FormClosed += (s, args) => this.Show();
                    frm.ShowDialog();
                    break;

                }
                else if (admin.Email.Equals(txtUserName.Text) && admin.Password.Equals(txtPassword.Text))
                {
                    frmMemberManagement frm = new frmMemberManagement()
                    {
                        isAdmin = true
                    };
                    isMem = true;
                    MessageBox.Show("Login Successfully!", "Login Successfully!", MessageBoxButtons.OK);
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