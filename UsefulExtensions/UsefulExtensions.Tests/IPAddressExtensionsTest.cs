using PaoloCattaneo.UsefulExtensions;
using System.Net;

namespace UsefulExtensions.Tests;

public class IPAddressExtensionsTest
{
    private string baseIp;

    [SetUp]
    public void Setup()
    {
        baseIp = "192.168.12.4";
    }

    [Test]
    public void TestIncrement1()
    {
        var ip = IPAddress.Parse(baseIp);
        var next = ip.Next();
        Assert.That(next, Is.Not.Null);
        Assert.That(next.ToString(), Is.EqualTo("192.168.12.5"));
    }

    [Test]
    public void TestIncrementN()
    {
        var ip = IPAddress.Parse(baseIp);
        var next = ip.Next(10);
        Assert.That(next, Is.Not.Null);
        Assert.That(next.ToString(), Is.EqualTo("192.168.12.14"));
    }

    [Test]
    public void TestChangeClass()
    {
        var ip = IPAddress.Parse("192.168.12.253");
        var next = ip.Next(5);
        Assert.That(next, Is.Not.Null);
        Assert.That(next.ToString(), Is.EqualTo("192.168.13.2"));
    }
}
