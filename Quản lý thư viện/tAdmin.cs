using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quản_lý_thư_viện
{
    public partial class tAdmin : Form
    {
        public tAdmin()
        {
            InitializeComponent();
        }
        // lấy thông tin tên đn load vào lb 
        public string auth;
        private string getname;
        private string getauth;
        public string Getname
        {
            get
            {
                return getname;
            }
            set
            {
                getname = value;
            }
        }

        public string Getauth
        {
            get
            {
                return getauth;
            }
            set
            {
                getauth = value;
            }
        }

        private void trandata()
        {
            try
            {
                lbNameuser.Text = getname;
            }
            catch (Exception ex)
            {

            }
        }

        private void listdtgvauth()
        {

        }
        private void listdtgvuser()
        {
            string id = lbNameuser.Text;
            List<DTO_Account> listuser = BUS_Account.searchAccount(id);
            dtgvUser.DataSource = listuser;

        }
        private void Label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TAdmin_Load(object sender, EventArgs e)
        {
            // load số lượng data load vào label
            string str = @"Data Source=DESKTOP-2MKPB58;Initial Catalog=QuanLyThuVien;Persist Security Info=True;User ID=sa;Password=sa";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;
            SqlCommand cmd1;
            SqlCommand cmd2;
            SqlCommand cmd3;
            string book = "Select count (*) from dbo.Book";
            string bill = "Select count (*) from dbo.Bill";
            string account = "Select count (*) from dbo.Account";
            string major = "Select count (*) from dbo.Major";
            try
            {
                con.Open();
                cmd = new SqlCommand(book, con);
                cmd1 = new SqlCommand(bill, con);
                cmd2 = new SqlCommand(account, con);
                cmd3 = new SqlCommand(major, con);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                Int32 count1 = Convert.ToInt32(cmd1.ExecuteScalar());
                Int32 count2 = Convert.ToInt32(cmd2.ExecuteScalar());
                Int32 count3 = Convert.ToInt32(cmd3.ExecuteScalar());
                cmd.Dispose();
                cmd1.Dispose();
                cmd2.Dispose();
                cmd3.Dispose();
                con.Close();
                lbBook.Text = "" + count.ToString();
                lbBill.Text = "" + count1.ToString();
                lbAccount.Text = "" + count2.ToString();
                lbMajor.Text = "" + count3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            

            // phân quyền
            if (auth == "Admin")
            {
                pictureBox7.Visible = false;
            }
            else if (auth == "Admin2")
            {
                btnMajor.Visible = false;
                pictureBox7.Visible = false;
            }
            else if (auth == "Student")
            {
                btnStudents.Visible = false;
                btnBill.Visible = false;
                btnMajor.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
            }
            trandata();
            listdtgvuser();
            listdtgvauth();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {

            tBook book = new tBook();
            book.Getname = lbNameuser.Text;
            book.auth = this.auth;
            book.ShowDialog();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            tStudent student = new tStudent();
            student.Getname = lbNameuser.Text;
            student.auth = this.auth;
            student.ShowDialog();
        }

        private void BtnMajor_Click(object sender, EventArgs e)
        {
            tMajor major = new tMajor();
            major.Getname = lbNameuser.Text;
            major.auth = this.auth;
            major.ShowDialog();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            tBill bill = new tBill();
            bill.Getname = lbNameuser.Text;
            bill.ShowDialog();
        }

        private void LbNameuser_Click(object sender, EventArgs e)
        {

        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            tProfile profile = new tProfile();
            profile.Getname = lbNameuser.Text;
            profile.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            TAdmin_Load(sender, e);
        }


        private void LbBook_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            tLogin login = new tLogin();
            login.Show();
            this.Hide();
        }
    }
}
