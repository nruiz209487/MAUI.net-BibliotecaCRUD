﻿using DAL;
using ENT_Bibloteca;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Biblioteca
{
    public class Service
    {
        #region Genero
        /// <summary>
        /// OBTIENE EL LISATDO COMPLETO DE GEENEROS 
        /// </summary>
        /// <returns>UNA List<Genero></returns>
        public static List<Genero> ObtenerListadoGeneros()
        {
            return ListadoDeGeneros.listadoCompletoGenerosDAL();
        }
        /// <summary>
        /// OBTIENE  UN GENERO DE LA DB USA EL ID PARA EL WHERE 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>INT CON EL NUMERO DE FILAS AFECTADAS</returns>
        public static Genero ObtenerGenero(int id)
        {
            Genero genero = null;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;

            try
            {
                conexion = clsConexionDB.getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    miComando.CommandText = "SELECT * FROM GenerosDeLibros WHERE Id = @id";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();

                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {
                            genero = new Genero
                            {
                                Id = (int)miLector["Id"],
                                Nombre = (string)miLector["Nombre"],
                                Descripcion = (string)miLector["Descripcion"]
                            };
                        }
                    }
                    miLector.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return genero;
        }
        #endregion

        #region Libros
        /// <summary>
        /// OBTIENE EL LISTADO FLITRADO POR GEENROS USA EL ID DEL GEENRO PARA EL WHERE 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>INT CON EL NUMERO DE FILAS AFECTADAS</returns>
        public static List<Libro> ObtenerListadoDeLibrosPorGenero(int id)
        {
            List<Libro> libros = new List<Libro>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;

            try
            {
                conexion = clsConexionDB.getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.Parameters.Add("@IdGenero", System.Data.SqlDbType.Int).Value = id;
                    miComando.CommandText = "SELECT * FROM Libros WHERE IdGenero = @IdGenero";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();

                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {
                            Libro libro = new Libro
                            {
                                Id = (int)miLector["Id"],
                                Titulo = (string)miLector["Titulo"],
                                Sinopsis = (string)miLector["Sinopsis"],
                                Autor = (string)miLector["Autor"],
                                fechaDeSalida = (DateTime)miLector["fechaDeSalida"],
                                IdGenero = (int)miLector["IdGenero"],
                                Img = (string)miLector["Img"]
                            };

                            libros.Add(libro);
                        }
                    }
                    miLector.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return libros;
        }
        /// <summary>
        /// OBTIENE  UN LIBRO DE LA DB USA EL ID PARA EL WHERE 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>INT CON EL NUMERO DE FILAS AFECTADAS</returns>
        public static Libro ObtenerLibro(int id)
        {
            Libro libro = null;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;

            try
            {
                conexion = clsConexionDB.getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    miComando.CommandText = "SELECT * FROM Libros WHERE Id = @id";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();

                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {
                            libro = new Libro
                            {
                                Id = (int)miLector["Id"],
                                Titulo = (string)miLector["Titulo"],
                                Sinopsis = (string)miLector["Sinopsis"],
                                Autor = (string)miLector["Autor"],
                                fechaDeSalida = (DateTime)miLector["fechaDeSalida"],
                                IdGenero = (int)miLector["IdGenero"],
                                Img = (string)miLector["Img"]
                            };
                        }
                    }
                    miLector.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return libro;
        }
        /// <summary>
        /// ELIMINA UN LIBRO DE LA DB USA EL ID PARA EL WHERE 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>INT CON EL NUMERO DE FILAS AFECTADAS</returns>
        public static int EliminarLibro(int id)
        {
            int filasAfectadas = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            try
            {
                conexion = clsConexionDB.getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    miComando.CommandText = "DELETE FROM Libros WHERE Id = @id";
                    miComando.Connection = conexion;
                    filasAfectadas = miComando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return filasAfectadas;
        }
        /// <summary>
        /// ANYADE UN NUEVO LIBRO A LA BD COJE LOS CAMPOS Y HACE UN INSERT 
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="sinopsis"></param>
        /// <param name="autor"></param>
        /// <param name="fechaDeSalida"></param>
        /// <param name="idGenero"></param>
        /// <param name="img"></param>
        /// <returns> INT CON EL NUMERO DE FILAS AFECTADAS </returns>
        public static int AnyadirLibro(string titulo, string sinopsis, string autor, DateTime fechaDeSalida, int idGenero, string img)
        {
            int filasAfectadas = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            try
            {
                conexion = clsConexionDB.getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.Parameters.Add("@titulo", System.Data.SqlDbType.VarChar).Value = titulo;
                    miComando.Parameters.Add("@sinopsis", System.Data.SqlDbType.VarChar).Value = sinopsis;
                    miComando.Parameters.Add("@autor", System.Data.SqlDbType.VarChar).Value = autor;
                    miComando.Parameters.Add("@fechaDeSalida", System.Data.SqlDbType.DateTime).Value = fechaDeSalida;  // Asegúrate de pasar la fecha correcta
                    miComando.Parameters.Add("@idGenero", System.Data.SqlDbType.Int).Value = idGenero;
                    miComando.Parameters.Add("@img", System.Data.SqlDbType.VarChar).Value = img;

                    miComando.CommandText = "INSERT INTO Libros (Titulo, Sinopsis, Autor, fechaDeSalida, IdGenero, Img) " +
                        "VALUES (@titulo, @sinopsis, @autor, @fechaDeSalida, @idGenero, @img)";
                    miComando.Connection = conexion;

                    filasAfectadas = miComando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return filasAfectadas;
        }

        /// <summary>
        /// MODIFICA UN LIBRO EN LA DB US EL ID COMO CAMPO PARA EL WHERE 
        /// </summary>
        /// <param name="libro"></param>
        /// <returns> INT CON EL NUMERO DE FILAS AFECTADAS </returns>
        public static int ModificarLibro(Libro libro)
        {
            int filasAfectadas = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            try
            {
                conexion = clsConexionDB.getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = libro.Id;
                    miComando.Parameters.Add("@titulo", System.Data.SqlDbType.VarChar).Value = libro.Titulo;
                    miComando.Parameters.Add("@sinopsis", System.Data.SqlDbType.VarChar).Value = libro.Sinopsis;
                    miComando.Parameters.Add("@autor", System.Data.SqlDbType.VarChar).Value = libro.Autor;
                    miComando.Parameters.Add("@fechaDeSalida", System.Data.SqlDbType.DateTime).Value = libro.fechaDeSalida;
                    miComando.Parameters.Add("@idGenero", System.Data.SqlDbType.Int).Value = libro.IdGenero;
                    miComando.Parameters.Add("@img", System.Data.SqlDbType.VarChar).Value = libro.Img;

                    miComando.CommandText = "UPDATE Libros " +
                        "SET Titulo = @titulo, Sinopsis = @sinopsis, Autor = @autor, fechaDeSalida = @fechaDeSalida, " +
                        "IdGenero = @idGenero, Img = @img WHERE Id = @id";
                    miComando.Connection = conexion;
                    filasAfectadas = miComando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return filasAfectadas;
        }
        #endregion
    }
}
