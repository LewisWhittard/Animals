using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isolated
{
    public enum AnimalType
    {
        Fish,
        Amphibian,
        Reptile,
        Mammal,
        Bird,
        invertebrate,
    }

    public interface IAnimal
    {
        public AnimalType AnimalType { get; set; }
    }

    internal abstract class AnimalBase : IAnimal
    {
        protected AnimalType _animalType;




        AnimalType IAnimal.AnimalType
        {
            get { return _animalType; }
            set { _animalType = value; }
        }

    }

    internal abstract class AnimalBasePlus : AnimalBase
    {


        AnimalType GetAnimalType() { return ((IAnimal)this).AnimalType; }
        // Method to set animal type
        public void SetAnimalType(AnimalType animalType)
        {
            ((IAnimal)this).AnimalType = animalType;
        }
    }
}
