using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Diagnostics;

namespace demo_sort
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            //Tải code của thuật toán Shaker Sort vào Cửa sổ xem code
            lst_Code.Items.Add("void ShakerSort(int a[], int n)");
            lst_Code.Items.Add("  {");
            lst_Code.Items.Add("        int i;");
            lst_Code.Items.Add("        int left, right, k;");
            lst_Code.Items.Add("        left = 0; right = n-1; k = n-1;");
            lst_Code.Items.Add("           while (left < right)");
            lst_Code.Items.Add("             {");
            lst_Code.Items.Add("               for (i = right; i > left; i--)");
            lst_Code.Items.Add("                   if (a[i]< a[i-1]) ");
            lst_Code.Items.Add("                     {");
            lst_Code.Items.Add("	                    Swap(a[i], a[i-1]);");
            lst_Code.Items.Add("	                    k = i;");
            lst_Code.Items.Add("                     }");
            lst_Code.Items.Add("                   left = k;");
            lst_Code.Items.Add("               for (i = left; i < right; i++)");
            lst_Code.Items.Add("                   if (a[i] > a[i + 1]) ");
            lst_Code.Items.Add("                     {");
            lst_Code.Items.Add("                       Swap(a[i], a[i + 1]);");
            lst_Code.Items.Add("                       k = i; ");
            lst_Code.Items.Add("                     }");
            lst_Code.Items.Add("                  right = k;");
            lst_Code.Items.Add("            }");
            lst_Code.Items.Add("  }");

        }

        #region Khai báo các biến toàn cục
        TextBox[] Node;
        int[] a, h;
        int Spt = 0;
        Label[] Chi_so;
        int Toc_do;
        int i;
        Boolean Da_tao_mang, KT_tam_dung = false; //Biến kiểm tra đã tạo mảng và kiểm tra tạm dừng
        //Biến kiểm tra sắp xếp 1 lần hay từng bước
        Boolean Sap_xep_tung_buoc;

        #endregion
        #region Khai báo các biến định dạng node
        int Khoang_cach;//khoảng cách 2 node liên tiếp
        int Canh_le;//canh lề node
        int Kich_thuoc; // kích thước node
        int Co_chu; //kích thước chữ
        #endregion Khai báo các biến định dạng node
        #region Các hàm di chuyển node
        // Hàm swap 2 node có thể hiện
        public void Hoan_Vi_Node(Control t1, Control t2)
        {
            Application.DoEvents();

            this.Invoke((MethodInvoker)delegate
            {
                Point p1 = t1.Location; //lưu vị trí ban đầu của t1
                Point p2 = t2.Location; //lưu vị trí ban đầu của t2
                if (p1 != p2)
                {
                    // t1 lên, t2 xuống
                    while ((t1.Location.Y > p1.Y - (Kich_thuoc + 5)) || (t2.Location.Y < p2.Y + (Kich_thuoc + 5)))
                    {
                        Application.DoEvents();
                        t1.Top -= 1;
                        t2.Top += 1;
                        Tre(Toc_do);

                    }
                    // t1 dịch phải, t2 dịch trái
                    if (t1.Location.X < t2.Location.X)
                    {

                        while ((t1.Location.X < p2.X) || (t2.Location.X > p1.X))
                        {
                            Application.DoEvents();
                            t1.Left += 1;
                            t2.Left -= 1;
                            Tre(Toc_do);


                        }

                    }
                    // t1 dịch trái, t2 dịch phải
                    else
                    {

                        while ((t1.Location.X > p2.X) || (t2.Location.X < p1.X))
                        {
                            Application.DoEvents();
                            t1.Left -= 1;
                            t2.Left += 1;
                            Tre(Toc_do);

                        }

                    }
                    // t1 xuống, t2 lên
                    while ((t1.Location.Y < p2.Y) || (t2.Location.Y > p1.Y))
                    {
                        Application.DoEvents();
                        t1.Top += 1;
                        t2.Top -= 1;
                        Tre(Toc_do);

                    }
                    t1.Refresh();
                    t2.Refresh();
                }
            });

        }
        // t dịch chuyển sang Phải Step Node
        public void Node_qua_phai(Control t, int Step)
        {
            Application.DoEvents();

            this.Invoke((MethodInvoker)delegate
            {
                int Loop_Count = ((Kich_thuoc + Khoang_cach)) * Step; //Số lần dịch chuyển
                {
                    while (Loop_Count > 0)
                    {
                        Application.DoEvents();
                        t.Left += 1;
                        Tre(Toc_do);
                        Loop_Count--;
                    }
                }
                t.Refresh();
            });
        }
        // t dịch chuyển sang trai Step Node
        public void Node_qua_trai(Control t, int Step)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                int Loop_Count = ((Kich_thuoc + Khoang_cach)) * Step; //Số lần dịch chuyển
                while (Loop_Count > 0)
                {
                    Application.DoEvents();
                    t.Left -= 1;
                    Tre(Toc_do);
                    Loop_Count--;
                }
                t.Refresh();
            });
        }
        // t dịch chuyển lên với quãng đường S
        public void Node_di_len(Control t, int S)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                int loop_Count = S;
                //t xuống
                while (loop_Count > 0)
                {
                    Application.DoEvents();
                    t.Top -= 1;
                    Tre(Toc_do);
                    loop_Count--;
                }
                t.Refresh();
            });
        }
        // t dịch chuyển xuống với quãng đường S
        public void Node_di_xuong(Control t, int S)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                int loop_Count = S;
                // t lên
                while (loop_Count > 0)
                {
                    Application.DoEvents();
                    t.Top += 1;
                    Tre(Toc_do);
                    loop_Count--;
                }
                t.Refresh();
            });
        }

       
       
        #endregion
        #region Các hàm khác
        //Hàm ngủ
        public void SleepP(int milisecond)
        {
            int i;
            for (i = 0; i < milisecond; i++)
            {
                Application.DoEvents();
                Thread.Sleep(5);
            }
            Application.DoEvents();
        }
        //Hàm Trễ
        public void Tre(int milisecond)
        {
            //Nếu tốc độ max thì ko sleep
            if (Trb_Toc_do.Value == Trb_Toc_do.Maximum)
            {
                Application.DoEvents();
                return;
            }

            SleepP(milisecond);
        }
        // Hàm hoán vị 2 node mà không thể hiện
        public void Hoan_Tri_Node(int t1, int t2)
        {
            TextBox Temp = Node[t1];
            Node[t1] = Node[t2];
            Node[t2] = Temp;
        }
        // Hàm hoán vị 2 giá trị
        public void Hoan_vi(ref int i, ref int j)
        {
            int Temp = i;
            i = j;
            j = Temp;

        }

        //Sắp xếp hoàn thành
        public void Hoan_thanh()
        {
            for (i = 0; i < Spt; i++)
            {
                Dat_mau_node(Node[i], Color.LawnGreen, Color.Black);
            }
            //Ẩn các index

            Mui_ten_xanh_xuong_1.Visible = false;
            Mui_ten_xanh_xuong_2.Visible = false;
            Mui_ten_xanh_len_1.Visible = false;
            Mui_ten_xanh_len_2.Visible = false;
            Mui_ten_do_len.Visible = false;
            //
            lbl_status_02.Visible = true;
            lbl_status_02.Text = "Đã sắp xếp xong!";
            btn_Ngaunhien.Enabled = false;

            btn_Dung.Enabled = false;

            //Thiết lập các nút nhập liệu

            rad_shakersort.Enabled = true;
            rad_shellsort.Enabled = true;

            btn_Docfile.Enabled = true;
            btn_Mofile.Enabled = false;
            btn_Taomang.Enabled = true;
            btn_Ngaunhien.Enabled = true;

        }
        //Hàm tạo mảng
        public void Tao_mang()
        {
            if ((Spt < 2) || (Spt > 30))
            {
                lbl_A.Visible = false;
                MessageBox.Show("2 <= Số Phần Tử <= 30");

                this.txt_sophantu.Clear();
                Da_tao_mang = false;
                return;
            }

            #region Thiết lập thuộc tính node ứng với số phần tử
            switch (Spt)
            {
                
                case 15:
                case 14:
                case 13:
                case 12:
                case 11:
                    Kich_thuoc = 40;
                    Co_chu = 17;
                    Khoang_cach = 18;
                    Canh_le = (1024 - Kich_thuoc * Spt - Khoang_cach * (Spt - 1)) / 2;
                    break;
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                    Kich_thuoc = 50;
                    Co_chu = 23;
                    Khoang_cach = 40;
                    Canh_le = (1024 - Kich_thuoc * Spt - Khoang_cach * (Spt - 1)) / 2;
                    break;
            }
            #endregion
            #region Tạo các mảng dữ liệu
            Chi_so = new Label[Spt];
            a = new int[Spt];
            Node = new TextBox[Spt];
            #endregion
            //Dán nhãn mảng a
            lbl_A.Width = Kich_thuoc;
            lbl_A.Height = Kich_thuoc;
            lbl_A.Location = new Point(Canh_le - (Kich_thuoc), 250);
            lbl_A.Font = new System.Drawing.Font("Arial", Co_chu, FontStyle.Bold);
            lbl_A.Visible = true;
            #region Tạo node và chỉ số
            for (i = 0; i < Spt; i++)
            {
                //node
                a[i] = i;
                Node[i] = new TextBox();
                Node[i].Multiline = true;
                Node[i].Text = a[i].ToString();
                Node[i].TextAlign = HorizontalAlignment.Center;
                Node[i].Width = (Kich_thuoc+5);
                Node[i].Height = (Kich_thuoc-5);
                Node[i].Location = new Point(Canh_le + (Kich_thuoc + Khoang_cach) * i, 250);
                Node[i].BackColor = Color.Red;
                Node[i].ForeColor = Color.White;
                Node[i].Font = new Font(this.Font, FontStyle.Bold);
                Node[i].Font = new System.Drawing.Font("Arial", Co_chu, FontStyle.Bold);
                Node[i].ReadOnly = true;
                this.Controls.Add(Node[i]);
                //chỉ số
                Chi_so[i] = new Label();
                Chi_so[i].TextAlign = ContentAlignment.MiddleCenter;
                Chi_so[i].Text = i.ToString();
                Chi_so[i].Width = Kich_thuoc;
                Chi_so[i].Height = Kich_thuoc;
                Chi_so[i].ForeColor = Color.Indigo;
                Chi_so[i].Location = new Point(Canh_le + (Kich_thuoc + Khoang_cach) * i, 340 + 3 * Kich_thuoc);
                if (Spt <= 10)
                {
                    Chi_so[i].Font = new System.Drawing.Font("Arial", Co_chu - 10, FontStyle.Regular);
                }
                else
                {
                    Chi_so[i].Font = new System.Drawing.Font("Arial", Co_chu, FontStyle.Regular);
                }
                this.Controls.Add(Chi_so[i]);
                Da_tao_mang = true; //Xác nhận đã tạo mảng
                //Cho phép các nút điều khiển có tác dụng khi đã tạo mảng
                btn_Mofile.Enabled = true;
                btn_Docfile.Enabled = true;
                btn_Sapxep.Enabled = true;
                btn_Ngaunhien.Enabled = true;
                

            }
            #endregion
        }
        //Hàm xóa mảng
        public void Xoa_mang()
        {
            btn_Ngaunhien.Enabled = false;
            btn_Sapxep.Enabled = false;
            if (Da_tao_mang == true)
            {
                for (i = 0; i < Spt; i++)
                {
                    this.Controls.Remove(Node[i]);
                    this.Controls.Remove(Chi_so[i]);

                }
            }
        }
        //Hàm dừng toàn bộ chương trình
        public void Play_or_Stop()
        {
            while (KT_tam_dung == true)
            {
                Application.DoEvents();
            }
        }
        //Hàm Tạm dừng
        public void Tam_dung()
        {
            if (Sap_xep_tung_buoc == true)
            {
                KT_tam_dung = true;
                btn_Dung.Enabled = false;
                Play_or_Stop();
            }

        }
        //Hàm đặt màu cho Node
        public void Dat_mau_node(Control t, System.Drawing.Color Mau_nen, System.Drawing.Color Mau_chu)
        {
            t.BackColor = Mau_nen;
            t.ForeColor = Mau_chu;
            t.Refresh();
        }
        #endregion       
        #region Các phương thức nhập dữ liệu

        //Nhập ngẫu nhiên
        private void btn_Ngaunhien_Click(object sender, EventArgs e)
        {
            lbl_status_02.Visible = false;
            btn_Sapxep.Enabled = true;
            Random r = new Random();
            for (i = 0; i < Spt; i++)
            {
                Node[i].BackColor = Color.Red; // đặt lại màu cho mảng ngẫu nhiên
                Node[i].ForeColor = Color.White;
                a[i] = r.Next(100);
                Node[i].Text = a[i].ToString();
            }
        }

        //Nhập từ file
        private void btn_Mofile_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "NotePad.exe";
            ps.Arguments = "D:\\TTCS\\SOURCE\\demo_sort\\bin\\Debug\\TEST.txt";
            p.StartInfo = ps;
            p.Start();
        }
        private void btn_Docfile_Click(object sender, EventArgs e)
        {
            lbl_status_02.Visible = false;
            //Gọi hàm xóa mảng
            Xoa_mang();
            //Đọc file
            StreamReader Re = File.OpenText("D:\\TTCS\\SOURCE\\demo_sort\\bin\\Debug\\TEST.txt");
            string input = null;
            int i = 0;
            int kt = 0;
            while ((kt < 1) && ((input = Re.ReadLine()) != null))
            {
                Spt = Convert.ToInt32(input);
                kt++;
            }
            //Gọi hàm tạo mảng
            Tao_mang();
            while (((input = Re.ReadLine()) != null) && (i < Spt))
            {

                Node[i].BackColor = Color.Red; // đặt lại màu cho mảng ngẫu nhiên
                Node[i].ForeColor = Color.White;
                a[i] = Convert.ToInt32(input);
                Node[i].Text = a[i].ToString();
                i++;
            }
            Re.Close();
        }
        

        #endregion
        #region Các hàm sắp xếp

        #region SHAKER SORT
        void ShakerSort_tang()
        {
            int i;
            int left, right, k;
            left = 0; right = Spt - 1; k = Spt - 1;
            //Thiết lập mũi tên chỉ left
            Mui_ten_xanh_len_1.Visible = true;
            Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * left) + (Kich_thuoc / 2) - 30, Node[left].Location.Y + 2 * Kich_thuoc + 5);
            Mui_ten_xanh_len_1.Text = "L = " + left;
            Mui_ten_xanh_len_1.Refresh();
            //Thiết lập mũi tên chỉ right
            Mui_ten_xanh_len_2.Visible = true;
            Mui_ten_xanh_len_2.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * right) + (Kich_thuoc / 2) - 30, Node[right].Location.Y + 2 * Kich_thuoc + 5);
            Mui_ten_xanh_len_2.Text = "R = " + right;
            Mui_ten_xanh_len_2.Refresh();
            //Thiết lập vị trí của k
            Mui_ten_do_len.Visible = true;
            Mui_ten_do_len.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 65);
            Mui_ten_do_len.Text = "K=" + k;
            Mui_ten_do_len.Refresh();
            //
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                while (left < right)
                {
                    lst_Code.SelectedIndex = 5;
                    Tre(40 * Toc_do);
                    Application.DoEvents();
                    for (i = right; i > left; i--)
                    {
                        lst_Code.SelectedIndex = 7;
                        Tre(40 * Toc_do);
                        //Thiết lập mũi tên chỉ i
                        Mui_ten_xanh_xuong_1.Visible = true;
                        Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 55);
                        Mui_ten_xanh_xuong_1.Text = "i=" + i;
                        Mui_ten_xanh_xuong_1.Refresh();
                        Dat_mau_node(Node[i], Color.Yellow, Color.Black);
                        Application.DoEvents();
                        lst_Code.SelectedIndex = 8;
                        Tre(40 * Toc_do);
                        if (a[i] < a[i - 1])
                        {
                            lst_Code.SelectedIndex = 10;
                            Tre(40 * Toc_do);
                            Hoan_vi(ref a[i], ref a[i - 1]);
                            this.Invoke((MethodInvoker)delegate
                            {
                                Hoan_Vi_Node(Node[i], Node[i - 1]);
                            });
                            Tam_dung();
                            Hoan_Tri_Node(i, i - 1);
                            lst_Code.SelectedIndex = 11;

                            k = i;
                            //Thiết lập vị trí của k
                            Mui_ten_do_len.Visible = true;
                            Mui_ten_do_len.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 65);
                            Mui_ten_do_len.Text = "K=" + k;
                            Mui_ten_do_len.Refresh();
                            Tre(50 * Toc_do);
                        }

                    }
                    
                    //Thiết lập Node đã có thứ tự

                    for (i = 0; i < k; i++)
                    {
                        Dat_mau_node(Node[i], Color.LawnGreen, Color.Black);
                        Tre(50 * Toc_do);
                    }
                    left = k;
                    lst_Code.SelectedIndex = 14;
                    //Thiết lập mũi tên chỉ left

                    Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 5);
                    Mui_ten_xanh_len_1.Text = "L = " + left;
                    Mui_ten_xanh_len_1.Refresh();
                    //
                    Tre(40 * Toc_do);
                    for (i = left; i < right; i++)
                    {
                        //Thiết lập mũi tên chỉ i
                        Mui_ten_xanh_xuong_1.Visible = true;
                        Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 55);
                        Mui_ten_xanh_xuong_1.Text = "i=" + i;
                        Mui_ten_xanh_xuong_1.Refresh();
                        Dat_mau_node(Node[i], Color.Yellow, Color.Black);
                        Application.DoEvents();
                        lst_Code.SelectedIndex = 15;
                        Tre(40 * Toc_do);
                        if (a[i] > a[i + 1])
                        {
                            lst_Code.SelectedIndex = 17;
                            Tre(40 * Toc_do);
                            Hoan_vi(ref a[i], ref a[i + 1]);
                            this.Invoke((MethodInvoker)delegate
                            {
                                Hoan_Vi_Node(Node[i], Node[i + 1]);
                            });
                            Tam_dung();
                            Hoan_Tri_Node(i, i + 1);
                            lst_Code.SelectedIndex = 18;

                            k = i;
                            //Thiết lập vị trí của k
                            Mui_ten_do_len.Visible = true;
                            Mui_ten_do_len.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 65);
                            Mui_ten_do_len.Text = "K=" + k;
                            Mui_ten_do_len.Refresh();
                            Tre(50 * Toc_do);
                        }

                    }
                    
                    //Thiết lập Node đã có thứ tự
                    for (i = Spt - 1; i > k; i--)
                    {
                        Dat_mau_node(Node[i], Color.LawnGreen, Color.Black);
                        Tre(50 * Toc_do);
                    }
                    //                         
                    right = k;
                    //Thiết lập mũi tên chỉ right

                    Mui_ten_xanh_len_2.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 5);
                    Mui_ten_xanh_len_2.Text = "R = " + right;
                    Mui_ten_xanh_len_2.Refresh();
                    //
                }

            });
            //sắp xếp hoàn thành
            Hoan_thanh();
        }
        void ShakerSort_giam()
        {
            int i;
            int left, right, k;
            left = 0; right = Spt - 1; k = Spt - 1;
            //Thiết lập mũi tên chỉ left
            Mui_ten_xanh_len_1.Visible = true;
            Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * left) + (Kich_thuoc / 2) - 30, Node[left].Location.Y + 2 * Kich_thuoc + 5);
            Mui_ten_xanh_len_1.Text = "L = " + left;
            Mui_ten_xanh_len_1.Refresh();
            //Thiết lập mũi tên chỉ right
            Mui_ten_xanh_len_2.Visible = true;
            Mui_ten_xanh_len_2.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * right) + (Kich_thuoc / 2) - 30, Node[right].Location.Y + 2 * Kich_thuoc + 5);
            Mui_ten_xanh_len_2.Text = "R = " + right;
            Mui_ten_xanh_len_2.Refresh();
            //Thiết lập vị trí của k
            Mui_ten_do_len.Visible = true;
            Mui_ten_do_len.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 65);
            Mui_ten_do_len.Text = "K=" + k;
            Mui_ten_do_len.Refresh();
            //
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                while (left < right)
                {
                    lst_Code.SelectedIndex = 5;
                    Tre(40 * Toc_do);
                    Application.DoEvents();
                    for (i = right; i > left; i--)
                    {
                        lst_Code.SelectedIndex = 7;
                        Tre(40 * Toc_do);
                        //Thiết lập mũi tên chỉ i
                        Mui_ten_xanh_xuong_1.Visible = true;
                        Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 55);
                        Mui_ten_xanh_xuong_1.Text = "i=" + i;
                        Mui_ten_xanh_xuong_1.Refresh();
                        Dat_mau_node(Node[i], Color.Yellow, Color.Black);
                        Application.DoEvents();
                        lst_Code.SelectedIndex = 8;
                        Tre(40 * Toc_do);
                        if (a[i] > a[i - 1])
                        {
                            lst_Code.SelectedIndex = 10;
                            Tre(40 * Toc_do);
                            Hoan_vi(ref a[i], ref a[i - 1]);
                            this.Invoke((MethodInvoker)delegate
                            {
                                Hoan_Vi_Node(Node[i], Node[i - 1]);
                            });
                            Tam_dung();
                            Hoan_Tri_Node(i, i - 1);
                            lst_Code.SelectedIndex = 11;

                            k = i;
                            //Thiết lập vị trí của k
                            Mui_ten_do_len.Visible = true;
                            Mui_ten_do_len.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 65);
                            Mui_ten_do_len.Text = "K=" + k;
                            Mui_ten_do_len.Refresh();
                            Tre(50 * Toc_do);
                        }

                    }
                    
                    //Thiết lập Node đã có thứ tự

                    for (i = 0; i < k; i++)
                    {
                        Dat_mau_node(Node[i], Color.LawnGreen, Color.Black);
                        Tre(50 * Toc_do);
                    }
                    left = k;
                    //Thiết lập mũi tên chỉ left

                    Mui_ten_xanh_len_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 5);
                    Mui_ten_xanh_len_1.Text = "L = " + left;
                    Mui_ten_xanh_len_1.Refresh();
                    //
                    lst_Code.SelectedIndex = 14;
                    Tre(40 * Toc_do);
                    for (i = left; i < right; i++)
                    {
                        //Thiết lập mũi tên chỉ i
                        Mui_ten_xanh_xuong_1.Visible = true;
                        Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 55);
                        Mui_ten_xanh_xuong_1.Text = "i=" + i;
                        Mui_ten_xanh_xuong_1.Refresh();
                        Dat_mau_node(Node[i], Color.Yellow, Color.Black);
                        Application.DoEvents();
                        lst_Code.SelectedIndex = 15;
                        Tre(40 * Toc_do);
                        if (a[i] < a[i + 1])
                        {
                            lst_Code.SelectedIndex = 17;
                            Tre(40 * Toc_do);
                            Hoan_vi(ref a[i], ref a[i + 1]);
                            this.Invoke((MethodInvoker)delegate
                            {
                                Hoan_Vi_Node(Node[i], Node[i + 1]);
                            });
                            Tam_dung();
                            Hoan_Tri_Node(i, i + 1);
                            lst_Code.SelectedIndex = 18;

                            k = i;
                            //Thiết lập vị trí của k
                            Mui_ten_do_len.Visible = true;
                            Mui_ten_do_len.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 65);
                            Mui_ten_do_len.Text = "K=" + k;
                            Mui_ten_do_len.Refresh();
                            Tre(50 * Toc_do);
                        }

                    }
                    
                    //Thiết lập Node đã có thứ tự
                    for (i = Spt - 1; i > k; i--)
                    {
                        Dat_mau_node(Node[i], Color.LawnGreen, Color.Black);
                        Tre(50 * Toc_do);
                    }
                    //                         
                    right = k;
                    //Thiết lập mũi tên chỉ right

                    Mui_ten_xanh_len_2.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * k) + (Kich_thuoc / 2) - 30, Node[k].Location.Y + 2 * Kich_thuoc + 5);
                    Mui_ten_xanh_len_2.Text = "R = " + right;
                    Mui_ten_xanh_len_2.Refresh();
                    //
                }

            });
            //sắp xếp hoàn thành
            Hoan_thanh();
        }
        #endregion

        #region SHELL SORT

        void ShellSort_tang()
        {
            int step, i, pos, x, len, Index_temp;
            TextBox temp;
                //Tạo mảng h
            int k = Convert.ToInt32(Math.Log10(Spt) / Math.Log10(2));
           
                h = new int[k];
                h[k - 1] = 1;
                for (i = k - 2; i >= 0; i--)
                {
                    Application.DoEvents();
                    h[i] = (2 * h[i + 1]);
                }
               
                //
                for (step = 1; step < k; step++)
                {
                    lst_Code.SelectedIndex = 3;
                    Application.DoEvents();
                    len = h[step];
                    lbl_status_02.Visible = true;
                    lbl_status_02.Text = "Len = h[" + step + "] = " + len;
                    lst_Code.SelectedIndex = 5;

                for (i = len; i < Spt; i++)
                    {
                        lst_Code.SelectedIndex = 6;
                        Application.DoEvents();
                        //thiết lập mũi tên đánh dấu nút cần chèn
                        Mui_ten_xanh_xuong_1.Visible = true;
                        Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 55);
                        Mui_ten_xanh_xuong_1.Text = "i=" + i;
                        Mui_ten_xanh_xuong_1.Refresh();
                        x = a[i];
                        lst_Code.SelectedIndex = 8;
                        temp = Node[i];
                        Index_temp = i;
                        //Đặt màu các Node trong mảng con
                        Dat_mau_node(Node[i], Color.Yellow, Color.Black);
                        pos = i - len;
                        while (pos >= 0)
                        {
                            Dat_mau_node(Node[pos], Color.Yellow, Color.Black);
                            pos = pos - len;
                        }
                        lbl_status_01.Visible = true;
                        lbl_status_01.Text = "Sắp xếp trong mảng con!";
                        //
                        this.Invoke((MethodInvoker)delegate
                        {
                            Node_di_len(Node[i], Kich_thuoc + 5);
                        });
                        pos = i - len;

                        while ((pos >= 0) && (x < a[pos]))
                        {
                            lst_Code.SelectedIndex = 10;
                            Application.DoEvents();
                            a[pos + len] = a[pos];
                            this.Invoke((MethodInvoker)delegate
                            {
                                if (len == 1)
                                {
                                    Node_qua_phai(Node[pos], len);
                                }
                                else
                                {
                                    Node_di_xuong(Node[pos], Kich_thuoc + 5);
                                    Node_qua_phai(Node[pos], len);
                                    Node_di_len(Node[pos], Kich_thuoc + 5);
                                }
                            });

                            Node[pos + len] = Node[pos];
                            lst_Code.SelectedIndex = 12;
                            pos = pos - len;
                            lst_Code.SelectedIndex = 13;

                    }
                        
                        a[pos + len] = x;
                        lst_Code.SelectedIndex = 15;
                        this.Invoke((MethodInvoker)delegate
                        {
                            Node_qua_trai(temp, Index_temp - (pos + len));
                            Node_di_xuong(temp, Kich_thuoc + 5);
                        });
                        Tam_dung();

                        Node[pos + len] = temp;


                        lbl_status_01.Visible = false;
                        Dat_mau_node(Node[i], Color.Red, Color.White);
                        pos = i - len;
                        while (pos >= 0)
                        {
                            Dat_mau_node(Node[pos], Color.Red, Color.White);
                            pos = pos - len;
                        }

                        //
                    }
                
               
            }
            //Sắp xếp hoàn thành
            for (int y = 0; y < Spt; y++)
            {
                Dat_mau_node(Node[y], Color.LawnGreen, Color.Black);
            }
            Hoan_thanh();
        }
        void ShellSort_giam()
        {
            int step, i, pos, x, len, Index_temp;
            TextBox temp;
            //Tạo mảng h
            int k = Convert.ToInt32(Math.Log10(Spt) / Math.Log10(2));

            h = new int[k];
            h[k - 1] = 1;
            for (i = k - 2; i >= 0; i--)
            {
                Application.DoEvents();
                h[i] = (2 * h[i + 1]);
            }

            //
            for (step = 1; step < k; step++)
            {
                lst_Code.SelectedIndex = 3;
                Application.DoEvents();
                len = h[step];
                lbl_status_02.Visible = true;
                lbl_status_02.Text = "Len = h[" + step + "] = " + len;
                lst_Code.SelectedIndex = 5;

                for (i = len; i < Spt; i++)
                {
                    lst_Code.SelectedIndex = 6;
                    Application.DoEvents();
                    //thiết lập mũi tên đánh dấu nút cần chèn
                    Mui_ten_xanh_xuong_1.Visible = true;
                    Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Kich_thuoc + Khoang_cach) * i) + (Kich_thuoc / 2) - 30, Node[i].Location.Y - Kich_thuoc - 55);
                    Mui_ten_xanh_xuong_1.Text = "i=" + i;
                    Mui_ten_xanh_xuong_1.Refresh();
                    x = a[i];
                    lst_Code.SelectedIndex = 8;
                    temp = Node[i];
                    Index_temp = i;
                    //Đặt màu các Node trong mảng con
                    Dat_mau_node(Node[i], Color.Yellow, Color.Black);
                    pos = i - len;
                    while (pos >= 0)
                    {
                        Dat_mau_node(Node[pos], Color.Yellow, Color.Black);
                        pos = pos - len;
                    }
                    lbl_status_01.Visible = true;
                    lbl_status_01.Text = "Sắp xếp trong mảng con!";
                    //
                    this.Invoke((MethodInvoker)delegate
                    {
                        Node_di_len(Node[i], Kich_thuoc + 5);
                    });
                    pos = i - len;

                    while ((pos >= 0) && (x > a[pos]))
                    {
                        lst_Code.SelectedIndex = 10;
                        Application.DoEvents();
                        a[pos + len] = a[pos];
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (len == 1)
                            {
                                Node_qua_phai(Node[pos], len);
                            }
                            else
                            {
                                Node_di_xuong(Node[pos], Kich_thuoc + 5);
                                Node_qua_phai(Node[pos], len);
                                Node_di_len(Node[pos], Kich_thuoc + 5);
                            }
                        });

                        Node[pos + len] = Node[pos];
                        lst_Code.SelectedIndex = 12;
                        pos = pos - len;
                        lst_Code.SelectedIndex = 13;

                    }

                    a[pos + len] = x;
                    lst_Code.SelectedIndex = 15;
                    this.Invoke((MethodInvoker)delegate
                    {
                        Node_qua_trai(temp, Index_temp - (pos + len));
                        Node_di_xuong(temp, Kich_thuoc + 5);
                    });
                    Tam_dung();

                    Node[pos + len] = temp;


                    lbl_status_01.Visible = false;
                    Dat_mau_node(Node[i], Color.Red, Color.White);
                    pos = i - len;
                    while (pos >= 0)
                    {
                        Dat_mau_node(Node[pos], Color.Red, Color.White);
                        pos = pos - len;
                    }

                    //
                }


            }
            //Sắp xếp hoàn thành
            for (int y = 0; y < Spt; y++)
            {
                Dat_mau_node(Node[y], Color.LawnGreen, Color.Black);
            }
            Hoan_thanh();
        }
        #endregion


        #endregion
        #region Các hàm điều khiển
        //Nút tạo mảng
        private void btn_Taomang_Click(object sender, EventArgs e)
        {
            lbl_status_02.Visible = false;
            //Gọi hàm xóa mảng
            Xoa_mang();
            this.txt_sophantu.Focus();
            this.txt_sophantu.SelectAll();
            try
            {
                Spt = Convert.ToInt32(txt_sophantu.Text);
            }
            catch
            {
                MessageBox.Show("Số phần tử vừa nhập vào không hợp lệ!");
                this.txt_sophantu.Clear();
                return;
            }
            //gọi hàm tạo mảng
            Tao_mang();
        }
        //Nút bắt đầu xắp xếp
        private void btn_sapxep_Click(object sender, EventArgs e)
        {
            btn_Sapxep.Enabled = false;

            rad_shakersort.Enabled = false;
            rad_shellsort.Enabled = false;

            //Cho phép các nút điều khiển
            btn_Dung.Enabled = true;


            //Thiết lập các nút nhập liệu
            btn_Docfile.Enabled = false; 
            btn_Mofile.Enabled = false;
            btn_Taomang.Enabled = false;
            btn_Ngaunhien.Enabled = false;



            #region SHAKER SORT
            if (rad_shakersort.Checked == true && rad_tang.Checked == true )
            {
                ShakerSort_tang();
            }
            if (rad_shakersort.Checked == true && rad_giam.Checked == true)
            {
                ShakerSort_giam();
            }
            #endregion

            #region SHELL SORT
            if (rad_shellsort.Checked == true && rad_tang.Checked == true)
            {
                ShellSort_tang();
                for (i = 0; i < Spt; i++)
                {
                    lbl_status_01.Text += a[i].ToString() + " ";
                }
            }
            if (rad_shellsort.Checked == true && rad_giam.Checked == true)
            {
                ShellSort_giam();
                for (i = 0; i < Spt; i++)
                {
                    lbl_status_01.Text += a[i].ToString() + " ";
                }
            }
            #endregion
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        //Timer thay đổi tốc độ
        private void Tmr_Thay_doi_toc_do_Tick(object sender, EventArgs e)
            {
                Toc_do = (Trb_Toc_do.Maximum - Trb_Toc_do.Value);
                lbl_Toc_do.Text = Trb_Toc_do.Value.ToString();
                if (Trb_Toc_do.Value == Trb_Toc_do.Maximum)
                {
                    lbl_Toc_do.Text = "Max=10";
                }
                else if (Trb_Toc_do.Value == Trb_Toc_do.Minimum)
                {
                    lbl_Toc_do.Text = "Min=0";
                }
            }
            //Nút pause
            private void btn_pause_Click(object sender, EventArgs e)
            {


                if (btn_Dung.Text == ";")
                {
                    btn_Dung.Text = "4";
                    KT_tam_dung = true;
                    Play_or_Stop();
                }
                else
                {
                    btn_Dung.Text = ";";
                    KT_tam_dung = false;
                }
            }
        #endregion
        #region Menu
        //Quản lý sự kiện thay đổi tùy chon sort step

        //THÔNG TIN PHẦN MỀM
        private void Menu_Thong_tin_Click(object sender, EventArgs e)
            {
                Form Frm_Profile = new frm_Thong_tin();
                Frm_Profile.ShowDialog();
            }
            //Exit
            private void menu_Thoat_Click(object sender, EventArgs e)
            {
                Environment.Exit(0);
            }

        
        #endregion
        #region Code C/C++
        //Tải code của thuật toán tương ứng với nút chon thuật toán vào cửa sổ xem code
        private void rad_shakersort_CheckedChanged(object sender, EventArgs e)
            {
                
                if (rad_tang.Checked == true && rad_shakersort.Checked == true)
                {
                    lst_Code.Items.Clear();
                    //Tải code của thuật toán Shaker Sort vào Cửa sổ xem code
                    lst_Code.Items.Add("void ShakerSort(int a[], int n)");
                    lst_Code.Items.Add("  {");
                    lst_Code.Items.Add("        int i;");
                    lst_Code.Items.Add("        int left, right, k;");
                    lst_Code.Items.Add("        left = 0; right = n-1; k = n-1;");
                    lst_Code.Items.Add("           while (left < right)");
                    lst_Code.Items.Add("             {");
                    lst_Code.Items.Add("               for (i = right; i > left; i--)");
                    lst_Code.Items.Add("                   if (a[i]< a[i-1]) ");
                    lst_Code.Items.Add("                     {");
                    lst_Code.Items.Add("	                    Swap(a[i], a[i-1]);");
                    lst_Code.Items.Add("	                    k = i;");
                    lst_Code.Items.Add("                     }");
                    lst_Code.Items.Add("                   left = k;");
                    lst_Code.Items.Add("               for (i = left; i < right; i++)");
                    lst_Code.Items.Add("                   if (a[i] > a[i + 1]) ");
                    lst_Code.Items.Add("                     {");
                    lst_Code.Items.Add("                       Swap(a[i], a[i + 1]);");
                    lst_Code.Items.Add("                       k = i; ");
                    lst_Code.Items.Add("                     }");
                    lst_Code.Items.Add("                  right = k;");
                    lst_Code.Items.Add("            }");
                    lst_Code.Items.Add("  }");
                }
                if (rad_giam.Checked == true && rad_shakersort.Checked == true)
                {
                    lst_Code.Items.Clear();
                    //Tải code của thuật toán Shaker Sort vào Cửa sổ xem code
                    lst_Code.Items.Add("void ShakerSort(int a[], int n)");
                    lst_Code.Items.Add("  {");
                    lst_Code.Items.Add("        int i;");
                    lst_Code.Items.Add("        int left, right, k;");
                    lst_Code.Items.Add("        left = 0; right = n-1; k = n-1;");
                    lst_Code.Items.Add("           while (left < right)");
                    lst_Code.Items.Add("             {");
                    lst_Code.Items.Add("               for (i = right; i > left; i--)");
                    lst_Code.Items.Add("                   if (a[i]> a[i-1]) ");
                    lst_Code.Items.Add("                     {");
                    lst_Code.Items.Add("	                    Swap(a[i], a[i-1]);");
                    lst_Code.Items.Add("	                    k = i;");
                    lst_Code.Items.Add("                     }");
                    lst_Code.Items.Add("                   left = k;");
                    lst_Code.Items.Add("               for (i = left; i < right; i++)");
                    lst_Code.Items.Add("                   if (a[i] < a[i + 1]) ");
                    lst_Code.Items.Add("                     {");
                    lst_Code.Items.Add("                       Swap(a[i], a[i + 1]);");
                    lst_Code.Items.Add("                       k = i; ");
                    lst_Code.Items.Add("                     }");
                    lst_Code.Items.Add("                  right = k;");
                    lst_Code.Items.Add("            }");
                    lst_Code.Items.Add("  }");
                }
            }
            

            private void rad_shellsort_CheckedChanged(object sender, EventArgs e)
            {
                
                if (rad_tang.Checked == true && rad_shellsort.Checked == true)
                {
                    lst_Code.Items.Clear();
                    //Tải code của thuật toán Shell Sort vào Cửa sổ xem code
                    lst_Code.Items.Add("void ShellSort(int a[], int n, int h[], int k)");
                    lst_Code.Items.Add("    {");
                    lst_Code.Items.Add("          int step, i, pos, x, len;");
                    lst_Code.Items.Add("          for (step = 0; step < k; step++)");
                    lst_Code.Items.Add("             {");
                    lst_Code.Items.Add("                 len = h[step];");
                    lst_Code.Items.Add("                 for (i = len; i < n; i++)");
                    lst_Code.Items.Add("                  {	");
                    lst_Code.Items.Add("                    x = a[i]; ");
                    lst_Code.Items.Add("                    pos = i - len;");
                    lst_Code.Items.Add("                    while((pos >= 0)&&(x < a[pos]))");
                    lst_Code.Items.Add("                     { ");
                    lst_Code.Items.Add("	                      a[pos + len]  = a[pos];");
                    lst_Code.Items.Add("	                      pos = pos - len;");
                    lst_Code.Items.Add("                     }");
                    lst_Code.Items.Add("                    a[pos + len] = x;");
                    lst_Code.Items.Add("                  }");
                    lst_Code.Items.Add("             }");
                    lst_Code.Items.Add("    }");
                }
                if (rad_giam.Checked == true && rad_shellsort.Checked == true)
                {
                    lst_Code.Items.Clear();
                    //Tải code của thuật toán Shell Sort vào Cửa sổ xem code
                    lst_Code.Items.Add("void ShellSort(int a[], int n, int h[], int k)");
                    lst_Code.Items.Add("    {");
                    lst_Code.Items.Add("          int step, i, pos, x, len;");
                    lst_Code.Items.Add("          for (step = 0; step < k; step++)");
                    lst_Code.Items.Add("             {");
                    lst_Code.Items.Add("                 len = h[step];");
                    lst_Code.Items.Add("                 for (i = len; i < n; i++)");
                    lst_Code.Items.Add("                  {	");
                    lst_Code.Items.Add("                    x = a[i]; ");
                    lst_Code.Items.Add("                    pos = i - len;");
                    lst_Code.Items.Add("                    while((pos >= 0)&&(x > a[pos]))");
                    lst_Code.Items.Add("                     { ");
                    lst_Code.Items.Add("	                      a[pos + len]  = a[pos];");
                    lst_Code.Items.Add("	                      pos = pos - len;");
                    lst_Code.Items.Add("                     }");
                    lst_Code.Items.Add("                    a[pos + len] = x;");
                    lst_Code.Items.Add("                  }");
                    lst_Code.Items.Add("             }");
                    lst_Code.Items.Add("    }");
                }
            }
            
        #endregion







     











    }
}










