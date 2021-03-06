﻿using System;
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

namespace _Project_01_Entity_CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static NorthwindEntities DBContext = new NorthwindEntities();
        Customer customerInformation;

        public MainWindow()
        {
            InitializeComponent();
            ListBox01.DisplayMemberPath = "ContactName";
            ListBox02.DisplayMemberPath = "ProductName";
            ListBox01.ItemsSource = DBContext.Customers.ToList<Customer>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string buttonPressed = (sender as Button).Name.ToString();
            switch (buttonPressed)
            {
                case ("NewButton"):
                    NewEntry(NameBox.Text.ToString(), CountryBox.Text.ToString());
                    break;
                case ("DeleteButton"):
                    DeleteEntry(customerInformation);
                    break;
                case ("UpdateButton"):
                    UpdateEntry(NameBox.Text.ToString(), CountryBox.Text.ToString());
                    break;
                case ("RefreshButton"):
                    RefreshCustomers();
                    break;
            }
        }

        public void NewEntry(string name, string country)
        {
            DBContext.Customers.Add(new Customer
            {
                CustomerID = "MINE",
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

        private void DeleteEntry(Customer customerInformation)
        {
            DBContext.Customers.Remove(customerInformation);
            DBContext.SaveChanges();
        }

        private void SearchEntry(string search)
        {
            var searchCustomer =
                from c in DBContext.Customers
                where c.Country == search
                select c;
            ListBox01.ItemsSource = searchCustomer.ToList<Customer>();
        }

        private void UpdateEntry(string name, string country)
        {
            customerInformation.ContactName = name;
            customerInformation.Country = country;
            DBContext.SaveChanges();
        }

        private void RefreshCustomers()
        {
            ResetEverything();
            ListBox01.ItemsSource = DBContext.Customers.ToList<Customer>();
        }

        private void ResetEverything()
        {
            NewButton.IsEnabled = false;
            UpdateButton.IsEnabled = false;
            DeleteButton.IsEnabled = false;
            ListBox01.ItemsSource = null;
            ListBox02.ItemsSource = null;
            NameBox.Text = null;
            CountryBox.Text = null;
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if((sender as ListBox).SelectedIndex >= 0)
            {
                customerInformation = ListBox01.SelectedItem as Customer;
                CustomerOrders(customerInformation.CustomerID);
                NameBox.Text = customerInformation.ContactName;
                CountryBox.Text = customerInformation.Country;
                UpdateButton.IsEnabled = true;
                DeleteButton.IsEnabled = true;
                ListBox01.SelectedIndex = -1;
            }
        }

        private void CustomerOrders(string customerID)
        {
            var customerOrders =
                from p in DBContext.Products
                join od in DBContext.Order_Details on p.ProductID equals od.ProductID
                join o in DBContext.Orders on od.OrderID equals o.OrderID
                join c in DBContext.Customers on o.CustomerID equals c.CustomerID
                where c.CustomerID == customerID
                select p;

            ListBox02.ItemsSource = customerOrders.ToList<Product>();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textInside = (sender as TextBox).Text.ToString();
            SearchEntry(textInside);
        }

        private void txtChange(object sender, RoutedEventArgs e)
        {

            if (NameBox.Text.Length > 0 || CountryBox.Text.Length > 0)
                NewButton.IsEnabled = true;
            else
                NewButton.IsEnabled = false;
            if (SearchBox.Text.Length > 0)
            {
                NewButton.IsEnabled = false;
            }
            else
            {
                UpdateButton.IsEnabled = false;
            }

        }
    }
}
