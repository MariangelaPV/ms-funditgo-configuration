using Configuration.Domain.ValueObjects;
using SharedKernel.Core;

namespace Configuration.Domain.Model.Rules
{
    public class ChangeProyectoStatusRule : IBussinessRule
    {
        private readonly EstadoValue oldStatus;
        private readonly EstadoValue newStatus;

        public ChangeProyectoStatusRule(EstadoValue oldStatus, EstadoValue newStatus)
        {
            this.oldStatus = oldStatus;
            this.newStatus = newStatus;
        }

        public string Message => "No se puede cambiar del estado " + oldStatus.ToString() +
            "al estado " + newStatus.ToString();

        public bool IsValid()
        {
            if ((newStatus == EstadoValue.borrador || newStatus == EstadoValue.revision) && 
                oldStatus == EstadoValue.creado)
                return true;

            if (newStatus == EstadoValue.revision && 
                (oldStatus == EstadoValue.borrador || oldStatus == EstadoValue.modificado))
                return true;

            if (newStatus == EstadoValue.aprobado || newStatus == EstadoValue.rechazado || 
                newStatus == EstadoValue.observado &&
                oldStatus == EstadoValue.revision)
                return true;

            if (newStatus == EstadoValue.modificado && oldStatus == EstadoValue.observado)
                return true;

            return false;
        }
    }
}
