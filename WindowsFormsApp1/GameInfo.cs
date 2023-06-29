using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GameInfo
    {
        public string Name
        {
            get;
            set;
        }
        public string Genres
        {
            get;
            set;
        }
        public string Tags
        {
            get;
            set;
        }
        public string Rating
        {
            get;
            set;
        }
        public string Prise
        {
            get;
            set;
        }
        public string Despription
        {
            get;
            set;
        }
        public GameInfo(string name, string genres, string tags, string rating, string prise, string despription)
        {
            Name = name;
            Genres = genres;
            Tags = tags;
            Rating = rating;
            Prise = prise;
            Despription = despription;
        }
    }
}
