using System;
using System.Collections.Generic;
using Xunit;


public class StringCalculatorAddTests
{
    [Fact]
    public void ExpectZeroForEmptyInput()
    {
        int expectedResult = 0;
        string input = "";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }


  [Fact]
    public void ExpectZeroForSingleZero()
    {
        int expectedResult = 0;
        string input = "0";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

        Assert.Equal(expectedResult, result);
    }

  [Fact]
    public void ExpectSumForTwoNumbers()
    {
        int expectedResult = 3;
        string input = "1,2";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ExpectExceptionForNegativeNumbers()
    {
        Assert.Throws<Exception>(() =>
        {
            string input = "-1,2,-6,-8\n-3";
            StringCalculator objUnderTest = new StringCalculator();
            objUnderTest.Add(input);
        });
    }

  [Fact]
    public void ExpectSumWithNewlineDelimiter()
    {
        int expectedResult = 15;
        string input = "1\n2,3\n4,5";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }

  [Fact]
    public void IgnoreNumbersGreaterThan1000()
    {
        int expectedResult = 1;
        string input = "1,1001,1004,2000";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ExpectSumWithCustomDelimiter()
    {
        int expectedResult = 14;
        string input = "//;\n1;2;3;8";
        StringCalculator objUnderTest = new StringCalculator();
        int result = objUnderTest.Add(input);

       Assert.Equal(expectedResult, result);
    }

}
