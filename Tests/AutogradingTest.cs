namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Have_A_Constructor_That_Takes_A_FirstName_LastName_And_Age_And_Sets_Them_On_The_Corresponding_Class_Level_Fields()
    {
        var person = new Person(firstName: "mary", lastName: "smith", age: 5);

        Assert.Equal("mary", person.FirstName);
        Assert.Equal("smith", person.LastName);
        Assert.Equal(5, person.Age);
    }

    [Fact]
    public void Should_Overload_The_Constructor_With_One_That_Only_Takes_A_FirstName_LastName_And_Sets_Them_On_The_Corresponding_Class_Level_Fields()
    {
        var person = new Person(firstName: "mary", lastName: "smith");

        Assert.Equal("mary", person.FirstName);
        Assert.Equal("smith", person.LastName);
        Assert.Equal(0, person.Age);
    }
}
