using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProgrammingLanguages:Entity
    {
        public string LanguageName { get; set; }

        public ProgrammingLanguages()
        {
        }

        public ProgrammingLanguages(int id,string languageName):this()
        {
            Id = id;
            LanguageName = languageName;
        }
    }
}
