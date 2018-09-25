using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mvcOne.Models;
using mvcOne.Dtos;
using System.Data.Entity;
using AutoMapper;

namespace mvcOne.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
    }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [HttpGet]
        public IEnumerable<MoviesDto> getmovie()
        {
            var movie = _context.Movie
                      .Include(m => m.MovieType).ToList()
                       .Select(Mapper.Map<Movies,MoviesDto>);      
            return movie;
        }

         [HttpGet]
        public IHttpActionResult getMovie(int id)
        {
            var movi = _context.Movie.SingleOrDefault(m => m.Id == id);
            if (movi == null)
                return BadRequest();

            return Ok(Mapper.Map<Movies, MoviesDto>(movi));
        }

    

    }
}
