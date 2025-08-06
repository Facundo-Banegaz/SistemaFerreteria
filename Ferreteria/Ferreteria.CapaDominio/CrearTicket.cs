using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using System.IO;
using System.Globalization;
using System.Drawing.Drawing2D;
namespace Ferreteria.CapaDominio
{
     public class CrearTicket
    {
        StringBuilder linea = new StringBuilder();
        private Image headerImage = null;
        //Creamos una variable para almacenar el numero maximo de caracteres que permitiremos en el ticket.
        int maxCar = 32, cortar;//Para una impresora ticketera que imprime a 40 columnas. La variable cortar cortara el texto cuando rebase el limte.

        public Image HeaderImage
        {
            get { return headerImage; }
            set { if (headerImage != value) headerImage = value; }
        }

        //Creamos el primer metodo, este dibujara lineas guion.
        public string lineasGuion()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasGuion += "-";//Agregara un guio hasta llegar la numero maximo de caracteres.
            }
            return linea.AppendLine(lineasGuion).ToString(); //Devolvemos la lineaGuion
        }

        //Metodo para dibujar una linea con asteriscos
        public string lineasAsteriscos()
        {
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsterisco += "*";//Agregara un asterisco hasta llegar la numero maximo de caracteres.
            }
            return linea.AppendLine(lineasAsterisco).ToString(); //Devolvemos la linea con asteriscos
        }

        //Realizamos el mismo procedimiento para dibujar una lineas con el signo igual
        public string lineasIgual()
        {
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "=";//Agregara un igual hasta llegar la numero maximo de caracteres.
            }
            return linea.AppendLine(lineasIgual).ToString(); //Devolvemos la lienas con iguales
        }

        //Creamos un metodo para poner el texto a la izquierda
        public void TextoIzquierda(string texto)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //agregamos el fragmento restante
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                //Si no es mayor solo agregarlo.
                linea.AppendLine(texto);
            }
        }

        //Creamos un metodo para poner texto a la derecha.
        public void TextoDerecha(string texto)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restntes
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";//Agrega espacios para alinear a la derecha
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";//Agrega espacios para alinear a la derecha
                }
                //Si no es mayor solo agregarlo.
                linea.AppendLine(espacios + texto);
            }
        }

        //Metodo para centrar el texto
        public void TextoCentro(string texto, bool decorado = false)
        {
            int maxCar = 32;

            if (decorado)
            {
                texto = texto.ToUpper(); // Convertir a mayúsculas
                texto = $"*** {texto} ***"; // Agregar decoraciones
            }

            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }

                string fragmentoFinal = texto.Substring(caracterActual);
                int centrar = (maxCar - fragmentoFinal.Length) / 2;
                string espacios = new string(' ', centrar);
                linea.AppendLine(espacios + fragmentoFinal);
            }
            else
            {
                int centrar = (maxCar - texto.Length) / 2;
                string espacios = new string(' ', centrar);
                linea.AppendLine(espacios + texto);
            }
        }


        //Metodo para poner texto a los extremos
        public void TextoExtremos(string textoIzquierdo, string textoDerecho)
        {
            int maxCar = 32;
            string textoIzq = textoIzquierdo;
            string textoDer = textoDerecho;

            int totalLength = textoIzq.Length + textoDer.Length;

            if (totalLength > maxCar)
            {
                // Calcular cuánto recortar para que total sea maxCar
                int exceso = totalLength - maxCar;

                // Recortar preferentemente el texto izquierdo
                if (textoIzq.Length > exceso)
                {
                    textoIzq = textoIzq.Substring(0, textoIzq.Length - exceso);
                }
                else
                {
                    textoIzq = "";
                    textoDer = textoDer.Substring(0, Math.Max(0, maxCar));
                }
            }

            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            string espacios = new string(' ', nroEspacios);

            string textoCompleto = textoIzq + espacios + textoDer;
            linea.AppendLine(textoCompleto);
        }




        //Creamos el encabezado para los articulos
        public void EncabezadoVenta()
        {
            linea.AppendLine("ITEM           CANT     PRECIO.U"); // Total: 32 caracteres
        }



        //Metodo para agregar los totales d ela venta
        public void AgregarTotales(string texto, decimal total)
        {
            int maxCar = 32;
            string resumen, valor, textoCompleto, espacios = "";

            // Convertimos el total a string formateado con 2 decimales
            valor = total.ToString("N2"); // Ejemplo: 1.234,00

            // Limitamos el texto izquierdo para que, junto al valor, no exceda los 32 caracteres
            int maxTexto = maxCar - valor.Length;

            if (texto.Length > maxTexto)
                resumen = texto.Substring(0, maxTexto);
            else
                resumen = texto;

            // Calcular espacios intermedios
            int nroEspacios = maxCar - (resumen.Length + valor.Length);
            for (int i = 0; i < nroEspacios; i++)
                espacios += " ";

            textoCompleto = resumen + espacios + valor;
            linea.AppendLine(textoCompleto);
        }


        //Metodo para agreagar articulos 
public void AgregaArticulo(string articulo, decimal cant, decimal precio)
    {
        if (cant.ToString().Length <= 5 && precio.ToString("#,##0.00", new CultureInfo("es-AR")).Length <= 11)
        {
            string espacios = "";
            bool primeraLinea = true;
            int nroEspacios;

            string precioStr = precio.ToString("#,##0.00", new CultureInfo("es-AR")); // Formato argentino
            string cantidadStr = cant.ToString();

            if (articulo.Length > 16)
            {
                int actual = 0;
                for (int restante = articulo.Length; restante > 0; restante -= 16)
                {
                    int len = Math.Min(16, articulo.Length - actual);
                    string nombreParte = articulo.Substring(actual, len).PadRight(16);

                    if (primeraLinea)
                    {
                        nroEspacios = 5 - cantidadStr.Length;
                        string cantFormatted = new string(' ', nroEspacios) + cantidadStr;

                        nroEspacios = 11 - precioStr.Length;
                        string precioFormatted = new string(' ', nroEspacios) + precioStr;

                        linea.AppendLine(nombreParte + cantFormatted + precioFormatted);
                        primeraLinea = false;
                    }
                    else
                    {
                        linea.AppendLine(nombreParte);
                    }

                    actual += len;
                }
            }
            else
            {
                string nombrePadded = articulo.PadRight(16);

                nroEspacios = 5 - cantidadStr.Length;
                string cantFormatted = new string(' ', nroEspacios) + cantidadStr;

                nroEspacios = 11 - precioStr.Length;
                string precioFormatted = new string(' ', nroEspacios) + precioStr;

                linea.AppendLine(nombrePadded + cantFormatted + precioFormatted);
            }
        }
        else
        {
            linea.AppendLine("Valores fuera de rango.");
            throw new Exception("Cantidad o precio exceden el límite de columnas.");
        }
    }


    //Metodos para enviar secuencias de escape a la impresora
    //Para cortar el ticket
    public void CortaTicket()
        {
            linea.AppendLine("\x1B" + "m"); //Caracteres de corte. Estos comando varian segun el tipo de impresora
            linea.AppendLine("\x1B" + "d" + "\x00"); //Avanza 9 renglones, Tambien varian
        }

        //Para abrir el cajon
        public void AbreCajon()
        {
            //Estos tambien varian, tienen que ever el manual de la impresora para poner los correctos.
            linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96"); //Caracteres de apertura cajon 0
            //linea.AppendLine("\x1B" + "p" + "\x01" + "\x0F" + "\x96"); //Caracteres de apertura cajon 1
        }

        //Para mandara a imprimir el texto a la impresora que le indiquemos.
        public void ImprimirTicket(string impresora)
        {
            //Este metodo recibe el nombre de la impresora a la cual se mandara a imprimir y el texto que se imprimira.
            //Usaremos un código que nos proporciona Microsoft. https://support.microsoft.com/es-es/kb/322091

            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString()); //Imprime texto.
            //linea.Clear();//Al cabar de imprimir limpia la linea de todo el texto agregado.
        }
    }

    //Clase para mandara a imprimir texto plano a la impresora
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "Ticket de Venta";//Este es el nombre con el que guarda el archivo en caso de no imprimir a la impresora fisica.
            di.pDataType = "RAW";//de tipo texto plano
            //di.pOutputFile = "D:\\ticket.txt";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            int dwCount;

            // Convertir string a bytes con una codificación compatible
            Encoding encoding = Encoding.GetEncoding(850); // CP850: Español extendido
            byte[] bytes = encoding.GetBytes(szString);
            dwCount = bytes.Length;

            // Asignar los bytes en memoria no administrada
            pBytes = Marshal.AllocCoTaskMem(dwCount);
            Marshal.Copy(bytes, 0, pBytes, dwCount);

            // Enviar a la impresora
            bool result = SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return result;
        }

    }

}
