using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FlowListViewExemplo.Models;

namespace FlowListViewExemplo.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public ObservableCollection<Profile> Profiles { get; }

    
        public MainViewModel()
        {
            Profiles = new ObservableCollection<Profile>();

            var profile = new Profile
            {
                Nome = "Bertuzzi",
                Imagem = "profile1.png"
            };

            Profiles.Add(profile);

            profile = new Profile
            {
                Nome = "Mustafa",
                Imagem = "profile2.png"
            };

            Profiles.Add(profile);

            profile = new Profile
            {
                Nome = "Polly",
                Imagem = "profile3.png"
            };

            Profiles.Add(profile);

            profile = new Profile
            {
                Nome = "Novo",
                Imagem = "add.png"
            };

            Profiles.Add(profile);
           

        }
    }
}
