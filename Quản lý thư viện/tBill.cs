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
    public partial class tBill : Form
    {
        public tBill()
        {
            InitializeComponent();
            loadBill();
            loadCombobox();
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

        private void loadBill()
        {
            List<DTO_Bill> listBill = BUS_Bill.loadbill();
            dtgvBill.DataSource = listBill;
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBill_Load(object sender, EventArgs e)
        {
            trandata();
        }

        private void CbbMajorid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (txbUsername.Text == "" || txbBookname.Text == "" || txbCount.Text == "" || cbbMajorid.Text == "" )
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Bill DTOBill = new DTO_Bill();
                DTOBill.Id = txbBillid.Text;
                DTOBill.Username = txbUsername.Text;
                DTOBill.Name = txbBookname.Text;
                DTOBill.Count = txbCount.Text;
                DTOBill.Majorid = cbbMajorid.Text;
                
                if (BUS_Bill.CheckDup(DTOBill) == true)
                {
                    MessageBox.Show("The data you entered already exists");
                }
                else
                {
                    if (BUS_Bill.InsertBill(DTOBill) == true)
                    {
                        MessageBox.Show("Add Bill Success", "Notification");
                        loadBill();
                        return;
                    }
                    MessageBox.Show("Add Bill Failed", "Notification");
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
                    if (txbUsername.Text == "" || txbBookname.Text == "" || txbCount.Text == "" || cbbMajorid.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Bill DTOBill = new DTO_Bill();
                    DTOBill.Id = txbBillid.Text;
                    DTOBill.Username = txbUsername.Text;
                    DTOBill.Name = txbBookname.Text;
                    DTOBill.Count = txbCount.Text;
                    DTOBill.Majorid = cbbMajorid.Text;

                    if (BUS_Bill.UpdateBill(DTOBill) == true)
                    {
                        MessageBox.Show("Edit Account Success", "Notification");
                        loadBill();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DTO_Bill bl = new DTO_Bill();
            bl.Id = txbUsername.Text;
            List<DTO_Bill> searchbill = BUS_Bill.searchbill(bl);
            dtgvBill.DataSource = searchbill;
        }

        private void DtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvBill.Rows[index];
                txbBillid.Text = dr.Cells[0].Value.ToString();
                txbUsername.Text = dr.Cells[1].Value.ToString();
                txbBookname.Text = dr.Cells[2].Value.ToString();
                txbDatesell.Text = dr.Cells[7].Value.ToString();
                txbDaterent.Text = dr.Cells[8].Value.ToString();
                txbCount.Text = dr.Cells[6].Value.ToString();
                cbbMajorid.Text = dr.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
        public void loadCombobox()
        {
            List<DTO_Major> listmajor = BUS_Major.loadmajor();
            cbbMajorid.DataSource = listmajor;
            cbbMajorid.DisplayMember = "name"; // Giá trị hiển thị;
            cbbMajorid.ValueMember = "id";// Giá trị cần lấy; 
        }
    }
}
