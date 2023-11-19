public static class Array2D
{
    public static U[,] Select<T, U>(this T[,] values, Func<T, U> fn)
    {
        var result = new U[values.GetLength(0), values.GetLength(1)];
        for (int x = 0; x < values.GetLength(0); x++)
        {
            for (var y = 0; y < values.GetLength(1); y++)
            {
                result[x, y] = fn(values[x, y]);
            }
        }

        return result;
    }

    public static U[,] Select<T, U>(this T[,] values, Func<int, int, T, U> fn)
    {
        var result = new U[values.GetLength(0), values.GetLength(1)];
        for (int x = 0; x < values.GetLength(0); x++)
        {
            for (var y = 0; y < values.GetLength(1); y++)
            {
                result[x, y] = fn(x, y, values[x, y]);
            }
        }

        return result;
    }

    public static U Aggregate<T, U>(this T[,] values, in U initalValue, Func<U, T, U> fn)
    {
        var result = initalValue;
        for (int x = 0; x < values.GetLength(0); x++)
        {
            for (var y = 0; y < values.GetLength(1); y++)
            {
                result = fn(result, values[x, y]);
            }
        }

        return result;
    }

    public static U Aggregate<T, U>(this T[,] values, in U initalValue, Func<U, int, int, T, U> fn)
    {
        var result = initalValue;
        for (int x = 0; x < values.GetLength(0); x++)
        {
            for (var y = 0; y < values.GetLength(1); y++)
            {
                result = fn(result, x, y, values[x, y]);
            }
        }

        return result;
    }
}