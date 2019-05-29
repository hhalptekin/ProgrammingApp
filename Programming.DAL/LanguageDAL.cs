using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.DAL
{
    public class LanguageDAL
    {
        ProgrammingDbEntities db = new ProgrammingDbEntities();

        public IEnumerable<Language> GetAllLanguages()
        {
            return db.Language;
        }
        public Language GetLanguagesById(int id)
        {
            return db.Language.Find(id);

        }
        public Language CreateLanguages(Language languages)
        {
            db.Language.Add(languages);
            db.SaveChanges();
            return languages;

        }
        public Language UpdateLangusages(int id, Language languages)
        {

            db.Entry(languages).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return languages;


        }

        public void DeleteLanguages(int id)
        {

            db.Language.Remove(db.Language.Find(id));
            db.SaveChanges();
        }

    }
}
