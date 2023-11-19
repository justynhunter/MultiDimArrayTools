namespace MultiDimArrayTools.Tests;

public class Array2DTests
{
    [Fact]
    public void Select_AddTest()
    {
        var array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var expected = new int[3, 3] { { 2, 3, 4 }, { 5, 6, 7 }, { 8, 9, 10 } };

        var actual = array.Select((v) => v + 1);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Select_MultipleTest()
    {
        var array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var expected = new int[3, 3] { { 3, 6, 9 }, { 12, 15, 18 }, { 21, 24, 27 } };

        var actual = array.Select((v) => v * 3);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Select_ChangeOutputTypeTest()
    {
        // Given
        var array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var expected = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

        // When
        var actual = array.Select((v) => v.ToString());

        // Then
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SelectWithIndex_Test()
    {
        var array = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        var expected = new (int,int,int)[2, 2] { { (0, 0, 1), (0, 1, 2) }, { (1, 0, 3), (1, 1, 4) } };

        var actual = array.Select((x, y, v) => (x, y, v));

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Aggregate_Test()
    {
        var array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var expected = 45;

        var actual = array.Aggregate(0, (acc, i) => acc + i);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void AggregateWithIndex_Test()
    {
        var array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var expected = "(0,0) = 1; (0,1) = 2; (0,2) = 3; (1,0) = 4; (1,1) = 5; (1,2) = 6; (2,0) = 7; (2,1) = 8; (2,2) = 9; ";

        var actual = array.Aggregate("", (acc, x, y, i) => acc + $"({x},{y}) = {i}; ");

        Assert.Equal(expected, actual);
    }
}