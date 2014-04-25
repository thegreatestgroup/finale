
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Finale
{
    class Song
    {
        public Attribute<string> Title = new Attribute<string>();
        public Attribute<string> Artist = new Attribute<string>();
        public Attribute<string> Album = new Attribute<string>();
    }
}
