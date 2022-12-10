using System;
using Project1.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IBranchesRepository BranchesRepository { get; }
        public IThemesRepository ThemesRepository { get; }
        public IThemeMessageRepo ThemeMessageRepo { get; }
        void Commit();
    }
}
