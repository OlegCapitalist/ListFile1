using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListFile1.Models;

namespace ListFile1.Services
{
    public class FileSaver
    {
        public async Task SaveNumeratedListAsync(string fileName, ICollection<Prize> prizeList)
        {
            using (StreamWriter writer = GetStreamWriter(fileName))
            {
                int count = prizeList.Count;

                await writer.WriteLineAsync("prize\tSht/number\tcounter");

                foreach (Prize prize in prizeList)
                {
                    await writer.WriteLineAsync($"{prize.Name}\t{prize.Number}\t{count--}");
                }
            }
        }

        public async Task SaveListAsync(string fileName, IEnumerable<string> list)
        {
            using (StreamWriter writer = GetStreamWriter(fileName)) 
            {
                foreach (var item in list)
                {
                    await writer.WriteLineAsync(item);
                }
            }
        }

        public async Task SaveMatrixAsync(string fileName, IEnumerable<Matrix> list)
        {
            using (StreamWriter writer = GetStreamWriter(fileName))
            {
                await writer.WriteLineAsync("\tprize\tcounter prize\tall counter");

                int count = list.Select(x => x.PrizeListCount).Sum();

                foreach (var matrix in list)
                {
                    await writer.WriteLineAsync(matrix.City);

                    foreach (var prize in matrix.PrizeList)
                    {
                        await writer.WriteLineAsync($"\t{prize.Name}\t{prize.Number}\t{count--}");
                    }
                }
            }
        }

        private bool WriteText(string fileName, IEnumerable<string> strings)
        {
            //File.WriteAllLines(fileName, strings, Encoding.ge);
            return true;
        }

        private StreamWriter GetStreamWriter(string fileName)
        {
            return new StreamWriter(fileName, false, Encoding.Default);
        }
    }
}
