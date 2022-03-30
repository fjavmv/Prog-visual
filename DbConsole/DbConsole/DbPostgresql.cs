using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//paquete para usar db postgresql
using Npgsql;


namespace EjemploDb
{
    internal class DbPostgresql
    {
        
        //Datos de configuración para acceder a la db
        static string servidor = "localhost";
        static string dbName = "dbtest";
        static string usuario = "postgres";
        static string password = "A9BXZWC173";
        static string puerto = "5432";
        
        //string cadenaDeConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + dbName + ";";

        //Instancia de la clase NpgsqlConnection
      //  NpgsqlConnection conn = new NpgsqlConnection();

        //Método que permitirá establecer la conexión con la db
        /*public NpgsqlConnection conectarDb()
        {
            try
            {
                //Verificamos que no exista una conexión actual
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.ConnectionString = cadenaDeConexion;
                    conn.Open();
                    Console.WriteLine("Se conectó correctamente a la base de datos");
                }
                else
                {
                    Console.WriteLine("La conexión ya esta establecida");
                }
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No fue posible establcer la conexión",e);
            }

            return conn;
        }

        //Método para desconectar db
        public NpgsqlConnection desconectar()
        {
            try
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Se ha cerrado la conexión a la DB");
                }
                else
                {
                    Console.WriteLine("La conexión ya ha sido cerrada");
                }
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("Error al cerrar la conexión {0}",e);
            }

            return conn;
        }


        //Método que permite la consulta de datos
        public void consultarTodo()
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT * FROM film ORDER BY film_id ASC;";
                NpgsqlCommand command = new NpgsqlCommand(query, conn);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++) {
                        Console.WriteLine(dataReader[i]);
                    }

                }

              
            }
        }

        //Método que permite la consulta de datos utilizando adapter
        public List<Modelo> ConsultaDos()
        {
            List<Modelo> list = new List<Modelo>();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT * FROM film ORDER BY film_id ASC;";
                NpgsqlCommand command = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Modelo modelo = new Modelo();
                    modelo.Film_Id = reader.GetInt32(0);
                    modelo.Title = reader.GetString(1);
                    modelo.Description = reader.GetString(2);
                    modelo.Release_Year = reader.GetInt32(3);
                    modelo.Lenguaje_Id = reader.GetInt32(4);    
                    modelo.Rental_Duration = reader.GetInt32(5);
                    list.Add(modelo);
                }

            }
            return list;
        }*/

       
        public void configuracion()
        {
            
            try
            {
                var estado = crearDb();

                if (estado.State == System.Data.ConnectionState.Closed)
                {
                   CrearTablaDb();
                }
               
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }

        private NpgsqlConnection crearDb()
        {

            // 1. Cadena de conexión para crear la db
            string cadenaDeConexionDb = "server= localhost; port= 5432; user id= postgres; password= A9BXZWC173;";
            
            //2. Query para crear la db
            const string QUERY_CREATE_DB = "CREATE DATABASE dbtest " + "WITH OWNER = postgres " + "ENCODING = 'UTF8' " + "CONNECTION LIMIT = -1;";

            //3. Creamos una instancia de la clase  NpgsqlConnection  para establecer la conexión
            NpgsqlConnection dbConexion = new NpgsqlConnection(cadenaDeConexionDb); // Recibe cadena de conexión al servidor

            //4.Creamos una instancia de NpgsqlCommand para crear la db
            NpgsqlCommand npgsqlCommandQuery  = new NpgsqlCommand(QUERY_CREATE_DB, dbConexion);

            //5. Abrimos la conexión para crear la DB
            try
            {
                //Verificamos el estado de la conexión
                if (dbConexion.State == System.Data.ConnectionState.Closed)
                {
                    dbConexion.Open();
                    Console.WriteLine("La conexion se ha realizado de forma exitosa......");
                }
                else
                {
                    Console.WriteLine("La conexion ya se ha realizado......");
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //6. Creamos la DB
            try
            {
                //Verificamos si la conexión se ha realizado
                if (dbConexion.State == System.Data.ConnectionState.Open)
                {
                    npgsqlCommandQuery.ExecuteNonQuery();
                    Console.WriteLine("Se ha creado la base de datos.......");
                }
            }
            catch(NpgsqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            // 7. Cerramos la conexión
            desconectar(dbConexion);
            return dbConexion;
        }

        private void CrearTablaDb()
        {
            // 1. Cadena de conexión para crear la tabla
            string cadenaDeConexionTabla = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + dbName + ";";

            //2. Creamos una instancia de la clase  NpgsqlConnection  para establecer la conexión
            NpgsqlConnection dbConectionTabla = new NpgsqlConnection(cadenaDeConexionTabla); // Recibe cadena de conexión al la db para la tabla

            //3. Query para crear la tabla
            const string QUERY_CREATE_TABLA_DB = "CREATE TABLE public.videogame (game_id SERIAL," +
                "game_name CHARACTER VARYING(30) NOT NULL," +
                "game_description CHARACTER VARYING(500) NOT NULL," +
                "release_year BIGINT NOT NULL," +
                "CONSTRAINT pk_game_id PRIMARY KEY(game_id)" +
                "); ";
            //4. Creamos una instancia de NpgsqlCommand para establecer la conexión
            NpgsqlCommand commandQueryTabla = new NpgsqlCommand(QUERY_CREATE_TABLA_DB,dbConectionTabla);
            
            // 5. Abrimos la conexión para crear la tabla 
            try
            {
                //Verificamos el estado de la conexión
                if(dbConectionTabla.State == System.Data.ConnectionState.Closed)
                {
                    dbConectionTabla.Open();
                    Console.WriteLine("La conexion esta abierta....");
                }
                else
                {
                    Console.WriteLine("La conexion esta abierta....");
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            //6. Creamos la tabla en la DB
            try
            {
                //Verificamos el estado de la conexión
                if(dbConectionTabla.State == System.Data.ConnectionState.Open)
                {
                    commandQueryTabla.ExecuteNonQuery();
                    Console.WriteLine("Tabla creada........");
                }
                    
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            //7. Cerramos conexión
            desconectar(dbConectionTabla);            
        }


        //Insertar elementos a la Db
        public void insertar(ModeloGames mGame)
        {
            
            // 1. Cadena de conexión para crear la tabla
            string cadenaDeConexionTabla = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + dbName + ";";

            // 2. Creamos una instancia de la clase NpgsqlConnection
            NpgsqlConnection connectionInsertarElement = new NpgsqlConnection(cadenaDeConexionTabla);


            //3. Creamos una instancia de la clase ModeloGames
            //ModeloGames mGame = new ModeloGames();
            //4. Creamos query para insertar elementos en la db
            string QUERY_INSERT_ELEMENTOS = String.Format("INSERT INTO videogame (game_name, game_description, release_year) VALUES ('{0}', '{1}', {2});", mGame.GameName, mGame.GameDescription, mGame.ReleaseYear);
            //5.Creamos uns instancia de NpgsqlWrite
            NpgsqlCommand commandInsert = new NpgsqlCommand(QUERY_INSERT_ELEMENTOS, connectionInsertarElement);


            //6. Abrir la conexión a la db
            try
            {
                if(connectionInsertarElement.State == System.Data.ConnectionState.Closed)
                {
                    connectionInsertarElement.Open();
                    Console.WriteLine("La conexion se ha abierto........");
                }
                else
                {
                    Console.WriteLine("La conexion ya se encuentra abierta.....");
                }
            }
            catch(NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //7. Insertamos elementos
            try
            {
                if(connectionInsertarElement.State == System.Data.ConnectionState.Open)
                {
                    commandInsert.ExecuteNonQuery();
                    Console.WriteLine("Se ha guardado tu informacion.......");
                }
            }
            catch(NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            desconectar(connectionInsertarElement);
           
        }

        //Método que permite la consulta de datos
        public void consultarTodo()

        {
            // 1. Cadena de conexión para crear la tabla
            string cadenaDeConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + dbName + ";";

            // 2. Creamos una instancia de la clase NpgsqlConnection
            NpgsqlConnection connectionConsultar = new NpgsqlConnection(cadenaDeConexion);

            string query = "SELECT * FROM videogame ORDER BY game_id ASC;";

            NpgsqlCommand commandConsultar = new NpgsqlCommand(query, connectionConsultar);

            //Establecer conexion
            try
            {
               if(connectionConsultar.State == System.Data.ConnectionState.Closed)
                {
                    connectionConsultar.Open();
                    Console.WriteLine("La conexion se ha abierto........");

                }
                else
                {
                    Console.WriteLine("La conexion ya se encuentra abierta.....");
                }

            }
            catch(NpgsqlException ex)
            {

                Console.WriteLine(ex.Message);
            }

            //Query
            try
            {
                if (connectionConsultar.State == System.Data.ConnectionState.Open)
                {
                    NpgsqlDataReader dataReader = commandConsultar.ExecuteReader();
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            Console.WriteLine(dataReader[i]);
                        }

                    }


                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            desconectar(connectionConsultar);
        }

        public ModeloGames ConsultaDos(int game_id)
        {
           
            ModeloGames mGames = new ModeloGames();
            //List<ModeloGames> list = new List<ModeloGames>();

            //Configuración para conectarse a la db
            // 1. Cadena de conexión para crear la tabla
            string cadenaDeConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + dbName + ";";
            
            //3. Instancia de NpgsqlConnection
            NpgsqlConnection connectionDos = new NpgsqlConnection(cadenaDeConexion);
            //4. consulta
            string QUERY_CONSULTA = string.Format("SELECT game_id, game_name, game_description, release_year FROM videogame WHERE game_id = {0};",game_id);
            //5. Instancia de NpgsqlCommand
            NpgsqlCommand commandConsultaDos = new NpgsqlCommand(QUERY_CONSULTA,connectionDos);

            //6 Abrimos la conexion

            try
            {
                if (connectionDos.State == System.Data.ConnectionState.Closed)
                {
                    connectionDos.Open();
                    Console.WriteLine("Se ha realizado la conexion exitosa.........");
                }
                else
                {
                    Console.WriteLine("Ya hay una conexion establecida.........");
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //7. ejecutamos query
            try
            {
                if(connectionDos.State == System.Data.ConnectionState.Open)
                {
                    NpgsqlDataReader dataReader2 = commandConsultaDos.ExecuteReader();
                    while (dataReader2.Read())
                    {
                        Console.WriteLine("Almacenando datos......");
                        mGames.GameId = dataReader2.GetInt16(0);
                        mGames.GameName = dataReader2.GetString(1);
                        mGames.GameDescription = dataReader2.GetString(2);
                        mGames.ReleaseYear = dataReader2.GetInt32(3);

                       // list.Insert(mGames);
                    }
                }
               
            }
            catch(NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            desconectar(connectionDos);
            return mGames;
        }

        public void eliminar(int game_id)
        {

            ModeloGames mGames = new ModeloGames();
            //List<ModeloGames> list = new List<ModeloGames>();

            //Configuración para conectarse a la db
            // 1. Cadena de conexión para crear la tabla
            string cadenaDeConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + dbName + ";";

            //3. Instancia de NpgsqlConnection
            NpgsqlConnection connectionDos = new NpgsqlConnection(cadenaDeConexion);
            //4. consulta
            string QUERY_CONSULTA = string.Format("DELETE FROM videogame WHERE game_id = {0};", game_id);
            //5. Instancia de NpgsqlCommand
            NpgsqlCommand commandDelete = new NpgsqlCommand(QUERY_CONSULTA, connectionDos);

            //6 Abrimos la conexion

            try
            {
                if (connectionDos.State == System.Data.ConnectionState.Closed)
                {
                    connectionDos.Open();
                    Console.WriteLine("Se ha realizado la conexion exitosa.........");
                }
                else
                {
                    Console.WriteLine("Ya hay una conexion establecida.........");
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //7. ejecutamos query
            try
            {
                if (connectionDos.State == System.Data.ConnectionState.Open)
                {
                    commandDelete.ExecuteNonQuery();
                    Console.WriteLine("Registro eliminado.....");
                }

            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            desconectar(connectionDos);

        }




        //Método para desconectar db
        public void desconectar(NpgsqlConnection connection)
        {
         
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Se ha cerrado la conexion a la DB");
                }
                else
                {
                    Console.WriteLine("La conexion ya ha sido cerrada");
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexion {0}", ex);
            }

        }

    }
}
