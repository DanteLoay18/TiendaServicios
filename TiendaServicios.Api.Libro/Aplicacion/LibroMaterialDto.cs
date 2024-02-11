﻿using System;

namespace TiendaServicios.Api.Libro.Aplicacion
{
    public class LibroMaterialDto
    {
        public Guid? LibreriaMaterialId { get; set; }
        public string titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Guid? AutorLibro { get; set; }
    }
}