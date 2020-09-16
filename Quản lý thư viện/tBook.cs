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
    public partial class tBook : Form
    {
        public tBook()
        {
            InitializeComponent();
           
        }
        private string getname;
        public string auth;
        public string id;

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

        private void Label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadBook()
        {
           // dtgvBook.Controls.Clear();
            List<DTO_Book> listBook = BUS_Book.loadBook();
            dtgvBook.DataSource = listBook;
        }

        private void DtgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvBook.Rows[index];
                txbBookid.Text = dr.Cells[0].Value.ToString();
                txbBookname.Text = dr.Cells[1].Value.ToString();
                cbbMajorid.Text = dr.Cells[2].Value.ToString();
                txbRentprice.Text = dr.Cells[3].Value.ToString();
                txbBuyprice.Text = dr.Cells[4].Value.ToString();
                txbStatus.Text = dr.Cells[5].Value.ToString();
                txbid.Text = dr.Cells[0].Value.ToString();
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
                if (txbBookid.Text == "" || txbBookname.Text == "" || cbbMajorid.Text == "" || txbRentprice.Text == "" || txbBuyprice.Text == "" || txbStatus.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                // Đối tượng class trong DTO
                DTO_Book DTOBook = new DTO_Book();
                DTOBook.Bookid = txbBookid.Text;
                DTOBook.Name = txbBookname.Text;
                DTOBook.Majorid = cbbMajorid.Text;
                DTOBook.Rentprice = txbRentprice.Text;
                DTOBook.Buyprice = txbBuyprice.Text;
                DTOBook.Status = txbStatus.Text;

                if (BUS_Book.CheckDup(DTOBook) == true)
                {
                    MessageBox.Show("The data you entered already exists");
                }
                else
                {
                    if (BUS_Book.InsertBook(DTOBook) == true)
                    {
                        MessageBox.Show("Add Book Success", "Notification");
                        loadBook();
                        return;
                    }
                    MessageBox.Show("Add Book Failed", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                TBook_Load(sender, e);
            }
        }

        private void TBook_Load(object sender, EventArgs e)
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
            loadBook();
            loadCombobox();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Information will be changed", "Notification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (txbBookid.Text == "" || txbBookname.Text == "" || cbbMajorid.Text == "" || txbRentprice.Text == "" || txbBuyprice.Text == "" || txbStatus.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Book DTOBook = new DTO_Book();
                    DTOBook.Bookid = txbBookid.Text;
                    DTOBook.Name = txbBookname.Text;
                    DTOBook.Majorid = cbbMajorid.Text;
                    DTOBook.Rentprice = txbRentprice.Text;
                    DTOBook.Buyprice = txbBuyprice.Text;
                    DTOBook.Status = txbStatus.Text;
                    string id = txbid.Text;
                    
                    if (BUS_Book.EditBook(DTOBook,id) == true)
                    {
                        MessageBox.Show("Update Book Success", "Notification");
                        loadBook();
                        return;
                    }
                    MessageBox.Show("Update Book Failed", "Notification");

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

        public void loadCombobox()
        {
            List<DTO_Major> listmajor = BUS_Major.loadmajor();
            cbbMajorid.DataSource = listmajor;
            cbbMajorid.DisplayMember = "name"; // Giá trị hiển thị;
            cbbMajorid.ValueMember = "id";// Giá trị cần lấy; 
        }
        private void TxbMajorid_SelectedIndexChanged(object sender, EventArgs e)
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
                    if (txbBookid.Text == "" || txbBookname.Text == "" || cbbMajorid.Text == "" || txbRentprice.Text == "" || txbBuyprice.Text == "" || txbStatus.Text == "")
                    {
                        MessageBox.Show("All Fields Are Compulsory");
                        return;
                    }
                    // Đối tượng class trong DTO
                    DTO_Book DTOBook = new DTO_Book();
                    DTOBook.Bookid=txbBookid.Text;
                    DTOBook.Name = txbBookname.Text;
                    DTOBook.Majorid = cbbMajorid.Text;
                    DTOBook.Rentprice = txbRentprice.Text;
                    DTOBook.Buyprice = txbBuyprice.Text;
                    DTOBook.Status = txbStatus.Text;

                    if (BUS_Book.DeleteBook(DTOBook) == true)
                    {
                        MessageBox.Show("Delete Book Success", "Notification");
                        loadBook();
                        return;
                    }
                    MessageBox.Show("Delete Book Failed", "Notification");

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

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void LbName_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbBookname.Text == "")
                {
                    MessageBox.Show("All Fields Are Compulsory");
                    return;
                }
                string id = txbBookname.Text;
                List<DTO_Book> listbook = BUS_Book.searchBook(id);
                dtgvBook.DataSource = listbook;
            }
            catch (Exception ex)
            {

            }
        }

        private void DtgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

