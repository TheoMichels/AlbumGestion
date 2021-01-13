﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlbumGestion
{
    /// <summary>
    /// Logique d'interaction pour PostView.xaml
    /// </summary>
    public partial class PostView : UserControl
    {
        public PostView()
        {
            InitializeComponent();
        }
        public void AjouterPiste_Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is PostViewModel m)
            {
                m.ajouterPiste();
            }

        }
        public void SupprimerPiste_Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is PostViewModel m)
            {
                m.supprimerPiste();
            }
        }
    }
}