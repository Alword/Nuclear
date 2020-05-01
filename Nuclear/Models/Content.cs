using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rover.Models
{
    public class Content
    {
        public string Name { get; set; }
        public int IconId { get; set; }
        public string Icon { get => $"/AppData/icons/{IconId}.png"; }
        [Range(0, 100)]
        public short LoadedPercentage { get; set; }
        public bool IsLoaded { get => LoadedPercentage == 100; }

        public Content()
        {
            Name = "Design name";
            IconId = 1;
            LoadedPercentage = 45;
        }
    }
}
