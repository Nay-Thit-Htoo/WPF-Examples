using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWPF
{
    public class SolutionBottle
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
        public int? Price { get; set; }
        public double? Weight { get; set; }
        public bool IsChecked()
        {
            return true;
        }
    }

   
}
