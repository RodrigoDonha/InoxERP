using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business.Abstract;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public class BaseBusiness<T> : IBusiness<T> where T : BaseEntity
    {
        protected InoxErpContext context;

        public BaseBusiness(InoxErpContext contextParam)
        {
            context = contextParam;
        }

        public virtual IQueryable<T> Search
        {
            get { return from o in context.Set<T>() select o; }
        }
        public virtual void Insert(T entity)
        {
            //try
            //{
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
        }

        public virtual void Update(T entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public virtual void Delete(string id)
        {
            try
            {
                var entity = Search.FirstOrDefault(o => o.sID == id);
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public virtual T ReturnByID(string id)
        {
            return Search.FirstOrDefault(c => c.sID == id);
        }
        
        public virtual IQueryable<T> ReturnAll()
        {
            return Search;
        }
    }
}
