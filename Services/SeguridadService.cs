namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {
            if (clave > 0 && clave < ABECEDARIO.Length)
            {
                for (int b = 0; b < Mensaje.Length; b++ )
                {
                    int car = string.IndexOf(ABECEDARIO, (Mensaje[b]));
                    if (car != -1)
                    {
                        int posicion = car - clave;
                        while (posicion < 0)
                        {
                            posicion = posicion + ABECEDARIO.Length;
                        }
                        Mensaje += ABECEDARIO[posicion];
                    }
                    else
                    {
                        Mensaje += Mensaje[b];
                    }
                }
            }
            return Mensaje;
        }

        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {

            if (clave > 0 && clave < ABECEDARIO.Length )
            {
                for (int i = 0; i < Mensaje.Length; i++)
                {
                    int car = string.IndexOf(ABECEDARIO, (Mensaje[i]));
                    if (car != -1)
                    {
                        int posicion = car + clave;
                        while (posicion >=ABECEDARIO.Length )
                        {
                            posicion = posicion-ABECEDARIO.Length;
                        }
                        Mensaje += ABECEDARIO[posicion];
                    }
                    else
                    {
                        Mensaje += Mensaje[i];
                    }
                }
            }
            return Mensaje;
        }
    }


}