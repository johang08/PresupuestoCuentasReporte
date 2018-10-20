using System;
using System.ComponentModel.DataAnnotations;

namespace PresupuestoCuentas.Entidades
{
    public class Presupuesto
    {
        [Key]
        public int PresupuestoId { get; set; }
        public DateTime Fecha { get; set; }
        public String Descripcion;
        public double Monto { get; set; }

        public Presupuesto()
        {
            PresupuestoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Monto = 0;
        }
    }
}