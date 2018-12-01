﻿using System;
using System.Linq;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class ContractBusiness : BaseBusiness<Contracts>
    {
        public ContractBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }

        public Contracts returnByName(string name)
        {
            return context.Contracts.FirstOrDefault(r => r.sClientName == name);
        }

        public Contracts returnByDate(DateTime date)
        {
            return context.Contracts.FirstOrDefault(r => r.dtContractDate.ToShortDateString() == date.ToShortDateString());
        }

        //public override void Delete(string id)
        //{
        //    var linq = from q in context.Budgets_OS.Include("Items").Where(c => c.sID == id).ToList() select q;
        //    var entity = linq.First();

        //    context.Set<Budgets_OS>().Remove(entity);
        //    context.SaveChanges();
        //}
    }
}