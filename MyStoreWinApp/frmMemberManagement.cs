using AutoMapper;
using BusinessObject;
using BusinessObject.DTO;
using BusinessObject.Mapper;
using DataAccess.Repository;
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
    public partial class frmMemberManagement : Form
    {
        public bool isAdmin { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;


        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;

                cboCity.Enabled = false;
                cboCountry.Enabled = false;
                txtEmail.Enabled = false;
                txtMemberID.Enabled = false;
                txtMemberName.Enabled = false;
                txtPassword.Enabled = false;
                btnDelete.Enabled = false;
                btnFind.Enabled = false;
                cboSearchCity.Enabled = false;
                cboSearchCountry.Enabled = false;
                dgvMemberList.CellDoubleClick += null;
            }
            else
            {
                btnDelete.Enabled = false;
                dgvMemberList.CellContentDoubleClick += DgvMemberList_CellDoubleClick;
            }
        }
        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetails = new frmMemberDetail
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfor = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cboCountry.Text = string.Empty;
            cboCity.Text = string.Empty;
        }
        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    Country = cboCountry.Text,
                    City = cboCity.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }
        public void LoadMemberList()
        {
            var members = memberRepository.GetMembers();
            if (members.ToList().Count == 0)
            {
                dgvMemberList.DataSource = null;
                return;
            }
            var config = new MapperConfiguration(cfg =>
            {
                MemberConfig.createMap(cfg);
            });

            var mapperMember = config.CreateMapper();

            var memDTOs = members.Select(
                mem => mapperMember
                .Map<Member, MemberDTO>(mem)
                );


            try
            {
                source = new BindingSource();
                source.DataSource = memDTOs.OrderByDescending(member => member.MemberName);
                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                cboCountry.DataBindings.Clear();
                cboCity.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                cboCountry.DataBindings.Add("Text", source, "Country");
                cboCity.DataBindings.Add("Text", source, "City");


                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (isAdmin == false)
                {
                    if (memDTOs.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                    }
                }
                else
                {
                    if (memDTOs.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        //------------------------------------------------------
        private void btnLoad_Click(object sender, EventArgs e)
        {

            LoadMemberList();


        }
        //-----------------------------------------------------
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetails = new frmMemberDetail
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            frmMemberDetails.Show();
            source.Position = source.Count - 1;
            dgvMemberList.DataSource = null;
            LoadMemberList();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?", "Do you want to delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberId);
                LoadMemberList();
            }
            return;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            List<Member> list = memberRepository.GetMemberByIDAndName(txtSearch.Text);
            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = list;
        }

        private void FilterMember()
        {

            Member member = new Member();
            List<Member> filterList = memberRepository.GetMemberByCityAndCountry(cboSearchCity.Text, cboSearchCountry.Text);
            // var members = memberRepository.GetMembers();
            try
            {
                if (filterList.Count == 0)
                {
                    MessageBox.Show("No member matched", "No result");
                }
                else if (filterList.Count != 0)
                {
                    source = new BindingSource();
                    source.DataSource = filterList.OrderByDescending(member => member.MemberName);
                    txtMemberID.DataBindings.Clear();
                    txtMemberName.DataBindings.Clear();
                    txtPassword.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    cboCountry.DataBindings.Clear();
                    cboCity.DataBindings.Clear();

                    txtMemberID.DataBindings.Add("Text", source, "MemberID");
                    txtMemberName.DataBindings.Add("Text", source, "MemberName");
                    txtPassword.DataBindings.Add("Text", source, "Password");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    cboCountry.DataBindings.Add("Text", source, "Country");
                    cboCity.DataBindings.Add("Text", source, "City");


                    dgvMemberList.DataSource = null;
                    dgvMemberList.DataSource = source;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            FilterMember();
        }
        private void cboSearchCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // searchCity= cboSearchCity.Text;
        }

        private void cboSearchCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // searchCountry= cboSearchCountry.Text;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
