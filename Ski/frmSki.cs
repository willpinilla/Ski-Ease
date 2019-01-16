using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ski
{
    public partial class frmSki : Form
    {
        List<int> ActualPath = new List<int>();
        List<int> BestPath;
        int LengthActualPath = 0;
        int LengthBestPath = 0;
        int DropPath = 0;

        int[,] matrix = new int[1000, 1000];


        public frmSki()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //LOAD FILE TO MATRIX
            LoadFile();
            
            for (int row = 0; row < 1000; row++)
            {
                for (int col = 0; col < 1000; col++)
                {
                    ActualPath.Clear();
                    CalculatePath(row, col);
                }
            }

            txtLengthPath.Text = LengthBestPath.ToString();
            txtDropPath.Text = DropPath.ToString();
            txtPath.Text = string.Join("-", BestPath.ToArray());
        }

        private void LoadFile()
        {
            string[] linesInMap = System.IO.File.ReadAllLines(@"C:\Users\William Pinilla\Documents\Projects\Ski\map.txt");
            string[] elevations;

            int x = 0;
            foreach (string line in linesInMap)
            {
                elevations = line.Split(' ').ToArray();
                if (elevations.Length == 1000)
                {
                    for (int y = 0; y < 1000; y++)
                    {
                        matrix[x, y] = Convert.ToInt32(elevations[y]);
                    }
                    x++;
                }
            }
        }

        //RECURSIVE METHOD
        private void CalculatePath(int row, int col)
        {
            ActualPath.Add(matrix[row, col]);
            
            //NORTH
            if (row != 0)
            {
                if (matrix[row, col] > matrix[row - 1, col])
                {
                    CalculatePath(row - 1, col);
                }
            }

            //SOUTH
            if (row != 999)
            {
                if (matrix[row, col] > matrix[row + 1, col])
                {
                    CalculatePath(row + 1, col);
                }
            }

            //EAST
            if (col != 999)
            {
                if (matrix[row, col] > matrix[row, col + 1])
                {
                    CalculatePath(row, col + 1);
                }
            }

            //WEST
            if (col != 0)
            {
                if (matrix[row, col] > matrix[row, col - 1])
                {
                    CalculatePath(row, col - 1);
                }
            }

            LengthActualPath = ActualPath.Count;
                
            //IF ACTUAL PATH IS BETTER THAN BEST PATH
            if (LengthBestPath < LengthActualPath)
            {
                LengthBestPath = LengthActualPath;
                BestPath = ActualPath.ToList();
                DropPath = BestPath.Max() - BestPath.Min();
            }
            //IF ACTUAL AND BEST LENGTH PATH ARE EQUAL
            else if (LengthBestPath == LengthActualPath)
            {
                int BestHigh = BestPath.Max();
                int BestLow = BestPath.Min();
                int ActualHigh = ActualPath.Max();
                int ActualLow = ActualPath.Min();

                if ((BestHigh - BestLow) < (ActualHigh - ActualLow))
                {
                    LengthBestPath = LengthActualPath;
                    BestPath = ActualPath.ToList();
                    DropPath = ActualHigh - ActualLow;
                }
            }

            ActualPath.Remove(matrix[row, col]);
        }
    }
}
