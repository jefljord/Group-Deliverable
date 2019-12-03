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
        public void PrintHelper(room current) {
            Display.Text = "Name: " + current.name + "\n" + "People: " + Convert.ToString(current.people) + "\n" + "Pet: ";
            if (current.pet)
            {
                Display.Text += "Yes";
            }
            else
            {
                Display.Text += "No";
            }
            Display.Text += "\nPrice: ";

        }

        public double PriceHelper(room current) {
            double price = 0;
            if(current.roomNum < 11) {
                price = 60;
            }
            else {
                price = 50;
            }

            if (current.people > 2)
            {
                price += (10 * (current.people - 2));
            }
            if (current.pet)
            {
                price += 10;
            }

            return price + (price*.1475);
        }
        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
          
            int roomNumber = 0;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            
            

            rooms.Reserved(_1);
        }

        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int roomNumber = 1;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);


            rooms.Reserved(_2);
        }

        public void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int roomNumber = 2;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_3);
        }

        public void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int roomNumber = 3;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

            rooms.Reserved(_4);
        }

        public void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int roomNumber = 4;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_5);

        }

        public void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int roomNumber = 5;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

            rooms.Reserved(_6);
        }

        public void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int roomNumber = 6;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

            rooms.Reserved(_7);
        }

        public void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int roomNumber = 7;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_8);
        }

        public void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int roomNumber = 8;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

            rooms.Reserved(_9);
        }

        public void Button_Click_10(object sender, RoutedEventArgs e)
        {
            int roomNumber = 9;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_10);
        }

        public void Button_Click_11(object sender, RoutedEventArgs e)
        {
            int roomNumber = 10;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_11);
        }

        public void Button_Click_12(object sender, RoutedEventArgs e)
        {
            int roomNumber = 11;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_12);
        }

        public void Button_Click_20(object sender, RoutedEventArgs e)
        {
            int roomNumber = 18;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_20);
        }

        public void Button_Click_14(object sender, RoutedEventArgs e)
        {
            int roomNumber = 12;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_14);
        }

        public void Button_Click_15(object sender, RoutedEventArgs e)
        {
            int roomNumber = 13;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

            rooms.Reserved(_15);
        }

        public void Button_Click_16(object sender, RoutedEventArgs e)
        {
            int roomNumber = 14;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

            rooms.Reserved(_16);
        }

        public void Button_Click_17(object sender, RoutedEventArgs e)
        {
            int roomNumber = 15;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_17);
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            int roomNumber = 16;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_18);
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            int roomNumber = 19;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            rooms.Reserved(_21);
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            int roomNumber = 17;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
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
            PrintHelper(currentroom);
            Display.Text += PriceHelper(currentroom).ToString("0." + new string('0', 2));
            rooming[currentroom.roomNum] = currentroom;

        }


        /*private void _1Pep_Checked(object sender, RoutedEventArgs e)
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
        }*/
    }
}
