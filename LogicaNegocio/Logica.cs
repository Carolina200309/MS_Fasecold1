namespace LogicaNegocio
{
    public class Logica
    {
        private FuenteDeDatosFasecolda fuenteDeDatosFasecolda;

        public Logica(FuenteDeDatosFasecolda fuenteDeDatosFasecolda)
        {
            this.fuenteDeDatosFasecolda = fuenteDeDatosFasecolda;
        }



        public ConteoAccidenteDTO ObtenerCantidadAccidentesPorPlaca(string placa)
        {
            return fuenteDeDatosFasecolda.consultarCantidadAccidentesPorPlaca(placa);
        }



    }
}
