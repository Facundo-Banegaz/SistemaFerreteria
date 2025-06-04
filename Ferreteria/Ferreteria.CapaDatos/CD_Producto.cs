using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_Producto
    {
        //inicializa
        private CD_Conexion Conexion;
        private Producto Producto;
        private List<Producto> listaProducto;


        public List<Producto> ListaProductos()
        {

            Conexion = new CD_Conexion();
            listaProducto = new List<Producto>();

            try
            {
                Conexion.SetConsultaProcedure("SpMostrar_Producto");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    //Producto = new Producto();

                    Producto = new Producto();
                    
                    //atributos propios

                    Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    Producto.Codigo = (string)Conexion.Lector["Codigo"];
                    Producto.Nombre = (string)Conexion.Lector["Nombre"];
                    Producto.Descripcion = (string)Conexion.Lector["Descripcion"];
                    Producto.Precio = (decimal)Conexion.Lector["Precio"];
                    Producto.FechaUltimaActualizacionPrecio = (DateTime)Conexion.Lector["FechaUltimaActualizacionPrecio"];
                    Producto.Stock = (int)Conexion.Lector["Stock"];
                    Producto.StockMinimo = (int)Conexion.Lector["StockMinimo"];
                    Producto.Estado = (bool)Conexion.Lector["Estado"];

                    Producto.Subcategoria = new Subcategoria();

                    //Producto.Subcategoria.Id_Subcategoria = (int)Conexion.Lector["Id_Subcategoria"];
                    Producto.Subcategoria.Nombre = (string)Conexion.Lector["Subcategoria"];


                    Producto.Marca = new Marca();
                    //Producto.Marca.Id_Marca = (int)Conexion.Lector["Id_Marca"];
                    Producto.Marca.Nombre = (string)Conexion.Lector["Marca"];


                    Producto.UnidadMedida = new UnidadMedida();
                    //Producto.UnidadMedida.Id_UnidadMedida = (int)Conexion.Lector["Id_UnidadMedida"];
                    Producto.UnidadMedida.Nombre = (string)Conexion.Lector["UnidadMedida"];

                    listaProducto.Add(Producto);
                }

                return listaProducto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }

        }


  

   
        public bool ValidarProducto(string Nombre)
        {
            Conexion = new CD_Conexion();
            try
            {
                Conexion.SetConsulta("SELECT COUNT(*) FROM Productos WHERE Codigo = @Codigo");
                Conexion.SetearParametro("@Nombre", Nombre);

                Conexion.EjecutarLectura();

                // Verificar si hay alguna fila devuelta por la consulta
                if (Conexion.Lector.HasRows)
                {
                    // Leer el valor del primer campo (que es el resultado del conteo)
                    Conexion.Lector.Read();
                    int count = Convert.ToInt32(Conexion.Lector[0]);
                    return count > 0;
                }
                else
                {
                    // Si no hay filas, no hay resultados, por lo que el cliente no existe
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        //metodo insertar

        public void InsertarProducto(Producto Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_Producto");

                Conexion.SetearParametro("@Codigo", Nuevo.Codigo);
                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Descripcion", Nuevo.Descripcion);
                Conexion.SetearParametro("@Precio", Nuevo.Precio);
                Conexion.SetearParametro("@FechaUltimaActualizacionPrecio", Nuevo.FechaUltimaActualizacionPrecio);
                Conexion.SetearParametro("@Stock", Nuevo.Stock);
                Conexion.SetearParametro("@StockMinimo", Nuevo.StockMinimo);
                Conexion.SetearParametro("@Estado", Nuevo.Estado);
                Conexion.SetearParametro("@Id_Subcategoria", Nuevo.Subcategoria.Id_Subcategoria);
                Conexion.SetearParametro("@Id_Marca", Nuevo.Marca.Id_Marca);
                Conexion.SetearParametro("@Id_UnidadMedida", Nuevo.UnidadMedida.Id_UnidadMedida);

                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }


        //metodo editar

        public void EditarProducto(Producto Producto)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEditar_Producto");

                Conexion.SetearParametro("@Id_Producto", Producto.Id_Producto);
                Conexion.SetearParametro("@Codigo", Producto.Codigo);
                Conexion.SetearParametro("@Nombre", Producto.Nombre);
                Conexion.SetearParametro("@Descripcion", Producto.Descripcion);
                Conexion.SetearParametro("@Precio", Producto.Precio);
                Conexion.SetearParametro("@FechaUltimaActualizacionPrecio", Producto.FechaUltimaActualizacionPrecio);
                Conexion.SetearParametro("@Stock", Producto.Stock);
                Conexion.SetearParametro("@StockMinimo", Producto.StockMinimo);
                Conexion.SetearParametro("@Estado", Producto.Estado);
                Conexion.SetearParametro("@Id_Subcategoria", Producto.Subcategoria.Id_Subcategoria);
                Conexion.SetearParametro("@Id_Marca", Producto.Marca.Id_Marca);
                Conexion.SetearParametro("@Id_UnidadMedida", Producto.UnidadMedida.Id_UnidadMedida);

                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }

        }

        //Metodo eliminar
        public void EliminarProducto(int Id_Producto)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_Producto");

                Conexion.SetearParametro("@Id_Producto", Id_Producto);


                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        //Metodo Buscar

        public List<Producto> BuscarProducto(string buscar)
        {
            Conexion = new CD_Conexion();
            listaProducto = new List<Producto>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_Producto");


                Conexion.SetearParametro("@Texto_Buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Producto = new Producto();
                    Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    Producto.Codigo = (string)Conexion.Lector["Codigo"];
                    Producto.Nombre = (string)Conexion.Lector["Nombre"];
                    Producto.Descripcion = (string)Conexion.Lector["Descripcion"];
                    Producto.Precio = (decimal)Conexion.Lector["Precio"];
                    Producto.FechaUltimaActualizacionPrecio = (DateTime)Conexion.Lector["FechaUltimaActualizacionPrecio"];
                    Producto.Stock = (int)Conexion.Lector["Stock"];
                    Producto.StockMinimo = (int)Conexion.Lector["StockMinimo"];
                    Producto.Estado = (bool)Conexion.Lector["Estado"];

                    Producto.Subcategoria = new Subcategoria();

                    //Producto.Subcategoria.Id_Subcategoria = (int)Conexion.Lector["Id_Subcategoria"];
                    Producto.Subcategoria.Nombre = (string)Conexion.Lector["Subcategoria"];


                    Producto.Marca = new Marca();
                    //Producto.Marca.Id_Marca = (int)Conexion.Lector["Id_Marca"];
                    Producto.Marca.Nombre = (string)Conexion.Lector["Marca"];


                    Producto.UnidadMedida = new UnidadMedida();
                    //Producto.UnidadMedida.Id_UnidadMedida = (int)Conexion.Lector["Id_UnidadMedida"];
                    Producto.UnidadMedida.Nombre = (string)Conexion.Lector["UnidadMedida"];

                    listaProducto.Add(Producto);
                }


                return listaProducto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
    }
}
