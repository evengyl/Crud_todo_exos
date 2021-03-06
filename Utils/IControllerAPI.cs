﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_TODO_EXOS.Utils
{
    public interface IControllerAPI
    {
        TEntity GetAllAPI<TEntity>(string uri);
        TEntity GetOneAPI<TEntity>(string uri, int id);
        void PostAPI<TEntity>(string uri, TEntity model);
        void PutAPI<TEntity>(string ui, TEntity model);
        void Delete(string uri, int id);
    }
}
