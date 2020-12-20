using System.Threading.Tasks;

namespace ReneWiersma.Queries
{
    public interface IAsyncQuery<TIn, TOut>
    {
        Task<TOut> Execute(TIn input);
    }

    public interface IAsyncQuery<TOut>
    {
        Task<TOut> Execute();
    }
}
