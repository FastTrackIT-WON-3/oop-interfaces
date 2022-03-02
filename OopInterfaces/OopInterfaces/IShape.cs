namespace OopInterfaces
{
    public interface IShape : IObjectWithArea,
                              ITranslatableObject,
                              IRotatableObject
    {
        void Print();
    }
}
