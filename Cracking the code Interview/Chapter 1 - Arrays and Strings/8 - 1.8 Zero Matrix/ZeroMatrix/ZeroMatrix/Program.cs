// ZERO MATRIX: Write an algorithm such that if an element in MxN matrix is 0, its entire now and colum are set to 0

public static void ZeroMatrix(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    bool[] row = new bool[m];
    bool[] col = new bool[n];

    // Mark rows and columns to be zeroed
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] == 0)
            {
                row[i] = true;
                col[j] = true;
            }
        }
    }

    // Zero out rows
    for (int i = 0; i < m; i++)
    {
        if (row[i])
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = 0;
            }
        }
    }

    // Zero out columns
    for (int j = 0; j < n; j++)
    {
        if (col[j])
        {
            for (int i = 0; i < m; i++)
            {
                matrix[i, j] = 0;
            }
        }
    }
}