using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();

        T Get(int id);

        int Delete(int id);

        int Create(T model);

        int Edit(T model);
    }
}