namespace Animals
{
    internal interface IConsumable
    {
        internal protected abstract string DescribeTaste();
        internal protected bool IsMainCourseDish {  get; }
    }
}
