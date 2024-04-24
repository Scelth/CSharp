using IRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mag
{
    public class Magazine : IReadable
    {
        public string? Name { get; set; }
        public string? Publishing_house { get; set; }
        public short Year { get; set; }
        public short Pages { get; set; }
        public string? Article { get; set; }
        public int Chars { get; set; }
        public short Announcement { get; set; }

        public override string ToString()
        {
            return
                $"Magazine - {Name}\n" +
                $"Publishing house - {Publishing_house}\n" +
                $"Release date - {Year}\n" +
                $"Number of pages - {Pages}\n" +
                $"Title of the article - {Article}\n" +
                $"Number of characters - {Chars}\n" +
                $"Announcement of the article - {Announcement}";
        }
    }
}
