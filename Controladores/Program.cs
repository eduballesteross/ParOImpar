
using ParImpar.Servicios;

namespace ParImpar.Controladores
{
    /// <summary>
    /// Clase Principal del programa
    /// </summary>
    class Program 
    { /// <summary>
    /// Método principal de la aplicacion
    /// </summary>
    /// <param name="args"></param>
        public static void Main(string[] args)
        {

            MenuInterfaz menuI = new MenuImplementacion();

            int opcionSeleccionada;

            opcionSeleccionada = menuI.ParOImpar();

        }
    }
    

}