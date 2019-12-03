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



namespace SBI_Mgt_System
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

        public class room
        {
            public int roomNum;
            public string name;
            public int people;
            public bool pet;
        }
        room[] rooming = new room[20];

        room currentroom;
        public void _1_Click(object sender, RoutedEventArgs e)
        {            
            Room1 openRoom = new Room1();
            openRoom.Show();
            rooms x = new rooms();
            x.Show();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Room1 openRoom = new Room1();
            openRoom.Show();
            rooms x = new rooms();
            x.Show();
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string rm = "_1";
            rooms.findRoom(_1);
            currentroom = rooming[0];
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_1);
        }

        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string rm = "_2";
            rooms.findRoom(_2);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_2);
        }

        public void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string rm = "_3";
            rooms.findRoom(_3);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_3);
        }

        public void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string rm = "_4";
            rooms.findRoom(_4);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_4);
        }

        public void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string rm = "_5";
            rooms.findRoom(_5);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_5);

        }

        public void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string rm = "_6";
            rooms.findRoom(_6);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_6);
        }

        public void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string rm = "_7";
            rooms.findRoom(_7);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_7);
        }

        public void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string rm = "_8";
            rooms.findRoom(_8);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_8);
        }

        public void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string rm = "_9";
            rooms.findRoom(_9);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_9);
        }

        public void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string rm = "_10";
            rooms.findRoom(_10);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_10);
        }

        public void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string rm = "_11";
            rooms.findRoom(_11);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_11);
        }

        public void Button_Click_12(object sender, RoutedEventArgs e)
        {
            string rm = "_12";
            rooms.findRoom(_12);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_12);
        }

        public void Button_Click_13(object sender, RoutedEventArgs e)
        {
            string rm = "_13";
            rooms.findRoom(_13);
           
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_13);
        }

        public void Button_Click_14(object sender, RoutedEventArgs e)
        {
            string rm = "_14";
            rooms.findRoom(_14);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_14);
        }

        public void Button_Click_15(object sender, RoutedEventArgs e)
        {
            string rm = "_15";
            rooms.findRoom(_15);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_15);
        }

        public void Button_Click_16(object sender, RoutedEventArgs e)
        {
            string rm = "_16";
            rooms.findRoom(_16);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_16);
        }

        public void Button_Click_17(object sender, RoutedEventArgs e)
        {
            string rm = "_17";
            rooms.findRoom(_17);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_17);
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            string rm = "_18";
            rooms.findRoom(_18);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_18);
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            string rm = "_21";
            rooms.findRoom(_21);
           
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_21);
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            string rm = "_19";
            rooms.findRoom(_19);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_19);
        }
    }
}
