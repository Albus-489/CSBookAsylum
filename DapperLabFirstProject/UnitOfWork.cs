using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DapperLabFirstProject.Repository.Interfaces;
using DapperLabFirstProject.Repository;
using System.Threading.Tasks;

namespace DapperLabFirstProject
{
    internal class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private IUsersRepository _usersRepository;
        private IBranchesRepository _branchesRepository;

        private bool _disposed;

        public UnitOfWork(SqlConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public IUsersRepository UsersRepository
        {
            get
            {
                return _usersRepository ?? (_usersRepository = new UsersRepository(_transaction));
            }
        }
        public IBranchesRepository BranchesRepository
        {
            get
            {
                return _branchesRepository ?? (_branchesRepository = new BranchesRepository(_transaction));
            }
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                resetRepositories();
            }
        }

        private void resetRepositories()
        {
            _usersRepository = null;
            _branchesRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }
    }
}
