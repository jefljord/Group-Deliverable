using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SBI_Mgt_System
{
    /// <summary>
    /// Interaction logic for rooms.xaml
    /// </summary>
   
    public partial class rooms : Window
    {
        //myCalendar.BlackoutDates.Add(cdr);

        public static bool res = false;

        public static Button z = new Button();
        public static Button findRoom(Button pp)
        {
            z = pp;
            return z;
        }

        
        public static Button Reserved(Button p)
        {                  
            p.Background = new SolidColorBrush(Color.FromArgb(50, 180, 20, 30));
           
            
            return p;
        }
        public rooms()
        {
            InitializeComponent();    
            
        }
              
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            z.Background = new SolidColorBrush(Color.FromArgb(30, 0, 0, 1));
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            res = true;
            this.Close();
            
            
        }
    }
}
