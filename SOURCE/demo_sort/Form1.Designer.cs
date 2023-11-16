namespace demo_sort
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.lbl_sophantu = new System.Windows.Forms.Label();
            this.btn_Ngaunhien = new System.Windows.Forms.Button();
            this.btn_Taomang = new System.Windows.Forms.Button();
            this.lbl_nhapdulieu = new System.Windows.Forms.Label();
            this.grb_nhap = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Mofile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_shellsort = new System.Windows.Forms.RadioButton();
            this.btn_Docfile = new System.Windows.Forms.Button();
            this.rad_shakersort = new System.Windows.Forms.RadioButton();
            this.lbl_nhaptufile = new System.Windows.Forms.Label();
            this.txt_sophantu = new System.Windows.Forms.TextBox();
            this.lbl_nhapbangtay = new System.Windows.Forms.Label();
            this.lst_Code = new System.Windows.Forms.ListBox();
            this.grb_dieukhien = new System.Windows.Forms.GroupBox();
            this.rad_giam = new System.Windows.Forms.RadioButton();
            this.lbl_Toc_do = new System.Windows.Forms.Label();
            this.btn_Dung = new System.Windows.Forms.Button();
            this.rad_tang = new System.Windows.Forms.RadioButton();
            this.btn_Sapxep = new System.Windows.Forms.Button();
            this.Trb_Toc_do = new System.Windows.Forms.TrackBar();
            this.Tmr_Thay_doi_toc_do = new System.Windows.Forms.Timer(this.components);
            this.lbl_A = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Thong_tin = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Tip = new System.Windows.Forms.ToolTip(this.components);
            this.grb_xemcode = new System.Windows.Forms.GroupBox();
            this.Mui_ten_do_len = new System.Windows.Forms.Label();
            this.Mui_ten_xanh_xuong_2 = new System.Windows.Forms.Label();
            this.Mui_ten_xanh_xuong_1 = new System.Windows.Forms.Label();
            this.Mui_ten_xanh_len_1 = new System.Windows.Forms.Label();
            this.Mui_ten_xanh_len_2 = new System.Windows.Forms.Label();
            this.lbl_status_01 = new System.Windows.Forms.Label();
            this.lbl_status_02 = new System.Windows.Forms.Label();
            this.grb_nhap.SuspendLayout();
            this.grb_dieukhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Toc_do)).BeginInit();
            this.menu.SuspendLayout();
            this.grb_xemcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sophantu
            // 
            this.lbl_sophantu.AutoSize = true;
            this.lbl_sophantu.Location = new System.Drawing.Point(11, 68);
            this.lbl_sophantu.Name = "lbl_sophantu";
            this.lbl_sophantu.Size = new System.Drawing.Size(144, 16);
            this.lbl_sophantu.TabIndex = 4;
            this.lbl_sophantu.Text = "Số phần tử (Max=15):";
            // 
            // btn_Ngaunhien
            // 
            this.btn_Ngaunhien.AutoSize = true;
            this.btn_Ngaunhien.Enabled = false;
            this.btn_Ngaunhien.Location = new System.Drawing.Point(219, 112);
            this.btn_Ngaunhien.Name = "btn_Ngaunhien";
            this.btn_Ngaunhien.Size = new System.Drawing.Size(90, 26);
            this.btn_Ngaunhien.TabIndex = 3;
            this.btn_Ngaunhien.Text = "Ngẫu Nhiên";
            this.Tool_Tip.SetToolTip(this.btn_Ngaunhien, "Lấy giá trị ngẫu nhiên cho mảng đã tạo!");
            this.btn_Ngaunhien.UseVisualStyleBackColor = true;
            this.btn_Ngaunhien.Click += new System.EventHandler(this.btn_Ngaunhien_Click);
            // 
            // btn_Taomang
            // 
            this.btn_Taomang.AutoSize = true;
            this.btn_Taomang.Location = new System.Drawing.Point(286, 68);
            this.btn_Taomang.Name = "btn_Taomang";
            this.btn_Taomang.Size = new System.Drawing.Size(83, 26);
            this.btn_Taomang.TabIndex = 0;
            this.btn_Taomang.Text = "Tạo Mảng";
            this.Tool_Tip.SetToolTip(this.btn_Taomang, "Tạo mảng theo số phần tử đã nhập ở trên.");
            this.btn_Taomang.UseVisualStyleBackColor = true;
            this.btn_Taomang.Click += new System.EventHandler(this.btn_Taomang_Click);
            // 
            // lbl_nhapdulieu
            // 
            this.lbl_nhapdulieu.AutoSize = true;
            this.lbl_nhapdulieu.Location = new System.Drawing.Point(11, 112);
            this.lbl_nhapdulieu.Name = "lbl_nhapdulieu";
            this.lbl_nhapdulieu.Size = new System.Drawing.Size(121, 16);
            this.lbl_nhapdulieu.TabIndex = 5;
            this.lbl_nhapdulieu.Text = "Tạo giá trị dãy số:";
            // 
            // grb_nhap
            // 
            this.grb_nhap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grb_nhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grb_nhap.Controls.Add(this.label2);
            this.grb_nhap.Controls.Add(this.btn_Mofile);
            this.grb_nhap.Controls.Add(this.label1);
            this.grb_nhap.Controls.Add(this.rad_shellsort);
            this.grb_nhap.Controls.Add(this.btn_Docfile);
            this.grb_nhap.Controls.Add(this.rad_shakersort);
            this.grb_nhap.Controls.Add(this.lbl_nhaptufile);
            this.grb_nhap.Controls.Add(this.txt_sophantu);
            this.grb_nhap.Controls.Add(this.lbl_nhapbangtay);
            this.grb_nhap.Controls.Add(this.lbl_sophantu);
            this.grb_nhap.Controls.Add(this.lbl_nhapdulieu);
            this.grb_nhap.Controls.Add(this.btn_Ngaunhien);
            this.grb_nhap.Controls.Add(this.btn_Taomang);
            this.grb_nhap.Location = new System.Drawing.Point(12, 539);
            this.grb_nhap.Name = "grb_nhap";
            this.grb_nhap.Size = new System.Drawing.Size(398, 191);
            this.grb_nhap.TabIndex = 3;
            this.grb_nhap.TabStop = false;
            this.grb_nhap.Text = "Khởi tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 11;
            // 
            // btn_Mofile
            // 
            this.btn_Mofile.AutoSize = true;
            this.btn_Mofile.Location = new System.Drawing.Point(159, 23);
            this.btn_Mofile.Name = "btn_Mofile";
            this.btn_Mofile.Size = new System.Drawing.Size(84, 26);
            this.btn_Mofile.TabIndex = 10;
            this.btn_Mofile.Text = "Mở File";
            this.Tool_Tip.SetToolTip(this.btn_Mofile, "Mở file dữ liệu để tạo mảng, trong file có số phần tử và giá trị các phần tử.");
            this.btn_Mofile.UseVisualStyleBackColor = true;
            this.btn_Mofile.Click += new System.EventHandler(this.btn_Mofile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thuật toán:";
            // 
            // rad_shellsort
            // 
            this.rad_shellsort.AutoSize = true;
            this.rad_shellsort.Location = new System.Drawing.Point(276, 149);
            this.rad_shellsort.Name = "rad_shellsort";
            this.rad_shellsort.Size = new System.Drawing.Size(93, 20);
            this.rad_shellsort.TabIndex = 5;
            this.rad_shellsort.Text = "Shell  Sort";
            this.rad_shellsort.UseVisualStyleBackColor = true;
            this.rad_shellsort.CheckedChanged += new System.EventHandler(this.rad_shellsort_CheckedChanged);
            // 
            // btn_Docfile
            // 
            this.btn_Docfile.AutoSize = true;
            this.btn_Docfile.Location = new System.Drawing.Point(286, 23);
            this.btn_Docfile.Name = "btn_Docfile";
            this.btn_Docfile.Size = new System.Drawing.Size(84, 26);
            this.btn_Docfile.TabIndex = 0;
            this.btn_Docfile.Text = "Đọc File";
            this.Tool_Tip.SetToolTip(this.btn_Docfile, "Đọc dữ liệu từ file để tạo mảng, trong file có số phần tử và giá trị các phần tử." +
        "");
            this.btn_Docfile.UseVisualStyleBackColor = true;
            this.btn_Docfile.Click += new System.EventHandler(this.btn_Docfile_Click);
            // 
            // rad_shakersort
            // 
            this.rad_shakersort.AutoSize = true;
            this.rad_shakersort.Location = new System.Drawing.Point(140, 149);
            this.rad_shakersort.Name = "rad_shakersort";
            this.rad_shakersort.Size = new System.Drawing.Size(103, 20);
            this.rad_shakersort.TabIndex = 3;
            this.rad_shakersort.Text = "Shaker Sort";
            this.rad_shakersort.UseVisualStyleBackColor = true;
            this.rad_shakersort.CheckedChanged += new System.EventHandler(this.rad_shakersort_CheckedChanged);
            // 
            // lbl_nhaptufile
            // 
            this.lbl_nhaptufile.AutoSize = true;
            this.lbl_nhaptufile.Location = new System.Drawing.Point(11, 30);
            this.lbl_nhaptufile.Name = "lbl_nhaptufile";
            this.lbl_nhaptufile.Size = new System.Drawing.Size(114, 16);
            this.lbl_nhaptufile.TabIndex = 8;
            this.lbl_nhaptufile.Text = "Tạo mảng từ file:";
            // 
            // txt_sophantu
            // 
            this.txt_sophantu.Location = new System.Drawing.Point(159, 68);
            this.txt_sophantu.Name = "txt_sophantu";
            this.txt_sophantu.Size = new System.Drawing.Size(82, 23);
            this.txt_sophantu.TabIndex = 0;
            this.txt_sophantu.Text = "8";
            this.txt_sophantu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tool_Tip.SetToolTip(this.txt_sophantu, "Nhập vào số phần tử cần tạo( Spt <= 30).");
            // 
            // lbl_nhapbangtay
            // 
            this.lbl_nhapbangtay.AutoSize = true;
            this.lbl_nhapbangtay.Location = new System.Drawing.Point(5, 130);
            this.lbl_nhapbangtay.Name = "lbl_nhapbangtay";
            this.lbl_nhapbangtay.Size = new System.Drawing.Size(0, 16);
            this.lbl_nhapbangtay.TabIndex = 6;
            // 
            // lst_Code
            // 
            this.lst_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_Code.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Code.FormattingEnabled = true;
            this.lst_Code.ItemHeight = 19;
            this.lst_Code.Location = new System.Drawing.Point(6, 18);
            this.lst_Code.Name = "lst_Code";
            this.lst_Code.Size = new System.Drawing.Size(377, 173);
            this.lst_Code.TabIndex = 0;
            // 
            // grb_dieukhien
            // 
            this.grb_dieukhien.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grb_dieukhien.Controls.Add(this.rad_giam);
            this.grb_dieukhien.Controls.Add(this.lbl_Toc_do);
            this.grb_dieukhien.Controls.Add(this.btn_Dung);
            this.grb_dieukhien.Controls.Add(this.rad_tang);
            this.grb_dieukhien.Controls.Add(this.btn_Sapxep);
            this.grb_dieukhien.Controls.Add(this.Trb_Toc_do);
            this.grb_dieukhien.Location = new System.Drawing.Point(805, 539);
            this.grb_dieukhien.Name = "grb_dieukhien";
            this.grb_dieukhien.Size = new System.Drawing.Size(189, 191);
            this.grb_dieukhien.TabIndex = 6;
            this.grb_dieukhien.TabStop = false;
            this.grb_dieukhien.Text = "Điều khiển";
            // 
            // rad_giam
            // 
            this.rad_giam.AutoSize = true;
            this.rad_giam.Location = new System.Drawing.Point(21, 64);
            this.rad_giam.Name = "rad_giam";
            this.rad_giam.Size = new System.Drawing.Size(89, 20);
            this.rad_giam.TabIndex = 6;
            this.rad_giam.Text = "Giảm dần";
            this.rad_giam.UseVisualStyleBackColor = true;
            // 
            // lbl_Toc_do
            // 
            this.lbl_Toc_do.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Toc_do.Location = new System.Drawing.Point(110, 19);
            this.lbl_Toc_do.Name = "lbl_Toc_do";
            this.lbl_Toc_do.Size = new System.Drawing.Size(67, 31);
            this.lbl_Toc_do.TabIndex = 4;
            this.lbl_Toc_do.Text = "10";
            this.lbl_Toc_do.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Dung
            // 
            this.btn_Dung.AutoSize = true;
            this.btn_Dung.Enabled = false;
            this.btn_Dung.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Dung.Location = new System.Drawing.Point(21, 149);
            this.btn_Dung.Name = "btn_Dung";
            this.btn_Dung.Size = new System.Drawing.Size(84, 36);
            this.btn_Dung.TabIndex = 1;
            this.btn_Dung.Text = ";";
            this.Tool_Tip.SetToolTip(this.btn_Dung, "Tạm dừng/Tiếp tục.");
            this.btn_Dung.UseVisualStyleBackColor = true;
            this.btn_Dung.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // rad_tang
            // 
            this.rad_tang.AutoSize = true;
            this.rad_tang.Location = new System.Drawing.Point(21, 30);
            this.rad_tang.Name = "rad_tang";
            this.rad_tang.Size = new System.Drawing.Size(89, 20);
            this.rad_tang.TabIndex = 5;
            this.rad_tang.Text = "Tăng dần";
            this.rad_tang.UseVisualStyleBackColor = true;
            // 
            // btn_Sapxep
            // 
            this.btn_Sapxep.AutoSize = true;
            this.btn_Sapxep.Enabled = false;
            this.btn_Sapxep.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sapxep.Location = new System.Drawing.Point(21, 102);
            this.btn_Sapxep.Name = "btn_Sapxep";
            this.btn_Sapxep.Size = new System.Drawing.Size(84, 36);
            this.btn_Sapxep.TabIndex = 0;
            this.btn_Sapxep.Text = "&Sắp xếp";
            this.Tool_Tip.SetToolTip(this.btn_Sapxep, "Sắp xếp mảng");
            this.btn_Sapxep.UseVisualStyleBackColor = true;
            this.btn_Sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // Trb_Toc_do
            // 
            this.Trb_Toc_do.Location = new System.Drawing.Point(121, 41);
            this.Trb_Toc_do.Name = "Trb_Toc_do";
            this.Trb_Toc_do.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Trb_Toc_do.Size = new System.Drawing.Size(56, 141);
            this.Trb_Toc_do.TabIndex = 3;
            this.Trb_Toc_do.TickFrequency = 2;
            this.Trb_Toc_do.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Tool_Tip.SetToolTip(this.Trb_Toc_do, "Kéo để thay đổi tốc độ sắp xếp.");
            this.Trb_Toc_do.Value = 5;
            // 
            // Tmr_Thay_doi_toc_do
            // 
            this.Tmr_Thay_doi_toc_do.Enabled = true;
            this.Tmr_Thay_doi_toc_do.Interval = 1;
            this.Tmr_Thay_doi_toc_do.Tick += new System.EventHandler(this.Tmr_Thay_doi_toc_do_Tick);
            // 
            // lbl_A
            // 
            this.lbl_A.BackColor = System.Drawing.Color.Transparent;
            this.lbl_A.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A.ForeColor = System.Drawing.Color.Black;
            this.lbl_A.Location = new System.Drawing.Point(40, 314);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(55, 57);
            this.lbl_A.TabIndex = 14;
            this.lbl_A.Text = "a:";
            this.lbl_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_A.Visible = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Thong_tin,
            this.menu_Thoat});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(994, 28);
            this.menu.TabIndex = 22;
            // 
            // Menu_Thong_tin
            // 
            this.Menu_Thong_tin.Name = "Menu_Thong_tin";
            this.Menu_Thong_tin.Size = new System.Drawing.Size(89, 24);
            this.Menu_Thong_tin.Text = "Thông Tin";
            this.Menu_Thong_tin.Click += new System.EventHandler(this.Menu_Thong_tin_Click);
            // 
            // menu_Thoat
            // 
            this.menu_Thoat.Name = "menu_Thoat";
            this.menu_Thoat.Size = new System.Drawing.Size(61, 24);
            this.menu_Thoat.Text = "Thoát";
            this.menu_Thoat.Click += new System.EventHandler(this.menu_Thoat_Click);
            // 
            // grb_xemcode
            // 
            this.grb_xemcode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grb_xemcode.Controls.Add(this.lst_Code);
            this.grb_xemcode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_xemcode.Location = new System.Drawing.Point(410, 539);
            this.grb_xemcode.Name = "grb_xemcode";
            this.grb_xemcode.Size = new System.Drawing.Size(389, 191);
            this.grb_xemcode.TabIndex = 5;
            this.grb_xemcode.TabStop = false;
            this.grb_xemcode.Text = "Code C/C++";
            // 
            // Mui_ten_do_len
            // 
            this.Mui_ten_do_len.BackColor = System.Drawing.Color.Transparent;
            this.Mui_ten_do_len.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mui_ten_do_len.ForeColor = System.Drawing.Color.White;
            this.Mui_ten_do_len.Image = ((System.Drawing.Image)(resources.GetObject("Mui_ten_do_len.Image")));
            this.Mui_ten_do_len.Location = new System.Drawing.Point(823, 393);
            this.Mui_ten_do_len.Name = "Mui_ten_do_len";
            this.Mui_ten_do_len.Size = new System.Drawing.Size(60, 50);
            this.Mui_ten_do_len.TabIndex = 21;
            this.Mui_ten_do_len.Text = "R";
            this.Mui_ten_do_len.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mui_ten_do_len.Visible = false;
            // 
            // Mui_ten_xanh_xuong_2
            // 
            this.Mui_ten_xanh_xuong_2.BackColor = System.Drawing.Color.Transparent;
            this.Mui_ten_xanh_xuong_2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mui_ten_xanh_xuong_2.Image = ((System.Drawing.Image)(resources.GetObject("Mui_ten_xanh_xuong_2.Image")));
            this.Mui_ten_xanh_xuong_2.Location = new System.Drawing.Point(735, 393);
            this.Mui_ten_xanh_xuong_2.Name = "Mui_ten_xanh_xuong_2";
            this.Mui_ten_xanh_xuong_2.Size = new System.Drawing.Size(60, 50);
            this.Mui_ten_xanh_xuong_2.TabIndex = 19;
            this.Mui_ten_xanh_xuong_2.Text = "y2";
            this.Mui_ten_xanh_xuong_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mui_ten_xanh_xuong_2.Visible = false;
            // 
            // Mui_ten_xanh_xuong_1
            // 
            this.Mui_ten_xanh_xuong_1.BackColor = System.Drawing.Color.Transparent;
            this.Mui_ten_xanh_xuong_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mui_ten_xanh_xuong_1.Image = ((System.Drawing.Image)(resources.GetObject("Mui_ten_xanh_xuong_1.Image")));
            this.Mui_ten_xanh_xuong_1.Location = new System.Drawing.Point(650, 393);
            this.Mui_ten_xanh_xuong_1.Name = "Mui_ten_xanh_xuong_1";
            this.Mui_ten_xanh_xuong_1.Size = new System.Drawing.Size(60, 50);
            this.Mui_ten_xanh_xuong_1.TabIndex = 20;
            this.Mui_ten_xanh_xuong_1.Text = "y1";
            this.Mui_ten_xanh_xuong_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mui_ten_xanh_xuong_1.Visible = false;
            // 
            // Mui_ten_xanh_len_1
            // 
            this.Mui_ten_xanh_len_1.BackColor = System.Drawing.Color.Transparent;
            this.Mui_ten_xanh_len_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mui_ten_xanh_len_1.ForeColor = System.Drawing.Color.Black;
            this.Mui_ten_xanh_len_1.Image = ((System.Drawing.Image)(resources.GetObject("Mui_ten_xanh_len_1.Image")));
            this.Mui_ten_xanh_len_1.Location = new System.Drawing.Point(488, 393);
            this.Mui_ten_xanh_len_1.Name = "Mui_ten_xanh_len_1";
            this.Mui_ten_xanh_len_1.Size = new System.Drawing.Size(60, 50);
            this.Mui_ten_xanh_len_1.TabIndex = 18;
            this.Mui_ten_xanh_len_1.Text = "x1";
            this.Mui_ten_xanh_len_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mui_ten_xanh_len_1.Visible = false;
            // 
            // Mui_ten_xanh_len_2
            // 
            this.Mui_ten_xanh_len_2.BackColor = System.Drawing.Color.Transparent;
            this.Mui_ten_xanh_len_2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mui_ten_xanh_len_2.ForeColor = System.Drawing.Color.Black;
            this.Mui_ten_xanh_len_2.Image = ((System.Drawing.Image)(resources.GetObject("Mui_ten_xanh_len_2.Image")));
            this.Mui_ten_xanh_len_2.Location = new System.Drawing.Point(567, 393);
            this.Mui_ten_xanh_len_2.Name = "Mui_ten_xanh_len_2";
            this.Mui_ten_xanh_len_2.Size = new System.Drawing.Size(60, 50);
            this.Mui_ten_xanh_len_2.TabIndex = 17;
            this.Mui_ten_xanh_len_2.Text = "x2";
            this.Mui_ten_xanh_len_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mui_ten_xanh_len_2.Visible = false;
            // 
            // lbl_status_01
            // 
            this.lbl_status_01.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status_01.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_01.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_status_01.Location = new System.Drawing.Point(12, 37);
            this.lbl_status_01.Name = "lbl_status_01";
            this.lbl_status_01.Size = new System.Drawing.Size(309, 39);
            this.lbl_status_01.TabIndex = 7;
            this.lbl_status_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_status_01.Visible = false;
            // 
            // lbl_status_02
            // 
            this.lbl_status_02.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status_02.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_02.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_status_02.Location = new System.Drawing.Point(327, 37);
            this.lbl_status_02.Name = "lbl_status_02";
            this.lbl_status_02.Size = new System.Drawing.Size(355, 39);
            this.lbl_status_02.TabIndex = 23;
            this.lbl_status_02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_status_02.Visible = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(994, 790);
            this.Controls.Add(this.lbl_status_02);
            this.Controls.Add(this.Mui_ten_do_len);
            this.Controls.Add(this.Mui_ten_xanh_xuong_2);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.grb_dieukhien);
            this.Controls.Add(this.grb_xemcode);
            this.Controls.Add(this.lbl_status_01);
            this.Controls.Add(this.grb_nhap);
            this.Controls.Add(this.Mui_ten_xanh_xuong_1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.Mui_ten_xanh_len_1);
            this.Controls.Add(this.Mui_ten_xanh_len_2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "Chương trình sẵp xếp dãy số bất kỳ";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.grb_nhap.ResumeLayout(false);
            this.grb_nhap.PerformLayout();
            this.grb_dieukhien.ResumeLayout(false);
            this.grb_dieukhien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Toc_do)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.grb_xemcode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Taomang;
        private System.Windows.Forms.Button btn_Ngaunhien;
        private System.Windows.Forms.Label lbl_sophantu;
        private System.Windows.Forms.Label lbl_nhapdulieu;
        private System.Windows.Forms.Label lbl_nhapbangtay;
        private System.Windows.Forms.TextBox txt_sophantu;
        protected System.Windows.Forms.GroupBox grb_nhap;
        private System.Windows.Forms.RadioButton rad_shellsort;
        private System.Windows.Forms.RadioButton rad_shakersort;
        private System.Windows.Forms.GroupBox grb_dieukhien;
        private System.Windows.Forms.Button btn_Sapxep;
        private System.Windows.Forms.Timer Tmr_Thay_doi_toc_do;
        private System.Windows.Forms.TrackBar Trb_Toc_do;
        private System.Windows.Forms.Button btn_Docfile;
        private System.Windows.Forms.Label lbl_nhaptufile;
        private System.Windows.Forms.Button btn_Dung;
        private System.Windows.Forms.Label lbl_Toc_do;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label Mui_ten_xanh_len_2;
        private System.Windows.Forms.Label Mui_ten_xanh_len_1;
        private System.Windows.Forms.Label Mui_ten_xanh_xuong_2;
        private System.Windows.Forms.Label Mui_ten_xanh_xuong_1;
        private System.Windows.Forms.Label Mui_ten_do_len;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Thong_tin;
        private System.Windows.Forms.ToolStripMenuItem menu_Thoat;
        private System.Windows.Forms.ToolTip Tool_Tip;
        private System.Windows.Forms.ListBox lst_Code;
        private System.Windows.Forms.GroupBox grb_xemcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_giam;
        private System.Windows.Forms.RadioButton rad_tang;
        private System.Windows.Forms.Label lbl_status_01;
        private System.Windows.Forms.Label lbl_status_02;
        private System.Windows.Forms.Button btn_Mofile;
        private System.Windows.Forms.Label label2;
    }
}

