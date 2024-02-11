using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TiendaServicios.Api.CarritoCompra.Modelo;
using TiendaServicios.Api.CarritoCompra.Persistencia;

namespace TiendaServicios.Api.CarritoCompra.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public DateTime FechaCreacionSesion { get; set; }

            public List<string> ProductoLista { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            public readonly CarritoContexto _context;

            public Manejador(CarritoContexto context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var carritoSesion = new CarritoSesion
                {
                    FechaCreacion = request.FechaCreacionSesion
                };

                _context.CarritoSesion.Add(carritoSesion);
                var value = await _context.SaveChangesAsync();

                if(value == 0)
                {
                    throw new Exception("Errores en la insercion ");
                }
                int id = carritoSesion.CarritoSesionId;

                foreach (var producto in request.ProductoLista)
                {

                    var carritoSesionDetalle = new CarritoSesionDetalle
                    {
                        CarritoSesionId = id,
                        FechaCreacion =DateTime.Now,
                        ProductoSeleccionado = producto
                    };

                    _context.CarritoSesionDetalle.Add(carritoSesionDetalle);
                    

                }
                value = await _context.SaveChangesAsync();

                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("Errores en la insercion ");
            }
        }
    }
}
