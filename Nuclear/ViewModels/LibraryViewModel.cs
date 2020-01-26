using Almanac.Abstractions;
using Almanac.Models;
using System.Collections.ObjectModel;

namespace Almanac.ViewModels
{
    public class LibraryViewModel : NotifyPropertyChanged
    {
        private LibraryNewsViewModel itemContext;
        public LibraryNewsViewModel ItemContext
        {
            get => itemContext;
            set
            {
                itemContext = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Content> Contents { get; set; }

        public LibraryViewModel()
        {
            Contents = new ObservableCollection<Content>
            {
                new Content { Name = "Death Squared", IconId = 1,},
                new Content { Name = "Divinity Original Sin 2",IconId = 2 },
                new Content { Name = "Dota 2",IconId = 3},
            };
            ItemContext = new LibraryNewsViewModel();
        }
    }
}
