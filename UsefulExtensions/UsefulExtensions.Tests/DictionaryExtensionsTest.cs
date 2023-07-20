using PaoloCattaneo.UsefulExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace UsefulExtensions.Tests;

internal class DictionaryExtensionsTest
{
    private Dictionary<string, int> dictionary;

    [SetUp]
    public void Setup()
    {
        dictionary = new Dictionary<string, int>()
        {
            { "Paolo", 31 },
            { "Clara", 23 },
            { "Francesco", 60 }
        };
    }

    [Test]
    public void When_Item_Not_Found_Get_Returns_Default_Instead_Of_Exception()
    {
        // normal access with [] throws exception
        Assert.Throws<KeyNotFoundException>(() =>
        {
            int value = dictionary["Luca"];
        });

        // extension returns null
        Assert.That(dictionary.Get("Luca"), Is.EqualTo(default(int)));
    }

    [Test]
    public void When_Key_Not_Found_Set_Add_It_Instead_Of_Exception()
    {
        // TIL that normal access with assignment actually adds the item!

        // normal access with [] throws exception
        //Assert.Throws<KeyNotFoundException>(() =>
        //{
        //    // oh no it doesnt! It works fine :D
        //    dictionary["Luca"] = 37;
        //});

        //// extension is simple
        //dictionary.Set("Luca", 37);
        //Assert.That(dictionary.Get("Luca"), Is.EqualTo(37));
    }
}
