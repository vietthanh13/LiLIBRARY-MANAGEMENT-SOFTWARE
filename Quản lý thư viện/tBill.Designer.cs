namespace Quản_lý_thư_viện
{
    partial class tBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tBill));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbBillid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbBookname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbDaterent = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbDatesell = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbCount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.cbbMajorid = new System.Windows.Forms.ComboBox();
            this.txbid = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(204)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 54);
            this.panel2.TabIndex = 25;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.lbName.Location = new System.Drawing.Point(57, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(114, 19);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Name Of User";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
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
            this.label6.Location = new System.Drawing.Point(1076, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
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
            this.btnDelete.Location = new System.Drawing.Point(588, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(241, 48);
            this.btnDelete.TabIndex = 31;
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
            this.btnUpdate.Location = new System.Drawing.Point(299, 193);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(241, 48);
            this.btnUpdate.TabIndex = 30;
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
            this.btnAdd.Location = new System.Drawing.Point(12, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(241, 48);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.btnAdd.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txbUsername
            // 
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txbUsername.HintText = "";
            this.txbUsername.isPassword = false;
            this.txbUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txbUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbUsername.LineThickness = 3;
            this.txbUsername.Location = new System.Drawing.Point(299, 75);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(265, 37);
            this.txbUsername.TabIndex = 28;
            this.txbUsername.Text = "User Name";
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbBillid
            // 
            this.txbBillid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBillid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbBillid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbBillid.HintForeColor = System.Drawing.Color.Empty;
            this.txbBillid.HintText = "";
            this.txbBillid.isPassword = false;
            this.txbBillid.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbBillid.LineIdleColor = System.Drawing.Color.Gray;
            this.txbBillid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbBillid.LineThickness = 3;
            this.txbBillid.Location = new System.Drawing.Point(13, 75);
            this.txbBillid.Margin = new System.Windows.Forms.Padding(4);
            this.txbBillid.Name = "txbBillid";
            this.txbBillid.Size = new System.Drawing.Size(265, 37);
            this.txbBillid.TabIndex = 27;
            this.txbBillid.Text = "Bill ID";
            this.txbBillid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txbBookname.Location = new System.Drawing.Point(588, 75);
            this.txbBookname.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookname.Name = "txbBookname";
            this.txbBookname.Size = new System.Drawing.Size(265, 37);
            this.txbBookname.TabIndex = 32;
            this.txbBookname.Text = "Book Name";
            this.txbBookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbDaterent
            // 
            this.txbDaterent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDaterent.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbDaterent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDaterent.HintForeColor = System.Drawing.Color.Empty;
            this.txbDaterent.HintText = "";
            this.txbDaterent.isPassword = false;
            this.txbDaterent.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbDaterent.LineIdleColor = System.Drawing.Color.Gray;
            this.txbDaterent.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbDaterent.LineThickness = 3;
            this.txbDaterent.Location = new System.Drawing.Point(299, 139);
            this.txbDaterent.Margin = new System.Windows.Forms.Padding(4);
            this.txbDaterent.Name = "txbDaterent";
            this.txbDaterent.Size = new System.Drawing.Size(265, 37);
            this.txbDaterent.TabIndex = 33;
            this.txbDaterent.Text = "Date Rent";
            this.txbDaterent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbDatesell
            // 
            this.txbDatesell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDatesell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbDatesell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDatesell.HintForeColor = System.Drawing.Color.Empty;
            this.txbDatesell.HintText = "";
            this.txbDatesell.isPassword = false;
            this.txbDatesell.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbDatesell.LineIdleColor = System.Drawing.Color.Gray;
            this.txbDatesell.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbDatesell.LineThickness = 3;
            this.txbDatesell.Location = new System.Drawing.Point(13, 139);
            this.txbDatesell.Margin = new System.Windows.Forms.Padding(4);
            this.txbDatesell.Name = "txbDatesell";
            this.txbDatesell.Size = new System.Drawing.Size(265, 37);
            this.txbDatesell.TabIndex = 34;
            this.txbDatesell.Text = "Date Sell";
            this.txbDatesell.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbCount
            // 
            this.txbCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCount.HintForeColor = System.Drawing.Color.Empty;
            this.txbCount.HintText = "";
            this.txbCount.isPassword = false;
            this.txbCount.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbCount.LineIdleColor = System.Drawing.Color.Gray;
            this.txbCount.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbCount.LineThickness = 3;
            this.txbCount.Location = new System.Drawing.Point(588, 139);
            this.txbCount.Margin = new System.Windows.Forms.Padding(4);
            this.txbCount.Name = "txbCount";
            this.txbCount.Size = new System.Drawing.Size(265, 37);
            this.txbCount.TabIndex = 35;
            this.txbCount.Text = "Count";
            this.txbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnSearch.Location = new System.Drawing.Point(861, 193);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(241, 48);
            this.btnSearch.TabIndex = 37;
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
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(10, 248);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(1094, 373);
            this.dtgvBill.TabIndex = 39;
            this.dtgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvBill_CellContentClick);
            // 
            // cbbMajorid
            // 
            this.cbbMajorid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMajorid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajorid.FormattingEnabled = true;
            this.cbbMajorid.Location = new System.Drawing.Point(862, 147);
            this.cbbMajorid.Name = "cbbMajorid";
            this.cbbMajorid.Size = new System.Drawing.Size(242, 29);
            this.cbbMajorid.TabIndex = 40;
            this.cbbMajorid.Text = "Major ID";
            this.cbbMajorid.SelectedIndexChanged += new System.EventHandler(this.CbbMajorid_SelectedIndexChanged);
            // 
            // txbid
            // 
            this.txbid.Location = new System.Drawing.Point(1105, 59);
            this.txbid.Name = "txbid";
            this.txbid.Size = new System.Drawing.Size(10, 20);
            this.txbid.TabIndex = 41;
            this.txbid.Visible = false;
            // 
            // tBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 633);
            this.Controls.Add(this.txbid);
            this.Controls.Add(this.cbbMajorid);
            this.Controls.Add(this.dtgvBill);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbCount);
            this.Controls.Add(this.txbDatesell);
            this.Controls.Add(this.txbDaterent);
            this.Controls.Add(this.txbBookname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.txbBillid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TBill_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbBillid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbCount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbDatesell;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbBookname;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbDaterent;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.ComboBox cbbMajorid;
        private System.Windows.Forms.TextBox txbid;
    }
}