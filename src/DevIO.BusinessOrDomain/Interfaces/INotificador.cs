


using DevIO.BusinessOrDomain.Notifications;

namespace DevIO.BusinessOrDomain.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificacoes();

        void Handle(Notificacao notificacao);

    }
}
