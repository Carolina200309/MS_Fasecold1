using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class AccidenteDTO
    {
        public AccidenteDTO()
        {
        }

        public class ConteoAccidentesDTO
        {
            public int soloLatas { get; set; }
            public int heridos { get; set; }
            public int muertos { get; set; }
        }

        public AccidenteDTO(int id, string placa, DateTime fecha, string severidad )
        {
            Id = id;
            Placa = placa;
            Fecha = fecha;
            Severidad = severidad;

        }

        public int Id { get; set; }
        public string Placa { get; set; }
        public DateTime Fecha { get; set; }

        public string Severidad { get; set; }
    }
}
