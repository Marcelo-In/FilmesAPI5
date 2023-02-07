using AutoMapper;
using FilmesAPI5.Data;
using FilmesAPI5.Data.Dtos.Sessoes;
using FilmesAPI5.Models;
using System;
using System.Linq;

namespace FilmesAPI5.Services
{
    public class SessaoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public SessaoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadSessaoDto AdicionaSessao(CreateSessaoDto createDto)
        {
            Sessao sessao = _mapper.Map<Sessao>(createDto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return _mapper.Map<ReadSessaoDto>(sessao);
        }

        public ReadSessaoDto RecuperaSessaoPorId(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
            if (sessao != null)
            {
                ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
                return sessaoDto;
            }
            return null;
        }
    }
}
