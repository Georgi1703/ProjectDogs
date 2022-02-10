using DogApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApp.Abstractions
{
   public interface IDogServices
    {
        bool Create(string name, int age, string breed, string picture);
        bool UpdateDog(int dogId, string name, int age, string breed, string picture);
        List<Dog> GetDogs();
        bool RemoveById(int dogId);
        
    }
}
