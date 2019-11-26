﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class CategoriaDAO : IRepository<Categoria>
    {
        private readonly Context _context;

        public CategoriaDAO(Context context)
        {
            _context = context;
        }

        public Categoria BuscarPorId(int id)
        {
            return _context.Categorias.Find(id);
        }

        public bool Cadastrar(Categoria objeto)
        {
            if(BuscarPorNome(objeto) == null)
            {
                _context.Categorias.Add(objeto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Categoria BuscarPorNome(Categoria c)
        {
            return _context.Categorias.FirstOrDefault(x => x.Nome.Equals(c.Nome));
        }

        public List<Categoria> ListarTodos()
        {
            return _context.Categorias.ToList();
        }
    }
}
