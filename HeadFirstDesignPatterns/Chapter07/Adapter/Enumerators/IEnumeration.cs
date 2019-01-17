namespace Chapter07.Enumerators
{
    interface IEnumeration<out T>
    {
        bool HasMoreElements();
        T NextElement();
    }
}
