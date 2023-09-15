/* ROTATE MATRIX: Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees. Can you do this place?*/

public class RotateMatrix
{
    public static void Rotate(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Transpose the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }

        // Reverse each row of the transposed matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, n - j - 1];
                matrix[i, n - j - 1] = temp;
            }
        }
    }
}