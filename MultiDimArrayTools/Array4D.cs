public static class Array4D
{
    public static U[,,,] Select<T, U>(this T[,,,] values, Func<int, int, int, int, T, U> fn)
    {
        var result = new U[values.GetLength(0), values.GetLength(1), values.GetLength(2), values.GetLength(3)];

        for (var x = 0; x < values.GetLength(0); x++)
        {
            for (var y = 0; y < values.GetLength(1); y++)
            {
                for (var z = 0; z < values.GetLength(2); z++)
                {
                    for (var a = 0; a < values.GetLength(3); a++)
                    {
                        result[x, y, z, a] = fn(x, y, z, a, values[x, y, z, a]);
                    }
                }
            }
        }

        return result;
    }
}