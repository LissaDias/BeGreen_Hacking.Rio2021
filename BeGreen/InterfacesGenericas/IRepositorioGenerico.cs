﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.InterfacesGenericas
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        TEntity Get(string id);

        TEntity Get(int id);

        Task<IEnumerable<TEntity>> GetAsync();

        IEnumerable<TEntity> Get();

        TEntity Add(TEntity obj);

        void Update(TEntity obj);

        void Delete(TEntity obj);

        void Delete(int id);
    }
}
