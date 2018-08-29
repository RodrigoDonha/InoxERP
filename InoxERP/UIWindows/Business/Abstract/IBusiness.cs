using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Entities;

namespace UIWindows.Business.Abstract
{
    public interface IBusiness<T> where T : BaseEntity
    {
        IQueryable<T> Search { get; }

        void Insert(T entity);

        void Update(T entity);

        void Delete(string id);

        T ReturnByID(string id);

        IQueryable<T> ReteurnAll();
    }
}
