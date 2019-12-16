namespace SafalERP.Data.Repositories.Procedure
{
    public interface IProcedureRepository
    {
        System.Threading.Tasks.Task<System.Collections.Generic.List<TSPEntity>> Execute<TSPEntity>(params object[] paramList) where TSPEntity : class;
    }
}