using PatronRepositorio.Entidades;
using System.Data.Entity;


namespace PresupuestoCuentas.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cuenta> cuentas { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}