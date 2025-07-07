

namespace Game_Data_Parser.GameContent
{
    public class GameContent
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }

        public override string ToString()
        {
            return $"{Title},{ReleaseYear},{Rating}";
        }
    }
}
