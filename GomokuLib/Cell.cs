namespace GomokuLib
{
    public class Cell
    {
        public Color? Color { get; private set; }
        public int? Number { get; private set; }

        public void Update(Color color, int number)
        {
            Color = color;
            Number = number;
        }

        public bool IsEmpty()
        {
            return Color is null;
        }
    }
}