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

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for UserInformation.xaml
    /// </summary>
    public partial class UserInformation : Page
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
          

            //Point relativePoint = btnNUs.TransformToAncestor(this)
            //                  .Transform(new Point(0, 0));
            //Console.WriteLine(relativePoint);
            EditUser editUser = new EditUser();
            //editUser.Top = 250;
            //editUser.Left = 600;
            editUser.ShowDialog();
        }

        private void btnNUs_Click(object sender, RoutedEventArgs e)
        {
            NewUser newUser = new NewUser();
            //newUser.Top = 250;
            //newUser.Left = 700;
            newUser.ShowDialog();
        }
    }
}
