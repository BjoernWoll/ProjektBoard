using Microsoft.EntityFrameworkCore;
using ProjektBoard.DatenLayer.Context;
using ProjektBoard.Entities.Domaene;
using ProjektBoard.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektBoard.DatenLayer.Repositories
{
    public class ProjektRepository
    {
        private ProjektContext ctx;

        public ProjektRepository()
        {
            ctx = new ProjektContext(new DbContextOptionsBuilder<ProjektContext>()
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjektBoard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .EnableSensitiveDataLogging(true)
                .EnableDetailedErrors(true)
                .LogTo(l => Console.Write(l),Microsoft.Extensions.Logging.LogLevel.Information)
                .Options
            );
            ctx.Database.OpenConnection();
        }


        public List<ProjektDomaenenDVO> AllProjekte()
        {
            var retvalues = new List<ProjektDomaenenDVO>();
            var projekts =
                 ctx.Set<ProjektStatus>()
                 .Join(ctx.Projekte,
                 ps => ps.Projekt_fk,
                 p => p.ID,
                 (ps, p) => new
                 {
                     p.Name, p.ID, ps.Updateam, ps.Status_fk
                 })
                 .Join(ctx.Stati,
                     e => e.Status_fk,
                     s => s.ID,
                     (e, s) => new { Projektname = e.Name, Status = s.Name }
                 ).ToList()
                ;

            projekts.ForEach(p => retvalues
           .Add(
               new ProjektDomaenenDVO()
               {
                   Name = p.Projektname, Status = p.Status
               }
               ));
            return retvalues;
        }





    }
}
