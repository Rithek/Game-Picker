using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Picker_2._0._0
{
    public class Game
    {
        public string GameName { get; set; }
        public string Platform { get; set; }
        public string Status { get; set; }
        public int? Rating { get; set; }
        public string Tags { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime LastPlayed { get; set; }
        public bool IsSpeedrun { get; set; }

    }
}
