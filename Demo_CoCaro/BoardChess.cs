using System;
using System.Drawing;

namespace Demo_CoCaro
{
    class BoardChess
    {
        public int Rows { set; get; }
        public int Columns { set; get; }

        Image ChessPieceX, ChessPieceO;

        public BoardChess()
        {
            Rows = 21;
            Columns = 21;

            ChessPieceO = new Bitmap(Properties.Resources.o, CellChess.Width -1, CellChess.Height - 1);
            ChessPieceX = new Bitmap(Properties.Resources.x, CellChess.Width - 1, CellChess.Height - 1);
        }

        //vẽ quân cờ X
        public void drawX(Graphics g, Point p)
        {
            g.DrawImage(ChessPieceX, p.X + 1, p.Y + 1);
        }

        //vẽ quân cờ O
        public void drawO(Graphics g, Point p)
        {
            g.DrawImage(ChessPieceO, p.X + 1, p.Y + 1);
        }

        //vẽ bàn cờ
        public void drawBoard(Graphics g, Pen p)
        {
            for (int i = 0; i <= Rows; i++)
            {
                g.DrawLine(p, 0, i * CellChess.Height, Columns * CellChess.Width, i * CellChess.Height);
            }
            for (int i = 0; i <= Columns; i++)
            {
                g.DrawLine(p, i * CellChess.Width, 0, i * CellChess.Width, Rows * CellChess.Height);
            }
        }

        //quân cờ vừa đánh
        public void lastCell(Graphics g, Point po, Pen pe)
        {
            g.DrawRectangle(pe, po.X, po.Y, CellChess.Width, CellChess.Height);
        }
        
        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
    }
}
