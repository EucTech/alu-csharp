class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int columns = myMatrix.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                result[row, column] = myMatrix[row, column] * myMatrix[row, column];
            }
        }

        return result;
    }
}
