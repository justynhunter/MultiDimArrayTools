using System.Security.Cryptography.X509Certificates;

namespace MultiDimArrayTools.Tests;

public class Array2DTests
{
    [Fact]
    public void AddTest()
    {
        var array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var expected = new int[3,3] {{2, 3, 4}, {5, 6, 7}, {8, 9, 10}};

        var actual = array.Select((x, y, v) => v + 1);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MultipleTest()
    {
        var array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var expected = new int[3,3] {{3, 6, 9}, {12, 15, 18}, {21, 24, 27}};

        var actual = array.Select((x, y, v) => v * 3);

        Assert.Equal(expected, actual);
    }
}