using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;
using System.Data.Entity;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/customers
        [HttpGet]
        public IHttpActionResult GetMovies()
        {
            return Ok(_context.Movies
                .Include(c => c.Genre)
                .ToList().Select(Mapper.Map<Movie, MovieDto>));
        }

        //GET /api/customers/id
        [HttpGet]
        public IHttpActionResult GetMovie(int id)
        {
            var customer = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(customer));
        }

        //POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movie);
        }

        //PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Movies.Single(c => c.Id == id);
            if (customerInDb == null)
                return NotFound();

            customerDto.Id = customerInDb.Id;
            Mapper.Map(customerDto, customerInDb);
            _context.SaveChanges();

            return Ok(customerInDb);
        }

        //DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var customerInDb = _context.Movies.Single(c => c.Id == id);
            if (customerInDb == null)
                return NotFound();

            _context.Movies.Remove(customerInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}