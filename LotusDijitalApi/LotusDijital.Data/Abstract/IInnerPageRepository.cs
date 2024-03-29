﻿using LotusDijital.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Data.Abstract
{
    public interface IInnerPageRepository : IGenericRepository<InnerPage>
    {
        Task<InnerPage> GetInnerPage(int id);
    }
}
