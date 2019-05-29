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

        public IEnumerable<Language> Get()
        {
            return languageDAL.GetAllLanguages();

        }
        public Language Get(int id)
        {
            return languageDAL.GetLanguagesById(id);

        }

        public Language Post(Language languages)
        {
            return languageDAL.CreateLanguages(languages);
        }

        public Language Put(int id,Language languages)
        {
            return languageDAL.UpdateLangusages(id,languages);
        }
        public void Delete(int id)
        {
             languageDAL.DeleteLanguages(id);
        }
    }
}
