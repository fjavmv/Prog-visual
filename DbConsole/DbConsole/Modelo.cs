using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDb
{
    internal class Modelo
    {
        private int film_id;
        private string title;
        private string description;
        private int release_year;
        private int lenguaje_id;
        private int rental_duration;

        //Método constructor de la clase Modelo
        public Modelo()
        {

        }

        //Métodos get y set

        public int Film_Id
        {
            get { return film_id; }
            set { film_id = value; }
        }
        public string Title 
        { 
            get { return title; }
            set { title = value; }
        }
        public string Description 
        { 
            get { return description; }
            set { description = value; }
        }        
        public int Release_Year
        {
            get { return release_year; }
            set { release_year = value; }
        }
        public int Lenguaje_Id
        {
            get { return lenguaje_id; }
            set { lenguaje_id = value; }
        }
        public int Rental_Duration
        {
            get { return rental_duration; }
            set { rental_duration = value; }
        }


    }
}
