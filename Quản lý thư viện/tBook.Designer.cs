namespace Quản_lý_thư_viện
{
    partial class tBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tBook));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txbStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbBuyprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbRentprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbBookname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbBookid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dtgvBook = new System.Windows.Forms.DataGridView();
            this.cbbMajorid = new System.Windows.Forms.ComboBox();
            this.txbid = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(204)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-1, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 54);
            this.panel2.TabIndex = 25;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.lbName.Location = new System.Drawing.Point(64, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(114, 19);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Name Of User";
            this.lbName.Click += new System.EventHandler(this.LbName_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.label6.Location = new System.Drawing.Point(1083, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "DELETE";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(580, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(241, 48);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.btnDelete.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "UPDATE";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(297, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(241, 48);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.btnUpdate.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "ADD";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.White;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = null;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(18, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(241, 48);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.btnAdd.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txbStatus
            // 
            this.txbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbStatus.HintForeColor = System.Drawing.Color.Empty;
            this.txbStatus.HintText = "";
            this.txbStatus.isPassword = false;
            this.txbStatus.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbStatus.LineIdleColor = System.Drawing.Color.Gray;
            this.txbStatus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbStatus.LineThickness = 3;
            this.txbStatus.Location = new System.Drawing.Point(817, 137);
            this.txbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(265, 37);
            this.txbStatus.TabIndex = 35;
            this.txbStatus.Text = "Status";
            this.txbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbBuyprice
            // 
            this.txbBuyprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBuyprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbBuyprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbBuyprice.HintForeColor = System.Drawing.Color.Empty;
            this.txbBuyprice.HintText = "";
            this.txbBuyprice.isPassword = false;
            this.txbBuyprice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbBuyprice.LineIdleColor = System.Drawing.Color.Gray;
            this.txbBuyprice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbBuyprice.LineThickness = 3;
            this.txbBuyprice.Location = new System.Drawing.Point(419, 137);
            this.txbBuyprice.Margin = new System.Windows.Forms.Padding(4);
            this.txbBuyprice.Name = "txbBuyprice";
            this.txbBuyprice.Size = new System.Drawing.Size(265, 37);
            this.txbBuyprice.TabIndex = 34;
            this.txbBuyprice.Text = "Buy Price";
            this.txbBuyprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbRentprice
            // 
            this.txbRentprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRentprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbRentprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRentprice.HintForeColor = System.Drawing.Color.Empty;
            this.txbRentprice.HintText = "";
            this.txbRentprice.isPassword = false;
            this.txbRentprice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbRentprice.LineIdleColor = System.Drawing.Color.Gray;
            this.txbRentprice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbRentprice.LineThickness = 3;
            this.txbRentprice.Location = new System.Drawing.Point(39, 137);
            this.txbRentprice.Margin = new System.Windows.Forms.Padding(4);
            this.txbRentprice.Name = "txbRentprice";
            this.txbRentprice.Size = new System.Drawing.Size(265, 37);
            this.txbRentprice.TabIndex = 33;
            this.txbRentprice.Text = "Rent Price";
            this.txbRentprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbBookname
            // 
            this.txbBookname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBookname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbBookname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbBookname.HintForeColor = System.Drawing.Color.Empty;
            this.txbBookname.HintText = "";
            this.txbBookname.isPassword = false;
            this.txbBookname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbBookname.LineIdleColor = System.Drawing.Color.Gray;
            this.txbBookname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbBookname.LineThickness = 3;
            this.txbBookname.Location = new System.Drawing.Point(419, 73);
            this.txbBookname.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookname.Name = "txbBookname";
            this.txbBookname.Size = new System.Drawing.Size(265, 37);
            this.txbBookname.TabIndex = 31;
            this.txbBookname.Text = "Book Name";
            this.txbBookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbBookid
            // 
            this.txbBookid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBookid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbBookid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbBookid.HintForeColor = System.Drawing.Color.Empty;
            this.txbBookid.HintText = "";
            this.txbBookid.isPassword = false;
            this.txbBookid.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbBookid.LineIdleColor = System.Drawing.Color.Gray;
            this.txbBookid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbBookid.LineThickness = 3;
            this.txbBookid.Location = new System.Drawing.Point(39, 73);
            this.txbBookid.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookid.Name = "txbBookid";
            this.txbBookid.Size = new System.Drawing.Size(265, 37);
            this.txbBookid.TabIndex = 30;
            this.txbBookid.Text = "Book ID";
            this.txbBookid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "SEARCH";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(869, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(241, 48);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.btnSearch.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dtgvBook
            // 
            this.dtgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBook.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBook.Location = new System.Drawing.Point(12, 245);
            this.dtgvBook.Name = "dtgvBook";
            this.dtgvBook.Size = new System.Drawing.Size(1092, 376);
            this.dtgvBook.TabIndex = 37;
            this.dtgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvBook_CellClick);
            this.dtgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvBook_CellContentClick);
            // 
            // cbbMajorid
            // 
            this.cbbMajorid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMajorid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajorid.FormattingEnabled = true;
            this.cbbMajorid.Location = new System.Drawing.Point(817, 81);
            this.cbbMajorid.Name = "cbbMajorid";
            this.cbbMajorid.Size = new System.Drawing.Size(265, 29);
            this.cbbMajorid.TabIndex = 38;
            this.cbbMajorid.Text = "Major ID";
            this.cbbMajorid.SelectedIndexChanged += new System.EventHandler(this.TxbMajorid_SelectedIndexChanged);
            // 
            // txbid
            // 
            this.txbid.Location = new System.Drawing.Point(1100, 57);
            this.txbid.Name = "txbid";
            this.txbid.Size = new System.Drawing.Size(10, 20);
            this.txbid.TabIndex = 39;
            this.txbid.Visible = false;
            // 
            // tBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 633);
            this.Controls.Add(this.txbid);
            this.Controls.Add(this.cbbMajorid);
            this.Controls.Add(this.dtgvBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.txbBuyprice);
            this.Controls.Add(this.txbRentprice);
            this.Controls.Add(this.txbBookname);
            this.Controls.Add(this.txbBookid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tBook";
            this.Load += new System.EventHandler(this.TBook_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbStatus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbBuyprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbRentprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbBookname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbBookid;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView dtgvBook;
        private System.Windows.Forms.ComboBox cbbMajorid;
        private System.Windows.Forms.TextBox txbid;
    }
}