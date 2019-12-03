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
        public class room
        {
            public int roomNum;
            public string name;
            public int people;
            public bool pet = false;
        }
        room[] rooming = new room[19];

        public MainWindow()
        {
            InitializeComponent();
            fillArray(rooming);
        }

        public void fillArray(room[] r) {
            room x = new room();
            for (int i = 0; i < 19; i++)
            {
                x.roomNum = 0;
                x.name = "";
                x.people = 0;
                x.pet = false;
                r[i] = x;
            }
        }

        
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
            int roomNumber = 0;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;

            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_1);
        }

        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int roomNumber = 1;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_2";
            rooms.findRoom(_2);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_2);
        }

        public void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int roomNumber = 2;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_3";
            rooms.findRoom(_3);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_3);
        }

        public void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int roomNumber = 3;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_4";
            rooms.findRoom(_4);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_4);
        }

        public void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int roomNumber = 4;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_5";
            rooms.findRoom(_5);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_5);

        }

        public void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int roomNumber = 5;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_6";
            rooms.findRoom(_6);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_6);
        }

        public void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int roomNumber = 6;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_7";
            rooms.findRoom(_7);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_7);
        }

        public void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int roomNumber = 7;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_8";
            rooms.findRoom(_8);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_8);
        }

        public void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int roomNumber = 8;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_9";
            rooms.findRoom(_9);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_9);
        }

        public void Button_Click_10(object sender, RoutedEventArgs e)
        {
            int roomNumber = 9;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_10";
            rooms.findRoom(_10);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_10);
        }

        public void Button_Click_11(object sender, RoutedEventArgs e)
        {
            int roomNumber = 10;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_11";
            rooms.findRoom(_11);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_11);
        }

        public void Button_Click_12(object sender, RoutedEventArgs e)
        {
            int roomNumber = 11;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_12";
            rooms.findRoom(_12);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_12);
        }

        public void Button_Click_20(object sender, RoutedEventArgs e)
        {
            int roomNumber = 18;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_13";
            rooms.findRoom(_20);
           
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_20);
        }

        public void Button_Click_14(object sender, RoutedEventArgs e)
        {
            int roomNumber = 12;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_14";
            rooms.findRoom(_14);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_14);
        }

        public void Button_Click_15(object sender, RoutedEventArgs e)
        {
            int roomNumber = 13;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_15";
            rooms.findRoom(_15);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_15);
        }

        public void Button_Click_16(object sender, RoutedEventArgs e)
        {
            int roomNumber = 14;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_16";
            rooms.findRoom(_16);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_16);
        }

        public void Button_Click_17(object sender, RoutedEventArgs e)
        {
            int roomNumber = 15;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_17";
            rooms.findRoom(_17);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_17);
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            int roomNumber = 16;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_18";
            rooms.findRoom(_18);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_18);
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            int roomNumber = 19;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_21";
            rooms.findRoom(_21);
           
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_21);
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            int roomNumber = 17;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            string rm = "_19";
            rooms.findRoom(_19);
            
            rooms x = new rooms();
            x.Owner = this;
            x.Show();

            rooms.Reserved(_19);
        }

        private void Confirmation_Click(object sender, RoutedEventArgs e)
        {

            currentroom.name = NameIN.Text;
            if (_1Pep.IsChecked == true)
            {
                currentroom.people = 1;
            }
            else if (_2Pep.IsChecked == true)
            {
                currentroom.people = 2;
            }
            else if (_3Pep.IsChecked == true)
            {
                currentroom.people = 3;
            }
            else if (_4Pep.IsChecked == true)
            {
                currentroom.people = 4;
            }
            else if (_5Pep.IsChecked == true)
            {
                currentroom.people = 5;
            }
            if(PetBox.IsChecked == true)
            {
                currentroom.pet = true;
            }
            rooming[currentroom.roomNum] = currentroom;
        }

        private void _1Pep_Checked(object sender, RoutedEventArgs e)
        {
            _1Pep.IsChecked = true;
        }

        private void _3Pep_Checked(object sender, RoutedEventArgs e)
        {
            _2Pep.IsChecked = true;
        }

        private void _2Pep_Checked(object sender, RoutedEventArgs e)
        {
            _3Pep.IsChecked = true;
        }

        private void _4Pep_Checked(object sender, RoutedEventArgs e)
        {
            _4Pep.IsChecked = true;
        }

        private void _5Pep_Checked(object sender, RoutedEventArgs e)
        {
            _5Pep.IsChecked = true;
        }
    }
}
