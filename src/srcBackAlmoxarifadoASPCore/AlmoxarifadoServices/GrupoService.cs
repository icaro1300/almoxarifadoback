﻿using AlmoxarifadoDomain.Models;
using AlmoxarifadoInfrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmoxarifadoServices
{
    public class GrupoService
    {
        private readonly IGrupoRepository _grupoRepository;

        public GrupoService(IGrupoRepository pGrupoRepository)
        {
            _grupoRepository = pGrupoRepository;
        }

        public List<Grupo> ObterTodosProdutos()
        {
            return _grupoRepository.ObterTodosGrupos();
        }

        public Grupo ObterTodosGruposPorID(int id)
        {
            return _grupoRepository.ObterTodosGruposPorID(id);
        }

    }
}
