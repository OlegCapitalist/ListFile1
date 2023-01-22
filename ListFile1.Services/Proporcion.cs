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
        public static List<Prize> GetListOredrly(List<InputPrize> words)
        {
            List<Prize> result = new List<Prize>();
            var orderedByCounting = words.OrderByDescending(x => x.Count).ToList();
            var countElements = words.Sum(x => x.Count);

            int maxItemCount = orderedByCounting.First().Count;
            int secondMaxItemCount = orderedByCounting.Count() > 1 ? orderedByCounting.Skip(1).First().Count : 1;

            int countOfGroups = (int)Math.Round((decimal)(maxItemCount / secondMaxItemCount), MidpointRounding.AwayFromZero);
            List<List<Prize>> resultGrops = Enumerable.Range(0, countOfGroups).Select(o => new List<Prize>()).ToList();

            for (int currentItem = 0; currentItem < countElements; currentItem++)
            {
                for (int group = 0; group < countOfGroups; group++)
                {
                    for (int currentWordNumber = 0; currentWordNumber < words.Count; currentWordNumber++)
                    {
                        var currentWord = words[currentWordNumber];
                        if (currentWord.Count == 0)
                        {
                            continue;
                        }
                        resultGrops[group].Add(new Prize() { Name = currentWord.Name, Number = currentItem });
                        currentWord.Count--;
                    }
                }
            }

            resultGrops.ForEach(l => result.AddRange(l.OrderBy(lr => lr.Name)));
            return result;
        }

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
