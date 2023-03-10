using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListFile1.Models;

namespace ListFile1.Services
{
    public class RandomizeList<T> where T : class
    {
        public List<T> GetList(List<T> collection)
        {
            var rnd = new Random();
            var result = new List<T>();

            while(collection.Count > 0)
            {
                int num = rnd.Next(collection.Count);

                result.Add(collection[num]);

                collection.Remove(collection[num]);
            }

            return result;
        }
    }
}
