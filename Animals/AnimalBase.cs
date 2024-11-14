using System.Runtime.CompilerServices;

namespace Animals
{
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
        public void SetAnimalType(AnimalType animalType) { ((IAnimal)this).AnimalType = animalType;
        }
    }
}
