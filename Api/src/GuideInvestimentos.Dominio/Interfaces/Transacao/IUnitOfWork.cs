namespace GuideInvestimentos.Dominio.Interfaces.Transacao
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void RollBack();
        bool Save();
    }
}
