using Solicitudes.Domain.Enums;

namespace Solicitudes.Domain.Entities;

public class Solicitud
{
  public Guid Id{ get; private set;}
  public string Description {get ; private set;} = string.Empty;
  public DateTime FechaCreacion { get; private set; }
  public EstadoSolicitud Estado { get; private set; }
  public Guid UsuarioIdCreadorId { get; private set; }

 
}
