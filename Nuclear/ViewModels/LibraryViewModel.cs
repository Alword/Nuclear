using Almanac.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Almanac.ViewModels
{
    public class LibraryViewModel
    {
        public string TestString { get; set; }
        public ObservableCollection<Content> Contents { get; set; }

        public LibraryViewModel()
        {
            Contents = new ObservableCollection<Content>
            {
                new Content { Name = "Death Squared" },
                new Content { Name = "Divinity Original Sin 2" },
                new Content { Name = "Dota 2" },
                new Content { Name = "Trine 4: The Nightmare prince" },
                new Content { Name = "Outward" }
            };
        }
    }
}
