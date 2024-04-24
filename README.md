# Projects and code snippets from [C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals]() by [Mark J. Price](https://github.com/markjprice)

## Chapter 1

Chapter one introduces the book and its author as well as basic developer enviroment set-up and C#/.NET basics. Most of this chapter was recapping what I already knew about C# and .NET, but I did learn about some useful VSCode extensions and how to understand .NET support.

## Chapter 2

The second chapter covers the basics of C# including syntax, understanding async/await, and creating console apps. My previous experience coding in Javascript/Typescript provided a lot of prior experience working with these concepts, but it was beneficial to delve into C# syntax before moving on to more complex aspects of .NET development.

## Chapter 3

Chapter three focuses on selection, iteration, type casting and conversion and handling exceptions. Again, I had an existing understanding of many of the topics covered in this chapter however, the C# specific content was beneficial before moving onto the next chapters.

## Chapter 4

Chapter four covers writing, debugging and testing functions. I found this highly informative and learned a lot about debugging and testing in C# and .NET.

### XML Comments

One topic in this chapter was the use of XML comments to create tooltip information and documentation for functions. The format of the comment is as follows:

```
<summary>
    Description of function and how to use it
</summary>
<param name="paramaterName">
    Description of paramater
</param>
<returns>
    Description of the return value
</returns>
```

These comments can be used with tools like [Sandcastle](https://github.com/EWsoftware/SHFB) to create documentation and also shows tooltip information in the code editor. I want to further investigate Sandcaste for use in future projects.

### Unit Testing

A large part of this chapter is unit testing with [xUnit](https://github.com/xunit/xunit). This chapter was increadibly interesting as I have only lightly touched testing before. Mark describes good tests as consisting of three parts; Arrange, Act, and Assert. An example of the a simple test for adding two numbers:

```
public class CalculatorTests
{
    [Fact]
    public void Test2Plus2()
    {
        // Arrange - setup inputs and unit being tested.
        double a = 2;
        double b = 2;
        double expected = 4;
        Calculator calc = new();

        // Act - Execute the function to test.
        double actual = calc.Add(a, b);

        // Assert - Compare expected and actual results.
        Assert.Equal(expected, actual);
    }
}
```

## Chapter 5
