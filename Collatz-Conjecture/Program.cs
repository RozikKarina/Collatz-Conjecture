using System;

public static class CollatzConjecture
{
    public static int Steps(int n)
    {
        if (n < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "Input must be a positive integer.");
        }

        int steps = 0;

        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }
            steps++;
        }

        return steps;
    }
}