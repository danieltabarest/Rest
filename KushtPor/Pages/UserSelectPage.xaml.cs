﻿using System.Windows;
using System.Windows.Controls;

namespace KushtPor.Pages
{
    /// <summary>
    /// Interaction logic for UserSelectPage.xaml
    /// </summary>
    public partial class UserSelectPage : Page
    {
        public string accessToken, username;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AllRestaurants(username, accessToken, 0));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EnterId(username, accessToken));
        }

        public UserSelectPage(string accessToken, string username)
        {
            this.accessToken = accessToken;
            this.username = username;
           
            InitializeComponent();
            
        }
    }
}
