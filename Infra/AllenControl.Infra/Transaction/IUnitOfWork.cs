namespace AllenControl.Infra.Transaction
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}