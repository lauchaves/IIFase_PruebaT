using MvcApplication4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication4.Controllers
{
    public class MovieController : ApiController
    {


        MovieModel[] movies = new MovieModel[]
        {
            new MovieModel(){id="0",title="Batman",movieyear="1994", director="George", description="Action movie"},
            new MovieModel(){id="1",title="Harry Potter",movieyear="2001", director="Lucas", description="Fantasy movie"},
            new MovieModel(){id="2",title="The Ring",movieyear="1999", director="Mathew", description="Horror movie"},
            new MovieModel(){id="3",title="Mirrors",movieyear="2006", director="Kennedy", description="Drama movie"},
        };

        // GET api/movie
        /// <summary>
        /// Get All Movies
        /// </summary>
        /// <param name=""></param>
        /// <remarks>Return all movies</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        public IEnumerable<MovieModel> Get()
        {

            return movies;
        }

        // GET api/movie/5
        /// <summary>
        /// Get Movie
        /// </summary>
        /// <param name="student">value</param>
        /// <remarks>Return Movie by ID or title</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        public string Get(string id)
        {
            var mov = movies.FirstOrDefault((p) => p.id == id || p.title == id);
            if (mov != null)
            {
                for (int i = 0; i < movies.Length; i++) { 
                    if(movies[i].id == id){
                        return movies[i].title + ", " + movies[i].description;
                    }
                }
                
            }
            return "not found";
        }

        // POST api/movie
        public void Post([FromBody]string value)
        {
        }

        // PUT api/movie/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/movie/5
        public void Delete(int id)
        {
        }
    }
}
