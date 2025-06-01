using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LogicaNegocio.Logica;

namespace LogicaNegocio
{
    public interface FuenteDeDatosFasecolda
    {
        public ConteoAccidenteDTO consultarCantidadAccidentesPorPlaca(string placa);

    }
}
