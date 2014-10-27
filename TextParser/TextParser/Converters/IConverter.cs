namespace TextParser.Converters
{
    interface IConverter<out T, in TU>
    {
        T Convert(TU convertible);
    }
}
