public static class Array3D
{
    public static U[,,] Select<T, U>(this T[,,] values, Func<int, int, int, T, U> fn)
    {
        var result = new U[values.GetLength(0), values.GetLength(1), values.GetLength(2)];
        for (int x = 0; x < values.GetLength(0); x++)
        {
            for (var y = 0; y < values.GetLength(1); y++)
            {
                for (var z = 0; z < values.GetLength(2); z++)
                {
                    result[x, y, z] = fn(x, y, z, values[x, y, z]);
                }
            }
        }

        return result;
    }
}