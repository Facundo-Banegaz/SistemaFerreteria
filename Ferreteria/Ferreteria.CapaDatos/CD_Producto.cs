using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.CapaDominio.DTOs;

namespace Ferreteria.CapaDatos
{
    public class CD_Producto
    {
        //inicializa
        private CD_Conexion Conexion;
        private Producto Producto;
        private List<Producto> listaProducto;
        private ProductoInventarioBajoDto ProductoInventarioBajoDto;
        private ProductoAvanzadoDto ProductoAvanzado;

        private List<ProductoInventarioBajoDto> listaProductoInventarioBajoDto;

        private ProductoConVencimientoDto ProductoConVencimientoDto;
        private List<ProductoConVencimientoDto> listaProductosConVencimientoDto;
        private List<ProductoAvanzadoDto> listaProductoAvanzadoDto;
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
                    Producto.Stock = (decimal)Conexion.Lector["Stock"];
                    Producto.StockMinimo = (decimal)Conexion.Lector["StockMinimo"];
                    Producto.Estado = (bool)Conexion.Lector["Estado"];
                    Producto.RequiereVencimiento = (bool)Conexion.Lector["RequiereVencimiento"];
                    Producto.ActualizarPrecioAutomaticamente = (bool)Conexion.Lector["ActualizarPrecioAutomaticamente"];
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
                    Producto.UnidadMedida.PermiteDecimales = (bool)Conexion.Lector["PermiteDecimales"];
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

        public List<ProductoAvanzadoDto> ConsultaMostrarProductosAvanzado ()
        {

            Conexion = new CD_Conexion();
            listaProductoAvanzadoDto = new List<ProductoAvanzadoDto>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_ConsultaMostrarProductosAvanzado");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    ProductoAvanzado  = new ProductoAvanzadoDto();

                    // Atributos propios
                    ProductoAvanzado.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    ProductoAvanzado.Codigo = (string)Conexion.Lector["Codigo"];
                    ProductoAvanzado.Nombre = (string)Conexion.Lector["Nombre"];
                 
                    ProductoAvanzado.Precio = (decimal)Conexion.Lector["Precio"];
                
                    ProductoAvanzado.Stock = (decimal)Conexion.Lector["Stock"];
                    ProductoAvanzado.StockMinimo = (decimal)Conexion.Lector["StockMinimo"];
                    ProductoAvanzado.Estado = (bool)Conexion.Lector["Estado"];

                    // Subcategoría y categoría
          
                    ProductoAvanzado.Subcategoria = (string)Conexion.Lector["Subcategoria"];

                    ProductoAvanzado.Categoria = (string)Conexion.Lector["Categoria"]; // si tu SP lo devuelve

                   

                    ProductoAvanzado.Marca = (string)Conexion.Lector["Marca"];

                   

                    ProductoAvanzado.UnidadMedida = (string)Conexion.Lector["UnidadMedida"];


                    listaProductoAvanzadoDto.Add(ProductoAvanzado);
                }



                return listaProductoAvanzadoDto;
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


        public List<ProductoInventarioBajoDto> ListaProductosInventarioBajo()
        {

            Conexion = new CD_Conexion();
            listaProductoInventarioBajoDto = new List<ProductoInventarioBajoDto>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_ProductosInventarioBajo");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    ProductoInventarioBajoDto = new ProductoInventarioBajoDto();

                    //atributos propios


                    ProductoInventarioBajoDto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    ProductoInventarioBajoDto.Codigo = (string)Conexion.Lector["Codigo"];
                    ProductoInventarioBajoDto.Producto = (string)Conexion.Lector["Producto"];

                    ProductoInventarioBajoDto.Precio = (decimal)Conexion.Lector["Precio"];

                    ProductoInventarioBajoDto.Stock = (decimal)Conexion.Lector["Stock"];
                    ProductoInventarioBajoDto.StockMinimo = (decimal)Conexion.Lector["StockMinimo"];

           

                    ProductoInventarioBajoDto.Categoria = (string)Conexion.Lector["Categoria"];

                    ProductoInventarioBajoDto.Subcategoria = (string)Conexion.Lector["Subcategoria"];


             
                    ProductoInventarioBajoDto.Marca = (string)Conexion.Lector["Marca"];



                    ProductoInventarioBajoDto.UnidadMedida = (string)Conexion.Lector["UnidadMedida"];
             
                    listaProductoInventarioBajoDto.Add(ProductoInventarioBajoDto);
                }

                return listaProductoInventarioBajoDto;
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

        public List<ProductoConVencimientoDto> ListaProductosConVencimiento(string FiltroEstado)
        {

            Conexion = new CD_Conexion();
            listaProductosConVencimientoDto = new List<ProductoConVencimientoDto>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_ProductosVencimiento");
                Conexion.SetearParametro("@FiltroEstado", FiltroEstado);
               

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    ProductoConVencimientoDto = new ProductoConVencimientoDto();

                    //atributos propios


                    ProductoConVencimientoDto.Id_DetalleIngreso = (int)Conexion.Lector["Id_DetalleIngreso"];
                    ProductoConVencimientoDto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    ProductoConVencimientoDto.Codigo = (string)Conexion.Lector["Codigo"];
                    ProductoConVencimientoDto.Producto = (string)Conexion.Lector["Producto"];


                    ProductoConVencimientoDto.Stock = (decimal)Conexion.Lector["Stock"];
                    


                    ProductoConVencimientoDto.Marca = (string)Conexion.Lector["Marca"];


                    ProductoConVencimientoDto.FechaIngreso = (DateTime)Conexion.Lector["FechaIngreso"];

                    ProductoConVencimientoDto.FechaFabricacion = (DateTime)Conexion.Lector["FechaFabricacion"];


                    ProductoConVencimientoDto.FechaVencimiento = (DateTime)Conexion.Lector["FechaVencimiento"];

                    ProductoConVencimientoDto.CantidadLote = (decimal)Conexion.Lector["CantidadLote"];
                    ProductoConVencimientoDto.CantidadLoteVencida = (decimal)Conexion.Lector["CantidadLoteVencida"];
                    ProductoConVencimientoDto.DiasRestantes = (int)Conexion.Lector["DiasRestantes"];


                    ProductoConVencimientoDto.Estado = (string)Conexion.Lector["Estado"];


                    listaProductosConVencimientoDto.Add(ProductoConVencimientoDto);
                }

                return listaProductosConVencimientoDto;
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
                Conexion.SetearParametro("@FechaUltimaActualizacionPrecio", Nuevo.FechaUltimaActualizacionPrecio.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@Stock", Nuevo.Stock);
                Conexion.SetearParametro("@StockMinimo", Nuevo.StockMinimo);
                Conexion.SetearParametro("@Estado", Nuevo.Estado);
                Conexion.SetearParametro("@Id_Subcategoria", Nuevo.Subcategoria.Id_Subcategoria);
                Conexion.SetearParametro("@Id_Marca", Nuevo.Marca.Id_Marca);
                Conexion.SetearParametro("@Id_UnidadMedida", Nuevo.UnidadMedida.Id_UnidadMedida);
                Conexion.SetearParametro("@RequiereVencimiento", Nuevo.RequiereVencimiento);
                Conexion.SetearParametro("@ActualizarPrecioAutomaticamente", Nuevo.ActualizarPrecioAutomaticamente);
              
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
                Conexion.SetearParametro("@FechaUltimaActualizacionPrecio", Producto.FechaUltimaActualizacionPrecio.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@StockMinimo", Producto.StockMinimo);
                Conexion.SetearParametro("@Estado", Producto.Estado);
                Conexion.SetearParametro("@Id_Subcategoria", Producto.Subcategoria.Id_Subcategoria);
                Conexion.SetearParametro("@Id_Marca", Producto.Marca.Id_Marca);
                Conexion.SetearParametro("@Id_UnidadMedida", Producto.UnidadMedida.Id_UnidadMedida);
                Conexion.SetearParametro("@RequiereVencimiento", Producto.RequiereVencimiento);
                Conexion.SetearParametro("@ActualizarPrecioAutomaticamente", Producto.ActualizarPrecioAutomaticamente);

                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw new Exception("Error al editar el producto: " + ex.Message);
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
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Violación FK
                {
                    throw new Exception("No se puede eliminar este Producto porque está relacionada con otros registros.");
                }
                else
                {
                    throw;
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


        //Metodo descontar producto vencidos Masivo

        //Metodo descontar producto vencidos por lote
        public void DescontarProductoVencido(int Id_Usuario, int Id_DetalleIngreso)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("Sp_DescontarProductoVencido");
                Conexion.SetearParametro("@Id_Usuario", Id_Usuario);
                Conexion.SetearParametro("@Id_DetalleIngreso", Id_DetalleIngreso);
                Conexion.EjecutarAccion();
            }
            catch (SqlException sqlEx)
            {
                
                throw new Exception(sqlEx.Message);
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
                    Producto.Stock = (decimal)Conexion.Lector["Stock"];
                    Producto.StockMinimo = (decimal)Conexion.Lector["StockMinimo"];
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

        public List<ProductoAvanzadoDto> ConsultaBuscarProductoAvanzado(string textoBuscar)
        {
            Conexion = new CD_Conexion();
            listaProductoAvanzadoDto = new List<ProductoAvanzadoDto>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_ConsultaBuscar_ProductosAvanzado");
                Conexion.SetearParametro("@TextoBuscar", textoBuscar);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    ProductoAvanzadoDto producto = new ProductoAvanzadoDto();

                    // Atributos propios
                    producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    producto.Codigo = (string)Conexion.Lector["Codigo"];
                    producto.Nombre = (string)Conexion.Lector["Nombre"];

                    producto.Precio = (decimal)Conexion.Lector["Precio"];
          
                    producto.Stock = (decimal)Conexion.Lector["Stock"];
                    producto.StockMinimo = (decimal)Conexion.Lector["StockMinimo"];
                    producto.Estado = (bool)Conexion.Lector["Estado"];

                    // Subcategoría y categoría
           
                    producto.Subcategoria = (string)Conexion.Lector["Subcategoria"];
                
                    producto.Categoria = (string)Conexion.Lector["Categoria"];

                    producto.Marca = (string)Conexion.Lector["Marca"];

                    
                    producto.UnidadMedida = (string)Conexion.Lector["UnidadMedida"];

                    listaProductoAvanzadoDto.Add(producto);
                }

                return listaProductoAvanzadoDto;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        public List<ProductoInventarioBajoDto> BuscarProductosInventarioBajo(string buscar)
        {
            Conexion = new CD_Conexion();
            listaProductoInventarioBajoDto = new List<ProductoInventarioBajoDto>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_BuscarProductosInventarioBajo");


                Conexion.SetearParametro("@Busqueda", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    
                    ProductoInventarioBajoDto = new ProductoInventarioBajoDto();

                    //atributos propios


                    ProductoInventarioBajoDto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    ProductoInventarioBajoDto.Codigo = (string)Conexion.Lector["Codigo"];
                    ProductoInventarioBajoDto.Producto = (string)Conexion.Lector["Producto"];

                    ProductoInventarioBajoDto.Precio = (decimal)Conexion.Lector["Precio"];

                    ProductoInventarioBajoDto.Stock = (decimal)Conexion.Lector["Stock"];
                    ProductoInventarioBajoDto.StockMinimo = (decimal)Conexion.Lector["StockMinimo"];



                    ProductoInventarioBajoDto.Categoria = (string)Conexion.Lector["Categoria"];

                    ProductoInventarioBajoDto.Subcategoria = (string)Conexion.Lector["Subcategoria"];



                    ProductoInventarioBajoDto.Marca = (string)Conexion.Lector["Marca"];



                    ProductoInventarioBajoDto.UnidadMedida = (string)Conexion.Lector["UnidadMedida"];

                    listaProductoInventarioBajoDto.Add(ProductoInventarioBajoDto);
                }


                return listaProductoInventarioBajoDto;
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

        public List<ProductoConVencimientoDto> BuscarProductosConVencimiento(string filtroEstado,string buscar)
        {
            Conexion = new CD_Conexion();
            listaProductosConVencimientoDto = new List<ProductoConVencimientoDto>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_BuscarProductosVencimiento");


                Conexion.SetearParametro("@FiltroProducto", buscar);

                Conexion.SetearParametro("@FiltroEstado", filtroEstado);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    ProductoConVencimientoDto = new ProductoConVencimientoDto();

                    //atributos propios

                    ProductoConVencimientoDto.Id_DetalleIngreso = (int)Conexion.Lector["Id_DetalleIngreso"];
                    ProductoConVencimientoDto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    ProductoConVencimientoDto.Codigo = (string)Conexion.Lector["Codigo"];
                    ProductoConVencimientoDto.Producto = (string)Conexion.Lector["Producto"];


                    ProductoConVencimientoDto.Stock = (decimal)Conexion.Lector["Stock"];



                    ProductoConVencimientoDto.Marca = (string)Conexion.Lector["Marca"];


                    ProductoConVencimientoDto.FechaIngreso = (DateTime)Conexion.Lector["FechaIngreso"];

                    ProductoConVencimientoDto.FechaFabricacion = (DateTime)Conexion.Lector["FechaFabricacion"];


                    ProductoConVencimientoDto.FechaVencimiento = (DateTime)Conexion.Lector["FechaVencimiento"];

                    ProductoConVencimientoDto.CantidadLote = (decimal)Conexion.Lector["CantidadLote"];
                    ProductoConVencimientoDto.DiasRestantes = (int)Conexion.Lector["DiasRestantes"];

                    ProductoConVencimientoDto.Estado = (string)Conexion.Lector["Estado"];


                    listaProductosConVencimientoDto.Add(ProductoConVencimientoDto);
                }

                return listaProductosConVencimientoDto;
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

        //Metodo para Buscar Producto Por Codigo De Barras En Ingresos
        public Producto BuscarProductoPorCodigoEnIngresos(string Codigo)
        {
            // Conexión a base de datos
            Conexion = new CD_Conexion();


            try
            {
                Conexion.SetConsultaProcedure("SpBuscarProductoPorCodigoEnIngresos");


                Conexion.SetearParametro("@Codigo", Codigo);


                Conexion.EjecutarLectura();

                // Si hay al menos un Producto lo mostramos
                if (Conexion.Lector.Read())
                {
                    Producto = new Producto();
                    
                    Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    Producto.Nombre = (string)Conexion.Lector["Nombre"];
                    Producto.RequiereVencimiento = (bool)Conexion.Lector["RequiereVencimiento"];
                    Producto.ActualizarPrecioAutomaticamente = (bool)Conexion.Lector["ActualizarPrecioAutomaticamente"];


                    Producto.UnidadMedida = new UnidadMedida();
                   
                    Producto.UnidadMedida.PermiteDecimales = (bool)Conexion.Lector["PermiteDecimales"];

                }

                return Producto;
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
        public Producto BuscarProductoPorCodigoEnVentas(string Codigo)
        {
            // Conexión a base de datos
            Conexion = new CD_Conexion();


            try
            {
                Conexion.SetConsultaProcedure("SpBuscarProductoPorCodigoEnVentas");


                Conexion.SetearParametro("@Codigo", Codigo);


                Conexion.EjecutarLectura();

                // Si hay al menos un Producto lo mostramos
                if (Conexion.Lector.Read())
                {
                    Producto = new Producto();

                    Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    Producto.Nombre = (string)Conexion.Lector["Nombre"];
                    Producto.Precio = (decimal)Conexion.Lector["PrecioVenta"];
                    Producto.Stock = (decimal)Conexion.Lector["Stock"];
                   

                    Producto.UnidadMedida = new UnidadMedida();

                    Producto.UnidadMedida.PermiteDecimales = (bool)Conexion.Lector["PermiteDecimales"];

                }

                return Producto;
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
