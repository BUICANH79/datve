using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Datve
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbxNu_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxNu.IsChecked == true)
                cbxNam.IsChecked = false;
        }

        private void cbxGhe_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxGhe.IsChecked == true)
                cbxGiuong1.IsChecked = false;
        }

        private void cbxVND_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxVND.IsChecked == true)
                cbxUSD.IsChecked = false;
        }

        private void cbxUSD_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxUSD.IsChecked == true)
                cbxVND.IsChecked = false;
        }

        private String QuocTich()
        {
            if (lstbQuocTich.SelectedIndex == 0)

                return "Việt Nam";
            else if (lstbQuocTich.SelectedIndex == 1)
                return "Pháp";
            else if (lstbQuocTich.SelectedIndex == 2)
                return "Anh";
            else if (lstbQuocTich.SelectedIndex == 3)
                return "Canada";

            return null;


        }
      
        

        private void lstbQuocTich_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox list = sender as ListBox;
            txblHienThi.Text = list.SelectedIndex.ToString();
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void cbxGiuong1_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxGiuong1.IsChecked == true)
                cbxGhe.IsChecked = false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                String ten = "Tên : " + txbTen.Text + "\n";
                String sdt = "Số Điện Thoại : " + txbSDT.Text + "\n";
                String gioiTinh;
                if (cbxNam.IsChecked == true)
                    gioiTinh = "Giới Tính : Nam" + "\n";
                else
                    gioiTinh = "Giới Tính : Nữ" + "\n";
                String loaiVe;
                if (cbxGiuong1.IsChecked == true)
                    loaiVe = "Loại Vé : Giường" + "\n";
                else
                    loaiVe = "Loại vé : Ghế" + "\n";

                String quocTich = null;

                quocTich = QuocTich();

                String thanhToan;
                if (cbxUSD.IsChecked == true)
                    thanhToan = "USD";
                else
                    thanhToan = "VND";

                float tienVNDGhe = 200000;
                float tienUSDGhe = 200000 / 20000;
                float tienVNDGiuong = 500000;
                float tienUSDGiuong = 500000 / 20000;

                float tienGiamGheVND = (tienVNDGhe * 80) / 100;
                float tienGiamGiuongUSD = (tienUSDGiuong * 80) / 100;

                String tongTien = null;



                if (cbxNam.IsChecked == false && cbxNu.IsChecked == false)
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");

                else if (cbxUSD.IsChecked == false && cbxVND.IsChecked == false)

                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");

                else if (cbxGiuong1.IsChecked == false && cbxGhe.IsChecked == false)

                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                else if (quocTich == null)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                }
                else if (txbSDT.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                }

                else if (txbTen.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                }
                else
                {
                    String hienThi = ten + sdt + gioiTinh + loaiVe + "Quốc Tịch : " + quocTich + "\n" + "Thanh Toán : " + thanhToan + "\n"
                                       + "Tổng Tiền : " + tongTien + "\n";
                    txblHienThi.Text = hienThi;
                }



            }

        }

        private void cbxNam_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxNam.IsChecked == true)
                cbxNu.IsChecked = false;
        }







    }
}
