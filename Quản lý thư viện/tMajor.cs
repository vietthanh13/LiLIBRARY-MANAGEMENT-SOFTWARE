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
    public partial class tMajor : Form
    {
        public tMajor()
        {
            InitializeComponent();
            loadmajor();
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

        public string auth;
        private void Label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadmajor()
        {
            List<DTO_Major> listMajor = BUS_Major.loadmajor();
            dtgvMajor.DataSource = BUS_Major.loadmajor();
        }

        private void DtgvMajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvMajor.Rows[index];
                txbMajorid.Text = dr.Cells[0].Value.ToString();
                txbMajorname.Text = dr.Cells[1].Value.ToString();
                txbid.Text = dr.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void TMajor_Load(object sender, EventArgs e)
        {
            trandata();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbMajorid.Text == "" || txbMajorname.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                DTO_Major DTOMajor = new DTO_Major();
                DTOMajor.Id = txbMajorid.Text;
                DTOMajor.Name = txbMajorname.Text;
                if (BUS_Major.CheckDup(DTOMajor)==true)
                {
                    MessageBox.Show("The Data you entered already exists");
                }
                else
                {
                    if (BUS_Major.InsertMajor(DTOMajor)==true)
                    {
                        MessageBox.Show("Add Major Success", "Notification");
                        loadmajor();
                        return;
                    }
                    MessageBox.Show("Add Major failed", "Notification");
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
                if (txbMajorid.Text == "" || txbMajorname.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                DTO_Major DTOMajor = new DTO_Major();
                
                DTOMajor.Name = txbMajorname.Text;
                string id = txbid.Text;
                if (BUS_Major.CheckDup(DTOMajor) == true)
                {
                    MessageBox.Show("The Data you entered already exists");
                }
                else
                {
                    if (BUS_Major.EditMajor(DTOMajor,id) == true)
                    {
                        MessageBox.Show("Edit Major Success", "Notification");
                        loadmajor();
                        return;
                    }
                    MessageBox.Show("Edit Major failed", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Information will be changed", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (txbMajorid.Text == "" || txbMajorname.Text == "" )
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Major DTOMajor = new DTO_Major();
                    DTOMajor.Id = txbMajorid.Text;
                    DTOMajor.Name = txbMajorname.Text;
                    

                    if (BUS_Major.DeleteMajor(DTOMajor) == true)
                    {
                        MessageBox.Show("Delete Major Success", "Notification");
                        loadmajor();
                        return;
                    }
                    MessageBox.Show("Delete Major Failed", "Notification");

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

        private void LbName_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DTO_Major mj = new DTO_Major();
            mj.Id = txbMajorid.Text;
            List<DTO_Major> searchmajor = BUS_Major.searchmajor(mj);
            dtgvMajor.DataSource = searchmajor;
        }
    }
}
