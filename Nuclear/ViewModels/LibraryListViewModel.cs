﻿using Rover.Abstractions;
using Rover.Models;
using System.Collections.ObjectModel;

namespace Rover.ViewModels
{
    public class LibraryListViewModel : NotifyPropertyChanged
    {
        private LibraryViewModel itemContext;
        public LibraryViewModel ItemContext
        {
            get => itemContext;
            set
            {
                itemContext = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Content> Contents { get; set; }

        public LibraryListViewModel()
        {
            ItemContext = new LibraryViewModel();
            Contents = new ObservableCollection<Content>
            {
                new Content { Name = "Death Squared", IconId = 1,},
                new Content { Name = "Divinity Original Sin 2",IconId = 2 },
                new Content { Name = "Dota 2",IconId = 3},
            };
        }
    }
}
