using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8.Classes
public class AnimalShelter
{
  public AnimalShelter(Queue<Cat> catQueue, Queue<Dog> dogQueue)
  {
    CatQueue = catQueue;
    DogQueue = dogQueue;
  }

  public Queue<Cat> CatQueue { get; set; } = new();

  public Queue<Dog> DogQueue { get; set; } = new();



  public void EnQueue(Animal newAnimal)

  {

    if (newAnimal.species == "cat")

    {

      CatQueue.EnQueue(newAnimal);

    }

    else if (newAnimal.species == "dog")

    {

      DogQueue.EnQueue(newAnimal);

    }

    else

    {

      throw new Exception("Sorry, only cats or dogs at this shelter");

    }

  }



  public Animal DeQueue(string preference)

  {

    if (preference == "dog")

    {

      return DogQueue.DeQueue();

    }

    else if (preference = "cat")

    {

      return CatQueue.DeQueue();

    }

    else

    {

      throw new Exception("Sorry, only cats or dogs at this shelter");

    }

  }

}
}
