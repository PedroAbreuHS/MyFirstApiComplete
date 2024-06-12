using DevIO.BusinessOrDomain.EntitiesOrModels;
using DevIO.BusinessOrDomain.Interfaces;
using DevIO.BusinessOrDomain.Notifications;
using FluentValidation;
using FluentValidation.Results;

namespace DevIO.BusinessOrDomain.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var item in validationResult.Errors)
            {
                Notificar(item.ErrorMessage);
            }
        }

        protected void Notificar(String mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected bool ExecutarValidacao<Tvalidacao, Tentidade>(Tvalidacao validacao, Tentidade entidade)
            where Tvalidacao : AbstractValidator<Tentidade>
            where Tentidade : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid)
            {
                return true;
            }

            Notificar(validator);

            return false;
        }
    }
}
