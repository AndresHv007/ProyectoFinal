using System;
using CalificacionesContext.Models;

using Microsoft.EntityFrameworkCore;

//Clase contexo
//Modelos

namespace CalificacionesContext
{
    public class Calificaciones : DbContext
    {
        //All database sets
        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<TipoProfesor> TipoProfesor { get; set; }
        public DbSet<ProfesorMateria> ProfesorMateria { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<GrupoEnEscuela> GrupoEnEscuela { get; set; }
        public DbSet<TipoPeriodo> TipoPeriodo { get; set; }
        public DbSet<Asignatura> Asignatura { get; set; }

        // Constructor
        public Calificaciones(DbContextOptions<Calificaciones> options)
        :base(options){}

        //Config global restrictions
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //Create connection with database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "../Database/Calificaciones.db";
            optionsBuilder.UseSqlite($"FileNombre = {path}");
        }
    }
}
