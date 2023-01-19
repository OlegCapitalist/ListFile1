using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFile1.Models
{
    public class Matrix
    {
        public string City { get; set; }

        public List<Prize> PrizeList { get; set; }

        public int PrizeListCount => PrizeList.Count();

        public override string ToString()
        {
            return $"{City}: {PrizeListCount}";
        }
    }
}
