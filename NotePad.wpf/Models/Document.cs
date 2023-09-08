using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.wpf.Models
{
    public class Document
    {
        public string Content { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public bool Match { get; set; }
    }
}
