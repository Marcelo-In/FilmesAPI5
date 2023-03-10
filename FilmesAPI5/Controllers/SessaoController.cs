using AutoMapper;
using FilmesAPI5.Data;
using FilmesAPI5.Data.Dtos.Sessoes;
using FilmesAPI5.Models;
using FilmesAPI5.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace FilmesAPI5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private SessaoService _sessaoService;

        public SessaoController(SessaoService sessaoService)
        {
            _sessaoService = sessaoService;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult AdicionaSessao(CreateSessaoDto createDto) 
        {
            ReadSessaoDto readDto = _sessaoService.AdicionaSessao(createDto);
            
            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "admin, regular", Policy = "IdadeMinima")]
        public ActionResult RecuperaSessaoPorId(int id)
        {
            ReadSessaoDto readDto = _sessaoService.RecuperaSessaoPorId(id);
            if(readDto != null) return Ok(readDto);
            return NotFound();
        }
    }
}
