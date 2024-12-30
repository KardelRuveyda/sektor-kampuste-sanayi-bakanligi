using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync(); //SaveChangesAsync temsil etsin.
        void Commit();//Savechanges() temsil etsin.
    }
}
