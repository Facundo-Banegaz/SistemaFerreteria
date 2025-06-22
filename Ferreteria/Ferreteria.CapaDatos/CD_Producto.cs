using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Conexion.SetConsultaProcedure("SpMostrar_Productos");

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
                    Producto.Subcategoria.Categoria = new Categoria();
                    Producto.Subcategoria.Id_Subcategoria = (int)Conexion.Lector["Id_Subcategoria"];
                    //Intentar relacion id da una exception
                    Producto.Subcategoria.Categoria.Id_Categoria = (int)Conexion.Lector["Id_Categoria"];

                    Producto.Subcategoria.Nombre = (string)Conexion.Lector["Subcategoria"];


                    Producto.Marca = new Marca();
                    Producto.Marca.Id_Marca = (int)Conexion.Lector["Id_Marca"];
                    Producto.Marca.Nombre = (string)Conexion.Lector["Marca"];


                    Producto.UnidadMedida = new UnidadMedida();
                    Producto.UnidadMedida.Id_UnidadMedida = (int)Conexion.Lector["Id_UnidadMedida"];
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



        public bool ValidarProducto(string Codigo)
        {
            Conexion = new CD_Conexion();
            try
            {
                Conexion.SetConsulta("SELECT COUNT(*) FROM Productos WHERE Codigo = @Codigo");
                Conexion.SetearParametro("@Codigo", Codigo);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());

                return count > 0;
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
                // Validación: si ya existe, lanzar excepción
                if (ValidarProducto(Nuevo.Codigo))
                    throw new Exception("El código ingresado ya está en uso por otro producto en el sistema.\n\nCada producto debe tener un código único para evitar conflictos.");
             

                Conexion.SetConsultaProcedure("SpInsertar_Producto");

                Conexion.SetearParametro("@Codigo", Nuevo.Codigo);
                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Descripcion", Nuevo.Descripcion);
                Conexion.SetearParametro("@Precio", Nuevo.Precio);
                Conexion.SetearParametro("@FechaUltimaActualizacionPrecio", Nuevo.FechaUltimaActualizacionPrecio);
              
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

        //actualizar precio
        public void ActualizarPrecio(int Id_Producto, decimal Precio)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpActualizar_Precio");

                Conexion.SetearParametro("@Id_Producto", Id_Producto);
               
                Conexion.SetearParametro("@Precio", Precio);
           

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

                // Validar que el nuevo nombre no exista en otra categoría
                Conexion.SetConsulta("SELECT COUNT(*) FROM Productos WHERE Codigo = @Codigo AND Id_Producto != @Id_Producto");
                Conexion.SetearParametro("@Codigo", Producto.Codigo);
                Conexion.SetearParametro("@Id_Producto", Producto.Id_Producto);


                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                if (count > 0)
                    throw new Exception("El código ingresado ya está en uso por otro producto en el sistema.\n\nCada producto debe tener un código único para evitar conflictos.");


                Conexion.SetConsultaProcedure("SpEditar_Producto");

                Conexion.SetearParametro("@Id_Producto", Producto.Id_Producto);
                Conexion.SetearParametro("@Codigo", Producto.Codigo);
                Conexion.SetearParametro("@Nombre", Producto.Nombre);
                Conexion.SetearParametro("@Descripcion", Producto.Descripcion);
                Conexion.SetearParametro("@Precio", Producto.Precio);
                Conexion.SetearParametro("@FechaUltimaActualizacionPrecio", Producto.FechaUltimaActualizacionPrecio);
                
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
                Conexion.SetConsultaProcedure("SpBuscar_Productos");


                Conexion.SetearParametro("@TextoBuscar", buscar);


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
                    Producto.Subcategoria.Categoria = new Categoria();
                    Producto.Subcategoria.Categoria.Id_Categoria = (int)Conexion.Lector["Id_Categoria"];

                    Producto.Subcategoria.Id_Subcategoria = (int)Conexion.Lector["Id_Subcategoria"];
                    Producto.Subcategoria.Nombre = (string)Conexion.Lector["Subcategoria"];


                    Producto.Marca = new Marca();
                    Producto.Marca.Id_Marca = (int)Conexion.Lector["Id_Marca"];
                    Producto.Marca.Nombre = (string)Conexion.Lector["Marca"];


                    Producto.UnidadMedida = new UnidadMedida();
                    Producto.UnidadMedida.Id_UnidadMedida = (int)Conexion.Lector["Id_UnidadMedida"];
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
