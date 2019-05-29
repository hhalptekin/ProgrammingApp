using Programming.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProgrammingAPI.Controllers
{
    public class LanguagesController : ApiController
    {
        LanguageDAL languageDAL = new LanguageDAL();


        public IHttpActionResult Get()
        {
            var language = languageDAL.GetAllLanguages();
            return Ok(language);
            //ok  IHttpActionResult interfacenin resposive kodunun kısaltılmıs halidir

        }
        public IHttpActionResult Get(int id)
        {
            var language = languageDAL.GetLanguagesById(id);
            if (language==null)
            {
                return NotFound();
            }
            return Ok();

        }

        public Language Post(Language languages)
        {
            return languageDAL.CreateLanguages(languages);
        }

        public Language Put(int id, Language languages)
        {
            return languageDAL.UpdateLangusages(id, languages);
        }
        public void Delete(int id)
        {
            languageDAL.DeleteLanguages(id);
        }
    }
}
