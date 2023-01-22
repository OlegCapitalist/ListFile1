using ListFile1.Models;

namespace ListFile1.Services
{
    public class ListIncrement
    {
        public void AddToList(ICollection<Prize> prizes, string Name, int count)
        {
            for (int i = count; i >= 1; i--)
            {
                prizes.Add(new Prize()
                {
                    Name = Name,
                    Number = i
                });
            }
        }
    }
}