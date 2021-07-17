using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLearning
{
    public struct Cell
    {
        bool[] walls;
        Point cords;
        bool visited;

        public Cell(int x, int y, bool start)
        {
            walls = new bool[] { start, start, start, start };
            cords = new Point(x, y);
            visited = false;
        }
        public void visit()
        {
            visited = true;
        }
        public void InvertWall(int wall)
        {
            walls[wall] = !walls[wall];
        }
        public bool isVisited()
        {
            return visited;
        }
        public Point getCords()
        {
            return cords;
        }

        public bool[] getWalls()
        {
            return walls;
        }
    }
    public class Maze
    {
        public static Random rand = new Random();


        protected Cell[,] cells;
        protected Point currentCell;
        protected int width, height;

        private bool finished;
        public Maze(int width, int height, bool start)
        {
            this.width = width;
            this.height = height;
            cells = new Cell[width, height];
            currentCell = new Point(rand.Next(width), rand.Next(height));
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    cells[i, j] = new Cell(i, j, start);
            finished = false;
        }

        protected void Finish()
        {
            finished = true;
        }
        public virtual void IterateMaze() 
        {
            if (finished)
                return;
        }

        
        public Point GetCurrentCell()
        {
            return currentCell;
        }
        

        public Cell[,] getCells()
        {
            return cells;
        }

        public bool isFinished()
        {
            return finished;
        }

        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }
    }
}
