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
            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.Default)) //ANSI
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
            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.Default)) //ANSI
            {
                int count = 1;
                foreach (var item in list)
                {
                    await writer.WriteLineAsync(item);

                    if (count == 512)
                    {
                        int x = count;
                    }
                    count++;
                }
            }
        }

        public async Task SaveMatrixAsync(string fileName, IEnumerable<Matrix> list)
        {
            //хз почему, но при записи больее 600 записей WriteLineAsync виснет намертво.

            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.Default)) //ANSI
            {
                await writer.WriteLineAsync("\tprize\tcounter prize\tall counter");
            }

            int count = list.Select(x => x.PrizeListCount).Sum();

            foreach (var matrix in list)
            {
                using (StreamWriter writer = new StreamWriter(fileName, true, Encoding.Default)) //ANSI
                {
                    await writer.WriteLineAsync(matrix.City);

                    string resultString = "";

                    foreach (var prize in matrix.PrizeList)
                    {
                        //await writer.WriteLineAsync($"\t{prize.Name}\t{prize.Number}\t{count--}");
                        if (resultString != "")
                            resultString = resultString + "\n";

                        resultString = resultString + $"\t{prize.Name}\t{prize.Number}\t{count--}";

                        if (count == 100)
                        {
                            int x = count;
                        }
                    }

                    await writer.WriteLineAsync(resultString);
                }
            }
        }
    }
}
