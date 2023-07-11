using Configuration.Domain.Events;
using Configuration.Domain.Model.Rules;
using Configuration.Domain.ValueObjects;
using SharedKernel.Core;
using System;

namespace Configuration.Domain.Model.Proyectos
{
    public class Proyecto : AggregateRoot
    {
        public TextoValue Nombre { get; private set; }
        public EstadoValue Estado { get; private set; }
        public DateTime FechaCreado { get; private set; }
        public DateTime? FechaBorrador { get; private set; }
        public DateTime? FechaRevision { get; private set; }
        public DateTime? FechaObservado { get; private set; }
        public DateTime? FechaModificado { get; private set; }
        public DateTime? FechaAprobado { get; private set; }
        public DateTime? FechaRechazado { get; private set; }

        public Proyecto(string nombreProyecto) 
        {
            Id = Guid.NewGuid();
            Nombre = nombreProyecto;
            Estado = EstadoValue.creado;
            FechaCreado = DateTime.Now;
        }

        public Proyecto(string nombreProyecto, string estado, DateTime fechaCreacion)
        {
            Id = Guid.NewGuid();
            Nombre = nombreProyecto;
            Estado = estado;
            FechaCreado = fechaCreacion;
        }

        public Proyecto() { }

        public void BorradorProyecto(string nombre, string estado)
        {
            CheckRule(new ChangeProyectoStatusRule(Estado, EstadoValue.borrador));
            FechaBorrador = DateTime.Now;
            Estado = EstadoValue.borrador;

            var evento = new EstadoProyectoActualizado(nombre, estado);
            AddDomainEvent(evento);
        }

        public void RevisarProyecto(string nombre, string estado)
        {
            CheckRule(new ChangeProyectoStatusRule(Estado, EstadoValue.revision));
            FechaRevision = DateTime.Now;
            Estado = EstadoValue.revision;

            var evento = new EstadoProyectoActualizado(nombre, estado);
            AddDomainEvent(evento);
        }
        public void ObservarProyecto(string nombre, string estado)
        {
            CheckRule(new ChangeProyectoStatusRule(Estado, EstadoValue.observado));
            FechaObservado = DateTime.Now;
            Estado = EstadoValue.observado;

            var evento = new EstadoProyectoActualizado(nombre, estado);
            AddDomainEvent(evento);
        }
        public void ModificarProyecto(string nombre, string estado)
        {
            CheckRule(new ChangeProyectoStatusRule(Estado, EstadoValue.modificado));
            FechaModificado = DateTime.Now;
            Estado = EstadoValue.modificado;

            var evento = new EstadoProyectoActualizado(nombre, estado);
            AddDomainEvent(evento);
        }
        public void AprobarProyecto(string nombre, string estado)
        {
            CheckRule(new ChangeProyectoStatusRule(Estado, EstadoValue.aprobado));
            FechaAprobado = DateTime.Now;
            Estado = EstadoValue.aprobado;

            var evento = new EstadoProyectoActualizado(nombre, estado);
            AddDomainEvent(evento);
        }

        public void RechazarProyecto(string nombre, string estado)
        {
            CheckRule(new ChangeProyectoStatusRule(Estado, EstadoValue.rechazado));
            FechaRechazado = DateTime.Now;
            Estado = EstadoValue.rechazado;

            var evento = new EstadoProyectoActualizado(nombre, estado);
            AddDomainEvent(evento);
        }
    }
}
