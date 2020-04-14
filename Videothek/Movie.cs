using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videothek
{
    class Movie
    {
        public int id;
        public string Title;


        public Movie(string Title, int id)
        {
            this.id = id;
            this.Title = Title;
        }

    }
}
