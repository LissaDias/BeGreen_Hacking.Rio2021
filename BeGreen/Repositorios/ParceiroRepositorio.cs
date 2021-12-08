﻿using BeGreen.Context;
using BeGreen.InterfaceRepositorio;
using BeGreen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Repositorios
{
    public class ParceiroRepositorio : RepositorioBase<Parceiro>, IParceiroRepositorio
    {
        private readonly DbSet<Parceiro> _parceiro;

        public ParceiroRepositorio(ContextBase db) : base(db)
        {
            _parceiro = db.Set<Parceiro>();
        }

        public Parceiro ObterEmail(string email)
        {
            return _parceiro
                .Include(x => x.Login)
                .AsNoTracking()
                .FirstOrDefault(x => x.Email == email);
        }

    }
}
