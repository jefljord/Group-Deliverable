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
        
        room[] rooming = new room[20];
        public Button tempButton = new Button();
       

        public MainWindow()
        {

            InitializeComponent();
            ImageBrush myImage = new ImageBrush();
            Image BgImage = new Image();
            BgImage.Source = new BitmapImage(
                new Uri("pexels-photo-110854.jpeg", UriKind.Relative));
            myImage.ImageSource = BgImage.Source;
            Peoples.Background = myImage;

            fillArray(rooming);
        }

        public void fillArray(room[] r) {
            room x = new room();
            for (int i = 0; i < 20; i++)
            {
                x.empty();
                r[i] = x;
            }
        }

        
        room currentroom = new room(); 
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
            Display.Text += "\nPrice: " + PriceHelper(currentroom).ToString("0." + new string('0', 2));

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
            tempButton = _1;
            currentroom.empty();

            int roomNumber = 0;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(rooming[roomNumber]);
            
            

  
        }

        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tempButton = _2;
            currentroom.empty();

            int roomNumber = 1;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            
            PrintHelper(rooming[roomNumber]);


 
        }

        public void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tempButton = _3;
            currentroom.empty();
            int roomNumber = 2;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
      
        }

        public void Button_Click_4(object sender, RoutedEventArgs e)
        {
            currentroom.empty();

            tempButton = _4;
            int roomNumber = 3;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);


        }

        public void Button_Click_5(object sender, RoutedEventArgs e)
        {
            tempButton = _5;
            currentroom.empty();
            int roomNumber = 4;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
       

        }

        public void Button_Click_6(object sender, RoutedEventArgs e)
        {
            tempButton = _6;
            currentroom.empty();
            int roomNumber = 5;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);


        }

        public void Button_Click_7(object sender, RoutedEventArgs e)
        {
            tempButton = _7;
            currentroom.empty();
            int roomNumber = 6;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

         
        }

        public void Button_Click_8(object sender, RoutedEventArgs e)
        {
            tempButton = _8;
            currentroom.empty();
            int roomNumber = 7;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

        }

        public void Button_Click_9(object sender, RoutedEventArgs e)
        {
            tempButton = _9;
            currentroom.empty();
            int roomNumber = 8;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

      
        }

        public void Button_Click_10(object sender, RoutedEventArgs e)
        {
            tempButton = _10;
            currentroom.empty();
            int roomNumber = 9;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
       
        }

        public void Button_Click_11(object sender, RoutedEventArgs e)
        {
            tempButton = _11;
            currentroom.empty();
            int roomNumber = 10;
            currentroom.roomNum = roomNumber;
            currentroom = rooming[roomNumber];
            
            PrintHelper(currentroom);
  
        }

        public void Button_Click_12(object sender, RoutedEventArgs e)
        {
            tempButton = _12;
            currentroom.empty();
            int roomNumber = 11;
            currentroom.roomNum = roomNumber;
            currentroom = rooming[roomNumber];
            
            PrintHelper(currentroom);
        
        }

        public void Button_Click_20(object sender, RoutedEventArgs e)
        {
            tempButton = _20;
            currentroom.empty();
            int roomNumber = 18;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
  
        }

        public void Button_Click_14(object sender, RoutedEventArgs e)
        {
            tempButton = _14;
            currentroom.empty();
            int roomNumber = 12;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
 
        }

        public void Button_Click_15(object sender, RoutedEventArgs e)
        {
            tempButton = _15;
            currentroom.empty();
            int roomNumber = 13;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

      
        }

        public void Button_Click_16(object sender, RoutedEventArgs e)
        {
            tempButton = _16;
            currentroom.empty();
            int roomNumber = 14;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);

        
        }

        public void Button_Click_17(object sender, RoutedEventArgs e)
        {
            tempButton = _17;
            currentroom.empty();
            int roomNumber = 15;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
      
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            tempButton = _18;
            currentroom.empty();
            int roomNumber = 16;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
         
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            currentroom.empty();
            tempButton = _21;
            int roomNumber = 19;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            currentroom.empty();
            int roomNumber = 17;
            currentroom = rooming[roomNumber];
            currentroom.roomNum = roomNumber;
            PrintHelper(currentroom);
            
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
            room a = new room();
            PrintHelper(currentroom);
            a = currentroom.MakeCopy();
            rooming[currentroom.roomNum] = a;
            tempButton.Background = new SolidColorBrush(Colors.IndianRed);
        }

        
        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            room j = new room();
            currentroom.empty();
            rooming[currentroom.roomNum] = j;
            tempButton.Background = new SolidColorBrush(Color.FromArgb(30, 0, 0, 1));

        }


        
    }
}
