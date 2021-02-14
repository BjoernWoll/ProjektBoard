using Microsoft.EntityFrameworkCore;
using ProjektBoard.DatenLayer.Context;
using ProjektBoard.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektBoard.DatenLayer.Repositories
{
    public class PersonenRepositroy
    {
        private ProjektContext ctx;
        public PersonenRepositroy()
        { 
            ctx = new ProjektContext(new DbContextOptionsBuilder<ProjektContext>()
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjektBoard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .EnableSensitiveDataLogging(true)
                .EnableDetailedErrors(true)
                .LogTo(l => Console.Write(l), Microsoft.Extensions.Logging.LogLevel.Information)
                .Options
            );
            ctx.Database.OpenConnection();
            
        }


        public List<Person> All()
        {
            return ctx.Set<Person>().ToList();
        }

        public Person FindByName(string Name)
        {
            return ctx
                .Set<Person>()
                .Find(Name);
        }
    }
}
