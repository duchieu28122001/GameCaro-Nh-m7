using System.Drawing;

namespace Demo_CoCaro
{
    class CellChess
    {
        public const int Width = 27, Height = 27;
        public int Rows { set; get; }
        public int Columns { set; get; }
        public int Owned { set; get; }
        public Point Position { set; get; }

        public CellChess()
        {
        }

        public CellChess(int rows, int columns, Point position, int owned)
        {
            Rows = rows;
            Columns = columns;
            Position = position;
            Owned = owned;
        }
    }
}
