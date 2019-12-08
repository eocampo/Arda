using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arda.Models
{
    public class Character {
        public int CharacterId { get; set; }
        public string PublicKey { get; set; }
        public string Name { get; set; }
        public string Faction { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public string Realm { get; set; }
    }
}
