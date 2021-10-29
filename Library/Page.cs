using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Page
    {
        private int pageNum;
        private string content;
        private int[] paths;

        public int PageNum { get; set; }
        public string Content { get; set; }
        public int[] Paths { get; set; }
        public Page(int pageNum)
        {

        }
    }
    
}
