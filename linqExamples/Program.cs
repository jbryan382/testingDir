using System;
using System.Linq;
using System.Collections.Generic;

namespace linqExamples
{

  // class Monster {
    // public spawnMonsters() {
    //   var typeList = new List<Dragon>() {
    //     new Dragon {Color = "Red Dragon", Health = 350},
    //     new Dragon { Color = "Blue Dragon", Health = 325},
    //     new Dragon { Color = "Green Dragon", Health = 290},
    //     new Dragon { Color = "Black Dragon", Health = 330},
    //     new Dragon { Color = "White Dragon", Health = 295}
    //     };
      
    //   }
    // }
  class Dragon {
    public string Color { get; set; }
    public int Health { get; set; }
  }
  class Program
  {
    static void Main(string[] args)
    {
      var typeList = new List<Dragon>() {
        new Dragon {Color = "Red Dragon", Health = 350},
        new Dragon { Color = "Blue Dragon", Health = 325},
        new Dragon { Color = "Green Dragon", Health = 290},
        new Dragon { Color = "Black Dragon", Health = 330},
        new Dragon { Color = "White Dragon", Health = 295}
        };
      // var typeList = new List<string>() {"Red Dragon", "Blue Dragon", "Green Dragon", "Black Dragon", "White Dragon"};
      // var healthList = new List<int>() {350, 325, 290, 330, 295};

      // var testQ = typeList.Select((dragon, index)=> dragon + index );


// // Playing with the .Find()/.FirstOrDefault() Method

//       var findList = typeList.FirstOrDefault((f) => f == "Red Dragon");
//       Console.WriteLine($"{findList}");

//       var numList = healthList.Select(health => health*2);
//       foreach (var health in numList)
//       {
//         Console.WriteLine($"{health}");
//       }

// // Playing with the .Aggregate() Method

//       var aggregateList = healthList.Aggregate(0, (currentHealth, health)=> currentHealth + health);
//       Console.WriteLine($"{aggregateList}");

// Playing with multiple "Linq-ed" functions

      var multiLinqList = typeList.Where(hitPoints => hitPoints.Health >= 300).Select(monName => monName.Color);

        Console.WriteLine(String.Join("\n", multiLinqList));

    }
  }
}


