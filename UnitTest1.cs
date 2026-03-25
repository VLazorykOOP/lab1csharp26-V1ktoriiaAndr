using System;

public class ProgramTests
{
    [Fact]
    public void SquareArea_ValidPerimeter_ReturnsCorrectArea()
    {
        double result = Program.SquareArea(16.0);
        Assert.Equal(16.0, result, 3);
    }

    [Fact]
    public void SquareArea_ZeroPerimeter_ReturnsZero()
    {
        double result = Program.SquareArea(0.0);
        Assert.Equal(0.0, result);
    }

    [Fact]
    public void Max_FirstIsGreater_ReturnsFirst()
    {
        Assert.Equal(10.0, Program.Max(10.0, 5.0));
    }

    [Fact]
    public void Max_SecondIsGreater_ReturnsSecond()
    {
        Assert.Equal(20.0, Program.Max(5.0, 20.0));
    }

    [Fact]
    public void Max_NumbersAreEqual_ReturnsSameValue()
    {
        Assert.Equal(7.5, Program.Max(7.5, 7.5));
    }

    [Fact]
    public void PointInRegion_InsideRegion_ReturnsYes()
    {
        string result = Program.PointInRegion(5.0, 2.0);
        Assert.Equal("Так", result);
    }

    [Fact]
    public void PointInRegion_OutsideRegion_ReturnsNo()
    {
        string result = Program.PointInRegion(20.0, 20.0);
        Assert.Equal("Ні", result);
    }

    [Fact]
    public void PointInRegion_OnBoundary_ReturnsOnBoundary()
    {
        string result = Program.PointInRegion(12.0, 0.0);
        Assert.Equal("На межі", result);
    }

    [Theory]
    [InlineData(1, 11)]
    [InlineData(6, 6)]
    [InlineData(12, 0)]
    public void MonthsLeft_ValidMonths_ReturnsCorrectCount(int month, int expected)
    {
        int result = Program.MonthsLeft(month);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sum_PositiveNumbers_ReturnsCorrectSum()
    {
        Assert.Equal(10, Program.Sum(5, 5));
    }

    [Fact]
    public void Sum_NegativeNumbers_ReturnsCorrectSum()
    {
        Assert.Equal(-10, Program.Sum(-5, -5));
    }

    [Fact]
    public void Expression_SimpleValues_ReturnsCorrectResult()
    {
        double result = Program.Expression(1.0, 1.0);
        Assert.Equal(0.5, result, 3);
    }

    [Fact]
    public void Expression_ZeroValues_ReturnsCorrectResult()
    {
        double result = Program.Expression(0.0, 0.0);
        Assert.Equal(-1.0, result, 3);
    }
}