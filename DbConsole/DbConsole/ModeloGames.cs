using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDb
{
    internal class ModeloGames
    {
        private int game_id;
        private string game_name;
        private string game_description;
        private int release_year;

        public int GameId
        {
            get { return game_id; }
            set { game_id = value; }
        }
        public string GameName
        {
            get { return game_name; }
            set { game_name = value; }
        }

       public string GameDescription
        {
            get { return game_description; }
            set { game_description = value; }
        }

        public int ReleaseYear
        {
            get { return release_year; }
            set { release_year = value; }
        }

        override
        public String ToString()
        {
            return string.Format("El id del juego es:{0}\n"+"El nombre del juego es:{1}\n"+"Descripción:{2}\n"+"Año de lanzamiento:{3}",GameId,GameName,GameDescription,ReleaseYear);
    
        }
        
    }
}
