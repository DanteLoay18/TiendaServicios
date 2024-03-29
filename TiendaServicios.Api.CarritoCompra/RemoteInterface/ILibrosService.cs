﻿using System;
using System.Threading.Tasks;
using TiendaServicios.Api.CarritoCompra.RemoteModel;

namespace TiendaServicios.Api.CarritoCompra.RemoteInterface
{
    public interface ILibrosService
    {
       Task<(bool Resultado, LibroRemote Libro, string ErrorMessage)> GetLibro(Guid LibroId);
    }
}
