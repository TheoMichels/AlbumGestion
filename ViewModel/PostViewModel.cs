using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace AlbumGestion
{
    public class PostViewModel : Observable
    {

        public override string ToString()
        {
            return TitreListe;
        }
        public PostViewModel()
        {
            _listPiste = new ObservableCollection<Piste>
            {
                new Piste(){ NumPiste=1, NomPiste="" },
            };
            _selectedPiste = _listPiste[0];
        }

        private readonly ObservableCollection<Piste> _listPiste;
        public ObservableCollection<Piste> ListPiste
        {
            get { return _listPiste; }
        }

        private Piste _selectedPiste;
        public Piste SelectedPiste
        {
            get { return _selectedPiste; }
            set
            {
                _selectedPiste = value;
                OnPropertyChanged(nameof(SelectedPiste));
            }
        }
        private string _nomAlbum;
        public string NomAlbum
        {
            get { return _nomAlbum; }
            set
            {
                _nomAlbum = value;
                OnPropertyChanged(nameof(NomAlbum));
                OnPropertyChanged(nameof(TitreListe));
                OnPropertyChanged(nameof(TitreFenetre));
            }
        }

        private string _nomArtiste;
        public string NomArtiste
        {
            get { return _nomArtiste; }
            set
            {
                _nomArtiste = value;
                OnPropertyChanged(nameof(NomArtiste));
                OnPropertyChanged(nameof(TitreListe));
                OnPropertyChanged(nameof(TitreFenetre));
            }
        }

        public string TitreListe
        {
            get { return $"Album : {NomAlbum} \nArtiste : {NomArtiste}"; }
        }

        //pour l'affichage du titre de la fenêtre
        public string TitreFenetre
        {
            get { return $"{NomAlbum} - {NomArtiste}"; }
        }

        public void ajouterPiste()
        {
            Piste p = new Piste();
            // donne à la piste le numéro de piste suivant automatiquement
            p.NumPiste = _listPiste.Count + 1;
            _listPiste.Add(p);
            SelectedPiste = p;
        }
        public void supprimerPiste()
        {
            if (_selectedPiste != null)
            {
                _listPiste.Remove(_selectedPiste);
                SelectedPiste = null;
            }
            // met à jour le numéro des pistes, vu qu'un élément est supprimé les numéro peuvent ne plus être bon
            for(int i=0; i<_listPiste.Count; i++)
            {
                _listPiste[i].NumPiste = i +1;
            }
        }

        public class Piste : Observable
        {

            public override string ToString()
            {
                return NumeroNomPiste;
            }
            private int _numPiste; 
            public int NumPiste
            {
                get { return _numPiste; }
                set
                {
                    _numPiste = value;
                    OnPropertyChanged(nameof(NumPiste));           
                }
            }

            private string _nomPiste;
            public string NomPiste
            {
                get { return _nomPiste; }
                set
                {
                    _nomPiste = value;
                    OnPropertyChanged(nameof(NomPiste));
                }
            }

            public string NumeroNomPiste
            {
                get { return $"{NumPiste} - {NomPiste}";  }
            }
        }
    }
}
