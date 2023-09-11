using test_coverage_badge_example;

namespace tests;

public class Tests
{
    [Test]
    public void Add_Test()
    {
        var sut = new SomethingToTest();

        var result = sut.Add(5, 3);
        Assert.That(result, Is.EqualTo(8));
    }
}
