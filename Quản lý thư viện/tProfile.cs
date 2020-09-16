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
    public partial class tProfile : Form
    {
        public tProfile()
        {
            InitializeComponent();
        }
        private string getname;

        public string Getname { get => getname; set => getname = value; }

        private void Label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

        private void TProfile_Load(object sender, EventArgs e)
        {
            trandata();
            listdtgvuser();
            Dgv_CellClick(dgv, new DataGridViewCellEventArgs(0, 0));
        }
        private void listdtgvuser()
        {
            string id = lbName.Text;
            List<DTO_Account> listuser = BUS_Account.searchAccount(id);
            dgv.DataSource = listuser;

        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dgv.Rows[index];
                txbUsername.Text = dr.Cells[1].Value.ToString();
                txbPassword.Text = dr.Cells[2].Value.ToString();
                txbDisplayname.Text = dr.Cells[3].Value.ToString();
                txbStatus.Text = dr.Cells[4].Value.ToString();
                txbAuth.Text = dr.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
       
