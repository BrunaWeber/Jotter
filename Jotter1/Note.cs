using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotter1
{
    class Note
    {
        string title;
        string notetext;


        public Note(string title, string notetext)
        {
            this.title = title;
            this.notetext = notetext;

        }

        public string Title { get => title; set => title = value; }
        public string Notetext { get => notetext; set => notetext = value; }
    }
}
