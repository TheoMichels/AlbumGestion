using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AlbumGestion
{
    public class MainViewModel : Observable
    {
        public MainViewModel()
        {
            _listAlbum = new ObservableCollection<PostViewModel>
                {
                new PostViewModel() { NomAlbum="QALF", NomArtiste="Damso"},
                new PostViewModel() { NomAlbum="Or noir", NomArtiste="Kaaris"},
                new PostViewModel() { NomAlbum="Trône", NomArtiste="Booba"},
                };
            _selectedAlbum = _listAlbum[0];
        }

        private readonly ObservableCollection<PostViewModel> _listAlbum;
        public ObservableCollection<PostViewModel> ListAlbum
        {
            get { return _listAlbum; }
        }

        private PostViewModel _selectedAlbum;
        public PostViewModel SelectedAlbum
        {
            get { return _selectedAlbum; }
            set
            {
                _selectedAlbum = value;
                OnPropertyChanged(nameof(SelectedAlbum));
            }
        }

        public void ajouterAlbum()
        {
            PostViewModel a = new PostViewModel();
            _listAlbum.Add(a);
            SelectedAlbum = a;
        }

        public void supprimerAlbum()
        {
            if(_selectedAlbum != null)
            {
                _listAlbum.Remove(_selectedAlbum);
                SelectedAlbum = null;
            }
        }
    }
}
