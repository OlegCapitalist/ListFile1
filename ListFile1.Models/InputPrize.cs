using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFile1.Models
{
    public class InputPrize
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public InputPrize()
        {

        }

        public InputPrize(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public override string ToString()
        {
            return $"{Name}: {Count}";
        }
    }
}
