using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // <-- QUAN TRỌNG: Phải thêm dòng này

namespace Article01
{
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point Location { get; set; } // <-- Thêm dòng này (Trang 38)
    }
}