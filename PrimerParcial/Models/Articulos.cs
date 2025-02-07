﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models
{
    public class Articulos
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, int.MaxValue,ErrorMessage = "Value must be a positive number.")]
        [Required]
        public int Price { get; set; }
        [Required]
        public int Stock { get; set; }
        public string Description { get; set; }

        //Relationship with model Clasificacion_Articulos
        [Required]
        public int ClasificacionArticulosId { get; set; }
        public Clasificacion_Articulos ClasificacionArticulos { get; set; }

        //Relationship with model Marcas
        [Required]
        [Display(Name ="Marca")]
        public int MarcaId { get; set; }
        public Marcas Marca { get; set; }

        //Relation with Unidades de Medida model
        public int UnidadesDeMedidaId { get; set; }
        public Unidades_de_Medida UnidadesDeMedida { get; set; }
    }
}
