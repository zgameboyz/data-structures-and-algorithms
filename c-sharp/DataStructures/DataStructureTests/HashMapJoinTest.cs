using System;
using System.Collections.Generic;
using DataStructures;
using DataStructures.HashMap;
using Xunit;

namespace DataStructuresTest
{
  public class HashMapJoinTest : HashMapJoin
  {

    [Fact]
    public void CanJoinTables()
    {
      HashMapPrimary potatoNames = new HashMapPrimary(1024);

      potatoNames.Set("spud", "HushPuppy");
      potatoNames.Set("plopy", "MashedPotato");
      potatoNames.Set("tater", "DumbPotato");
      potatoNames.Set("spud", "FrenchFry");

    

      HashMapPrimary potatoNames2 = new HashMapPrimary(1024);

      potatoNames.Set("Walter", "MrPotatoHead");
      potatoNames.Set("Chunky", "PotatoWedge");
      potatoNames.Set("Hashy", "Hashbrown");
      potatoNames.Set("Darlin", "SweetPotato");

      List<string[]> potatoes = LeftJoin(potatoNames, potatoNames2);

      Assert.Equal("Darlin", potatoes[0][0]);
      Assert.Equal("Chunky", potatoes[1][0]);
      Assert.Equal("tater", potatoes[2][0]);
      Assert.Equal("Walter", potatoes[3][0]);
      //Both Of the bottom ones here are spud so I showed the value instead of key for spud
      Assert.Equal("FrenchFry", potatoes[4][1]);
      Assert.Equal("spud", potatoes[5][0]);
      Assert.Equal("Hashy", potatoes[6][0]);
      Assert.Equal("plopy", potatoes[7][0]);
    }
  }
}
 



