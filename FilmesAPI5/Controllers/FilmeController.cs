using FilmesAPI5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FilmesAPI5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicionaFilme(Filme filme)
        {
            filmes.Add(filme);
        }
    }
}
