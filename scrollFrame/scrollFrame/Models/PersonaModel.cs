using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace scrollFrame.Models
{
    public class PersonaModel 
    {
        //DATA ANOTATIONS
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string tipoIdentificacion { get; set; }
        public string numIdentificacion { get; set; }
        public string telefono { get; set; }
        public bool terminos { get; set; }
    }
}
