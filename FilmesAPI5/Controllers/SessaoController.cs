using AutoMapper;
using FilmesAPI5.Data;
using FilmesAPI5.Data.Dtos.Sessoes;
using FilmesAPI5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;
        public SessaoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        [HttpPost]
        public ActionResult AdicionaSessao(CreateSessaoDto createDto) 
        {
            Sessao sessao = _mapper.Map<Sessao>(createDto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { Id = sessao.Id }, sessao);
        }

        [HttpGet("{id}")]
        public ActionResult RecuperaSessaoPorId(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
            if (sessao != null)
            {
                ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);

                return Ok(sessaoDto);
            }
            return NotFound();
        }
    }
}
