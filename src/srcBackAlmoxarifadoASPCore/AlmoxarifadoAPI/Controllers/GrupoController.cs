﻿using AlmoxarifadoDomain.Models;
using AlmoxarifadoServices;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrupoController : ControllerBase
    {
        private readonly GrupoService _grupoService;
        public GrupoController(GrupoService grupoService)
        {
            _grupoService = grupoService;
        }

  
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var grupos = _grupoService.ObterTodosProdutos();
                return Ok(grupos);
            }
            catch (Exception)
            {

                return StatusCode(500, "Ocorreu um erro ao acessar os dados. Por favor, tente novamente mais tarde.");
            }
         
        }

        [HttpGet("/Grupo/{id}")]
        public IActionResult GetPorID(int id)
        {
            try
            {
                var grupo = _grupoService.ObterTodosGruposPorID(id);
                if (grupo == null)
                {
                    return StatusCode(404, "Nenhum Usúario Encontrado com esse Código.");
                }
                return Ok(grupo);
            }
            catch (Exception)
            {

                return StatusCode(500, "Ocorreu um erro ao acessar os dados. Por favor, tente novamente mais tarde.");
            }

        }
    }
}
