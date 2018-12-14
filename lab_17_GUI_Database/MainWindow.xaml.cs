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

namespace lab_17_GUI_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // first pull in Entity
        // then pull in DB : DECLARE DB HERE (STATIC)
        static NorthwindEntities DBContext = new NorthwindEntities();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            // FOREACH (CUSTOEMRS)
            //POPULATE LIST BOX

            //LINQ QUERY
            //POPULATE LIST BOX

            // SELECT ONE PERSON FROM FINLAND
            // CREATE AN "UPDATE" BUTTON ==> CLICK ==> PUSH FROM TEXTBOX HIS NEW NAME
            //var customers = LINQ QUERY
            /// DB BINDING
            //ListBox01.ItemsSource = customers.ContactName;
        }
    }
}
