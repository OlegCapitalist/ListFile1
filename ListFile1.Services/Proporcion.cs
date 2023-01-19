using ListFile1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFile1.Services
{
    public static class Proporcion
    {
        public static List<Prize> GetList(List<Prize> list)
        {
            const double offset = 0.4;

            var resultList = new List<Prize>();

            var groupedList = from prize in list
                              group prize by prize.Name into groupedByName
                              select new { GroupName = groupedByName.Key, ItemsCount = groupedByName.Max(x => x.Number) };

            var groupedCollection = groupedList.OrderByDescending(x => x.ItemsCount).ToList();

            if (groupedCollection.Count() >= 2)
            {
                int groupsCount = Convert.ToInt32(Math.Round(groupedCollection[0].ItemsCount / groupedCollection[1].ItemsCount + offset));
                
                for(int i = 0 ; i < groupsCount; i++)
                {
                    foreach(var currentGroup in groupedCollection)
                    {
                        int take = currentGroup.ItemsCount < groupsCount ? 1 : Convert.ToInt32(Math.Round(currentGroup.ItemsCount / groupsCount + offset));

                        var addedRange = list.Where(x => x.Name == currentGroup.GroupName)
                                                .OrderByDescending(x => x.Number)
                                                .Take(take).ToList<Prize>();
                        resultList.AddRange(addedRange);
                        //list.Distinct(addedRange);
                        RemoveRange(list, addedRange);
                    }

                }
            }
            else
            {
                resultList = list;
            }
                
            if (list.Count()>0)
            {
                resultList.AddRange(list.OrderByDescending(x => x.Number));
            }

            return resultList;
        }

        private static void RemoveRange(List<Prize> list, List<Prize> range)
        {
            foreach(var item in range)
            {
                list.Remove(item);
            }
        }
    }
}
