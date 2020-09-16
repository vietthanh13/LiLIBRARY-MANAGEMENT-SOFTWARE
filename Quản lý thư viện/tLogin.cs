using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Quản_lý_thư_viện
{
    public partial class tLogin : Form
    {
        public tLogin()
        {
            InitializeComponent();
        }

        private void PanelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ask the Librarian to reset your password!!!");
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            try
            {

                // Kiểm tra dữ liệu đầu vào
                if (txbUsername.Text == "" || txbPassword.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                MessageBox.Show(txbUsername.Text + "," + txbPassword.Text);

                // Đối tượng class trong DTO
                //DTO_Login DTOLogin = new DTO_Login();
                //DTOLogin.Username = txbUsername.Text;
                //DTOLogin.Password = txbPassword.Text;

                BUS_Login blg = new BUS_Login();
                DTO_Login lg = new DTO_Login(txbUsername.Text, txbPassword.Text);

                //if (blg.Checkauth(lg) == true)
                //{
                //    MessageBox.Show("Your account has not been activated yet");
                //}

                //else
                //{
                //cau lenh dang nhap neu nhap dung username va pass thi hien form

                if (blg.checkLogin(lg).Rows.Count > 0)
                {
                    tAdmin ad = new tAdmin();
                    ad.Getname = txbUsername.Text;
                    ad.auth = blg.checkLogin(lg).Rows[0][5].ToString();
                    ad.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Txtcheckmanager_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
