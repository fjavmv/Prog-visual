using System;


namespace EjemploDb
{
    static class Principal
    {
       

        static void Main()
        {
              
             //Creamos una instancia del la clase NpgsqlConnection
             DbPostgresql dbPostgresql = new DbPostgresql();
          
            //Menú de opciones
            Console.WriteLine("Seleccione una opción \n Opción 1 conectar a base de datos \n " +
                "Opción 2 consultar base de datos");

            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    //dbPostgresql.conectarDb();
                    // dbPostgresql.consultarTodo();
                    //  dbPostgresql.configuracion();
                    /*ModeloGames mGames = new ModeloGames();
                    mGames.GameName = "Halo";
                    mGames.GameDescription = "Halo  es un videojuego de disparos en primera persona desarrollado por Bungie Studios y lanzado para la consola Xbox en 2004.​ ";
                    mGames.ReleaseYear = 2001;

                      dbPostgresql.insertar(mGames);
                    //dbPostgresql.consultarTodo();*/



                    /*ModeloGames mGames = new ModeloGames();
                    mGames = dbPostgresql.ConsultaDos(2);
                    Console.WriteLine(mGames.ToString());*/

                    dbPostgresql.eliminar(2);
                    




                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Opción invalidad {0}",op);
                    break;
                  
            }
            
        }

    }

}