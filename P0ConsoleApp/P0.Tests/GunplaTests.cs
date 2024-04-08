namespace P0.Tests;

public class GunplaTests
{
    [Theory]
    [InlineData("1")]
    [InlineData("2")]
    [InlineData("12")]
    public void UserIntInputReturnsIntForCorrectChoice(string option)
    {
        var input = new StringReader(option);
        Console.SetIn(input);

        var result = Menu.UserIntInput();

        Assert.Equal(typeof(int), result.GetType());
    }

    [Theory]
    [InlineData("q")]
    [InlineData("Q")]
    [InlineData("QQQ")]
    public void UserIntInputReturnsIntForIncorrectChoice(string option)
    {
        var input = new StringReader(option);
        Console.SetIn(input);

        var result = Menu.UserIntInput();

        Assert.True(result < 0);
    }

    [Theory]
    [InlineData("q")]
    [InlineData("Q")]
    [InlineData("QQQ")]
    public void UserIntInputReturnsMessageForIncorrectChoice(string option)
    {
        var output = new StringWriter();
        Console.SetOut(output);

        var input = new StringReader(option);
        Console.SetIn(input);

        var result = Menu.UserIntInput();

        Assert.Contains(string.Format("Invalid option! Must be a number. Try again."), output.ToString());
    }

    [Theory]
    [InlineData("y")]
    [InlineData("Y")]
    public void UserYNInputyReturnsY(string option)
    {
        var input = new StringReader(option);
        Console.SetIn(input);

        var result = Menu.UserYNInput();

        Assert.Equal(result.ToString(), string.Format("Y"));
    }

    [Theory]
    [InlineData("n")]
    [InlineData("N")]
    public void UserYNInputnReturnsN(string option)
    {
        var input = new StringReader(option);
        Console.SetIn(input);

        var result = Menu.UserYNInput();

        Assert.Equal(result.ToString(), string.Format("N"));
    }


}