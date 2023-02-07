using AutoMapper;
using FilmesAPI5.Data;
using FilmesAPI5.Data.Dtos.Gerentes;
using FilmesAPI5.Models;
using FilmesAPI5.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private GerenteService _gerenteService;

        public GerenteController(GerenteService gerenteService)
        {
            _gerenteService = gerenteService;
        }

        [HttpPost]
        public IActionResult AdicionaGerente([FromBody] CreateGerenteDto gerenteDto)
        {
            ReadGerenteDto readDto = _gerenteService.AdicionaGerente(gerenteDto);
            
            return CreatedAtAction(nameof(RecuperaGerentesPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaGerentes([FromQuery] string nomeDoFilme)
        {
            List<ReadGerenteDto> readDto = _gerenteService.RecuperaGerentes(nomeDoFilme);
            if (readDto == null) return NotFound();
            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentesPorId(int id)
        {
            ReadGerenteDto readDto = _gerenteService.RecuperaGerentesPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaGerente(int id, [FromBody] UpdateGerenteDto gerenteDto)
        {
            Result resultado = _gerenteService.AtualizaGerente(id, gerenteDto);
            if(resultado.IsFailed) return NotFound();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaGerente(int id)
        {
            Result resultado = _gerenteService.DeletaGerente(id);
            if(resultado.IsFailed) return NotFound();
            return NoContent();
        }

    }
}
