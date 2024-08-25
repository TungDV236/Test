using Example.Class;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;




namespace Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer timer;
        private int position = 0;
        private List_History scrollingText;
        private List<List_History> myList;
        public MainWindow()
        {
            InitializeComponent();

            // Chuyển từ List sang String
            myList = new List<List_History>
            {
                    new List_History { STT = 1, Code = "E01",Content_ = "Lỗi Trượt Vị Trí Trục 1 " , Solution=" Sưa loi 01 " , Time =" 10h21"},
                    new List_History  { STT = 2, Code = "E02",Content_ = "Lỗi Trượt Vị Trí Trục 2 " , Solution=" Sưa loi 02" , Time =" 10h22"},
                    new List_History  { STT = 3, Code = "E03",Content_ = "Lỗi Trượt Vị Trí Trục 3 " , Solution=" Sưa loi 03" , Time =" 10h23"},
                    new List_History  { STT = 2, Code = "E05",Content_ = "Lỗi Trượt Vị Trí Trục 4 " , Solution=" Sưa loi 02" , Time =" 10h22"},
                    new List_History  { STT = 3, Code = "E06",Content_ = "Lỗi Trượt Vị Trí Trục 5 " , Solution=" Sưa loi 03" , Time =" 10h23"},
                    new List_History  { STT = 2, Code = "E07",Content_ = "Lỗi Trượt Vị Trí Trục 6 " , Solution=" Sưa loi 02" , Time =" 10h22"},
                    new List_History  { STT = 3, Code = "E08",Content_ = "Lỗi Trượt Vị Trí Trục 7 " , Solution=" Sưa loi 03" , Time =" 10h23"},
                    new List_History  { STT = 2, Code = "E09",Content_ = "Lỗi Trượt Vị Trí Trục 8 " , Solution=" Sưa loi 02" , Time =" 10h22"},
                    new List_History  { STT = 3, Code = "E010",Content_ = "Lỗi Trượt Vị Trí Trục 9 " , Solution=" Sưa loi 03" , Time =" 10h23"}
            };

          //  scrollingText = List_History.Concat(myList) + "   " + string.Concat(myList);

            // Khởi tạo Timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100); // Thời gian delay giữa mỗi lần di chuyển (100ms)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            animation(textBox);
        }
        private void animation (TextBox sender)
        {
            TextBox textBox = (TextBox)sender;
            string mylistString = string.Join("           ", myList.Select(o => $"{o.STT}" + " " +  $"{o.Code}"+" "+$" {o.Content_}"));
            // Di chuyển dòng chữ sang trái
            position++;
            if (position >= mylistString.Length)
            {
                position = 0;
            }

            // Cập nhật nội dung của TextBox
            textBox.Text = mylistString.Substring(position) + mylistString.Substring(0, position);
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
        private void Input_losfocus(object sender, RoutedEventArgs e)
        {
            ushort value = convert(Input.Text);

            output.Text = value.ToString();
        }

        public static ushort convert(string str)
        {
            if (ushort.TryParse(str, out ushort result))
            {
                Console.WriteLine($"Converted value: {result}");
                return result;
            }
            else
            {
                throw new ArgumentException($"The input '{str}' cannot be converted to ushort.");
            }

        }


    }
}