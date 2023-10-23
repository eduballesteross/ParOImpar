
using ParImpar.Servicios;

namespace ParImpar.Controladores
{
    class Program 
    {
        public static void Main(string[] args)
        {

            MenuInterfaz menuI = new MenuImplementacion();

            int opcionSeleccionada;

            opcionSeleccionada = menuI.ParOImpar();

        }
    }
    

}