using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Quản_lý_thư_viện
{
    public partial class tStudent : Form
    {
        public tStudent()
        {
            InitializeComponent();
            loadAccount();
        }

        private string getname;

        public string Getname { get => getname; set => getname = value; }

        private void trandata()
        {
            try
            {
                lbName.Text = getname;
            }
            catch (Exception ex)
            {

            }
        }

        public string auth ="erro";
        private void Form1_Load(object sender, EventArgs e)
        {
            if (auth == "Admin")
            {
                
            }
            else if (auth == "Admin2")
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            else if (auth == "Student")
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            trandata();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Information will be changed", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (txbUsername.Text == "" || txbPassword.Text == "" || txbDisplayname.Text == "" || txbStatus.Text == "" || txbType.Text == "" )
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Account DTOAccount = new DTO_Account();
                    DTOAccount.Id = txbID.Text;
                    DTOAccount.Username = txbUsername.Text;
                    DTOAccount.Password = txbPassword.Text;
                    DTOAccount.Displayname = txbDisplayname.Text;
                    DTOAccount.Checkstatus = txbStatus.Text;
                    DTOAccount.Auth = txbType.Text;

                    if (BUS_Account.DeleteAccount(DTOAccount) == true)
                    {
                        MessageBox.Show("Delete Student Success", "Notification");
                        loadAccount();
                        return;
                    }
                    MessageBox.Show("Delete Student Failed", "Notification");

                }

                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void loadAccount()
        {
            List<DTO_Account> listAccount = BUS_Account.loadAccount();
            dtgvStudent.DataSource = listAccount;
        }
        public string id ;
        private void DtgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {       
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvStudent.Rows[index];
                txbID.Text = dr.Cells[0].Value.ToString();
                txbUsername.Text = dr.Cells[1].Value.ToString();
                txbPassword.Text = dr.Cells[2].Value.ToString();
                txbDisplayname.Text = dr.Cells[3].Value.ToString();
                txbStatus.Text = dr.Cells[4].Value.ToString();
                txbType.Text = dr.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (txbUsername.Text == "" || txbPassword.Text == "" || txbDisplayname.Text == "" || txbStatus.Text == "" || txbType.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Account DTOAccount = new DTO_Account();
                DTOAccount.Id = id;
                DTOAccount.Username = txbUsername.Text;
                DTOAccount.Password = txbPassword.Text;
                DTOAccount.Displayname = txbDisplayname.Text;
                DTOAccount.Checkstatus = txbStatus.Text;
                DTOAccount.Auth = txbType.Text;
                
                if (BUS_Account.CheckDup(DTOAccount) == true)
                {
                    MessageBox.Show("The data you entered already exists");
                }
                else
                {
                    if (BUS_Account.InsertAccount(DTOAccount) == true)
                    {
                        MessageBox.Show("Add Account Success", "Notification");
                        loadAccount();
                        return;
                    }
                    MessageBox.Show("Add Account Failed", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Information will be changed", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (txbUsername.Text == "" || txbPassword.Text == "" || txbDisplayname.Text == "" || txbStatus.Text == "" || txbType.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Account DTOAccount = new DTO_Account();
                    DTOAccount.Id = txbID.Text;
                    DTOAccount.Username = txbUsername.Text;
                    DTOAccount.Password = txbPassword.Text;
                    DTOAccount.Displayname = txbDisplayname.Text;
                    DTOAccount.Checkstatus = txbStatus.Text;
                    DTOAccount.Auth = txbType.Text;

                    if (BUS_Account.UpdateAccount(DTOAccount) == true)
                    {
                        MessageBox.Show("Edit Account Success", "Notification");
                        loadAccount();
                        return;
                    }
                    MessageBox.Show("Edit Account Failed", "Notification");

                }

                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
                string id = txbUsername.Text;
                List<DTO_Account> searchaccount = BUS_Account.searchAccount(id);
                dtgvStudent.DataSource = searchaccount;
        }

        private void DtgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LbName_Click(object sender, EventArgs e)
        {

        }
    }
}
