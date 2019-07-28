using System;
using GuideInvestimentos.Dominio.Interfaces.Transacao;
using GuideInvestimentos.Infra_Dados.Contextos;
using Microsoft.EntityFrameworkCore.Storage;

namespace GuideInvestimentos.Infra_Dados.Transacaco
{
    public sealed class UnitOfWork: IUnitOfWork, IDisposable
    {
        private readonly GuideDbContext _dbContext;
        private IDbContextTransaction _transaction;

        public UnitOfWork(GuideDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void BeginTransaction()
        {
            _transaction = _dbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void RollBack()
        {
            _transaction.Rollback();
        }

        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
            _transaction?.Dispose();
        }
    }
}
