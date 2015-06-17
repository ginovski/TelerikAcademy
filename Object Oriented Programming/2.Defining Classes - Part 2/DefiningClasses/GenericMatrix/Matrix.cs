namespace GenericMatrix
{
    using System;

    public class Matrix<T> where T : struct
    {
        private const int InitialSize = 8;

        private T[,] data;

        public int RowCount { get; private set; }
        public int ColCount { get; private set; }

        public Matrix()
        {
            this.data = new T[InitialSize, InitialSize];
            this.RowCount = InitialSize;
            this.ColCount = InitialSize;
        }

        public Matrix(int rows, int cols)
        {
            this.data = new T[rows, cols];
            this.RowCount = rows;
            this.ColCount = cols;
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            var summedMatrix = new Matrix<T>();
            for (int i = 0; i < first.RowCount; i++)
            {
                for (int j = 0; j < first.ColCount; j++)
                {
                    summedMatrix[i, j] = first[i, j] + second[i, j];
                }
            }
        }
        public T this[int row, int col]
        {
            get
            {
                return this.data[row, col];
            }

            set
            {
                this.data[row, col] = value;
            }
        }
    }
}
