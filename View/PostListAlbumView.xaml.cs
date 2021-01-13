using System;
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
    /// Logique d'interaction pour PostListAlbumView.xaml
    /// </summary>
    public partial class PostListAlbumView : UserControl
    {
        public PostListAlbumView()
        {
            InitializeComponent();
        }

        public void AjouterAlbum_Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainViewModel m)
            {
                m.ajouterAlbum();
            }
            
        }
        public void SupprimerAlbum_Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainViewModel m)
            {
                m.supprimerAlbum();
            }
        }
    }
}
