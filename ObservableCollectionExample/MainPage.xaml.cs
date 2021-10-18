﻿using ObservableCollectionExample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ObservableCollectionExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        //private List<Contact> Contacts;
        private ObservableCollection<Contact> Contacts;

        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/Clock_img.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/Lipstick_img.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/Perfume_img.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/thanglung_img.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/Tshirt_img.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/Nhan_img.jpg" });

            //Contacts = new List<Contact>();
            Contacts = new ObservableCollection<Contact>();
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)AvatarComboBox.SelectedValue).IconPath;
            Contacts.Add(new Contact { FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text, AvatarPath = avatar });

            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            AvatarComboBox.SelectedIndex = -1;

            FirstNameTextBox.Focus(FocusState.Programmatic);
        }
    }
}
