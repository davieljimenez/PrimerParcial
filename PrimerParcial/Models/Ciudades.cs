﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models
{
    public class Ciudades
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relation with Paises model
        public int PaisId { get; set; }
        public Paises Pais { get; set; }

        //Relation with Ubicaciones model
        public int UbicacionesId { get; set; }
        public Ubicaciones Ubicaciones { get; set; }
    }
}
