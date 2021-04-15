using CC1_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CC1_API.Controllers
{
    public class HomeController : ApiController
    {
        private DB_CC1Entities1 db = new DB_CC1Entities1();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [HttpGet]
        public IHttpActionResult ListProprietaire()
        {
            try
            {
                //var proprietaire = db.Proprietaires.Select(x => new {steve=x.Nom}).ToList();
                var proprietaire = db.Proprietaires.ToList();
                return Ok(proprietaire);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public IHttpActionResult GetProprietaireBien(int id)
        {
            try
            {
                var proprietaire = db.Proprietaires.Find(id);
                return Ok(proprietaire);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
