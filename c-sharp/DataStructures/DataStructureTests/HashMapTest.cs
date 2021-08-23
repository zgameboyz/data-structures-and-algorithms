using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructuresTest
{
  public class HashMapTest
  {

    [Fact]

    public void CanAddValue()
    {

      HashMap potatoNames = new HashMap(1024);

      potatoNames.Set("spud", "HushPuppy");
      potatoNames.Set("plopy", "MashedPotato");
      potatoNames.Set("tater", "DumbPotato");

      Assert.True(potatoNames.Contains("spud"));


    }
    [Fact]
    public void CanGetValue()
    {
      HashMap potatoNames = new HashMap(1024);

      potatoNames.Set("spud", "HushPuppy");
      potatoNames.Set("plopy", "MashedPotato");
      potatoNames.Set("tater", "DumbPotato");

      Assert.Equal("MashedPotato",potatoNames.Get("plopy"));
    }
    [Fact]
    public void CanHandleNull()
    {
      HashMap potatoNames = new HashMap(1024);

      potatoNames.Set("spud", "HushPuppy");
      potatoNames.Set("plopy", "MashedPotato");
      potatoNames.Set("tater", "DumbPotato");

      Assert.Equal("No Such Thing", potatoNames.Get("Banana"));
    }
    [Fact]
    public void CanHandleCollisions()
    {
      HashMap potatoNames = new HashMap(1024);

      potatoNames.Set("spud", "HushPuppy");
      potatoNames.Set("plopy", "MashedPotato");
      potatoNames.Set("tater", "DumbPotato");
      potatoNames.Set("spud", "FrenchFry");

      Assert.True(potatoNames.Contains("spud"));
      
    }
    [Fact]
    public void CanRetreiveBucketCollisions()
    {
      HashMap potatoNames = new HashMap(1024);

      potatoNames.Set("spud", "HushPuppy");
      potatoNames.Set("plopy", "MashedPotato");
      potatoNames.Set("tater", "DumbPotato");
      potatoNames.Set("spud", "FrenchFry");

      Assert.Equal("FrenchFry",potatoNames.Get("spud"));

    }
    [Fact]
    public void CanHashKey()
    {
      HashMap potatoNames = new HashMap(1024);

      potatoNames.Set("spud", "HushPuppy");
      potatoNames.Set("plopy", "MashedPotato");
      potatoNames.Set("tater", "DumbPotato");
      potatoNames.Set("spud", "FrenchFry");

      int banana = potatoNames.Hash("plopy");

      bool isInRange = false;

     if (0 <= banana && banana <= 1024)
      {
        isInRange = true;
      }


      Assert.True(isInRange);

    }
  }

}
 



