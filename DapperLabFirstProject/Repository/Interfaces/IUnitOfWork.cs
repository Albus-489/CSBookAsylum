using System;
using DapperLabFirstProject.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperLabFirstProject.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IUsersRepository UsersRepository { get; }
        void Commit();
    }
}
