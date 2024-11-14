namespace Animals
{
    internal class AnimalBase : IAnimal
    {
        private protected readonly AnimalType _animalType;

        AnimalType AnimalType {  get { return _animalType; } }
    }
}
