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
            ListBox01.DisplayMemberPath = "ContactName";
            ListBox01.ItemsSource = DBContext.Customers.ToList<Customer>();
        }
        Customer customerInformation;
        private void txtChange(object sender, RoutedEventArgs e)
        {

            if (NameBox.Text.Length > 0 || CountryBox.Text.Length > 0)
                Button01.IsEnabled = true;
            else
                Button01.IsEnabled = false;
            if (SearchBox.Text.Length > 0)
            {
                Button01.IsEnabled = false;
            }
            else
            {
                Button02.IsEnabled = false;
            }

        }

        void NewQuery(string nameValue, string countryValue)
        {
            int customerID = DBContext.Customers.Count<Customer>();
            customerID++;
            DBContext.Customers.Add(new Customer
            {
                CustomerID = customerID.ToString(),
                CompanyName = "NULL",
                ContactName = NameBox.Text,
                ContactTitle = "NULL",
                Address = "NULL",
                City = "NULL",
                Region = "NULL",
                PostalCode = "NULL",
                Country = CountryBox.Text,
                Phone = "NULL",
                Fax = "NULL"
            });
            DBContext.SaveChanges();
        }
        void UpdateQuery(string nameValue, string countryValue)
        {
            customerInformation.ContactName = nameValue;
            customerInformation.Country = countryValue;
            DBContext.SaveChanges();
            customerInformation = null;
        }
        void SearchQuery(string searchValue)
        {
            ListBox01.ItemsSource = null;
            NameBox.Text = "";
            CountryBox.Text = "";
            var customers =
                    from c in DBContext.Customers
                    where c.Country == searchValue
                    select c;
            ListBox01.ItemsSource = customers.ToList<Customer>();
        }
        void DeleteQuery(string ID)
        {
            DBContext.Customers.Remove(customerInformation);
            DBContext.SaveChanges();
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Name.ToString();
            switch (content)
            {
                case "Button01":
                    NewQuery(NameBox.Text.ToString(), CountryBox.Text.ToString());
                    break;
                case "Button02":
                    UpdateQuery(NameBox.Text.ToString(), CountryBox.Text.ToString());
                    break;
                case "Button03":
                    DeleteQuery("delete");
                    break;
                case "Button04":
                    SearchQuery(SearchBox.Text.ToString());
                    SearchBox.Text = "";
                    break;
            }
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ListBox).SelectedIndex >= 0)
            {
                Button02.IsEnabled = true;
                customerInformation = ListBox01.SelectedItem as Customer;
                NameBox.Text = customerInformation.ContactName;
                CountryBox.Text = customerInformation.Country;
                ListBox01.SelectedIndex = -1;
                Button03.IsEnabled = true;
                //ListBox01.Items.Add(c.ContactName);
            }
        }
    }
}

/*
*   Project Pseudocode
*       grid 3x3
*       top 2 rows : Button : refresh from database
*       text boxes : for input e.g.city name
*       bottom 3 columns
*                      1) TextBlock
*                      2) ListBox with STRING e.g.customer.ContactName lives in ...City
*                      3) ListBox bound to a field
*   ListBox.ItemSource = <<linq output variable>>
*/