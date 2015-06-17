using System;

namespace GenericMatrix
{
    class TestMatrix
    {
        static void Main(string[] args)
        {
            Matrix<int> field = new Matrix<int>(5, 5);

            for (int i = 0; i < field.RowCount; i++)
            {
                for (int j = 0; j < field.ColCount; j++)
                {
                    field[i, j] = i;
                }
            }


        }
    }
}
