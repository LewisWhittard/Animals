using System.Runtime.CompilerServices;

namespace Animals
{
    internal abstract class AnimalBase : IAnimal
    {
        protected AnimalType _animalType;

        

        AnimalType IAnimal.animalType
        {
            get { return _animalType; }
        }

        protected AnimalType
    }

    internal abstract class AnimalBasePlus : AnimalBase
    {


        public AnimalType GetAnimalType() { return ((IAnimal)this).animalType; }
    }
}
