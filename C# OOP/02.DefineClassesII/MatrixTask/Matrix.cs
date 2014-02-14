using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    class Matrix<T>
    {
        private T[,] matrix;
        private int row;
        private int col;

        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.matrix = new T[row, col];
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0) || (row >= this.row) || (col < 0) || (col >= this.col))
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return this.matrix[row, col];
                }
            }
            set
            {
                if ((row < 0) || (row >= this.row) || (col < 0) || (col >= this.col))
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    this.matrix[row, col] = value;
                }
            }
        }
    
    }
}
