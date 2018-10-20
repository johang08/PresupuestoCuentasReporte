
using System.ComponentModel.DataAnnotations;


namespace PatronRepositorio.Entidades
{
    public class Cuenta
    {
        [Key]

        public int CuentaId { get; set; }
        public string Descripcion { get; set; }


        public Cuenta()
        {
            CuentaId = 0;
            Descripcion = string.Empty;
        }
    }
}
