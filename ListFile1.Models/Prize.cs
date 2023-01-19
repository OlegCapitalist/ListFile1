namespace ListFile1.Models
{
    public class Prize
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Number}";
        }
    }
}