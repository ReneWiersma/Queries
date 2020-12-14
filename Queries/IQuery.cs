namespace ReneWiersma.Queries
{
    public interface IQuery<TIn, TOut>
    {
        TOut Execute(TIn input);
    }

    public interface IQuery<TOut>
    {
        TOut Execute();
    }
}
