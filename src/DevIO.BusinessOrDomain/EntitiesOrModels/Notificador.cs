
using DevIO.BusinessOrDomain.Interfaces;
using DevIO.BusinessOrDomain.Notifications;

namespace DevIO.BusinessOrDomain.EntitiesOrModels
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;

        public Notificador(List<Notificacao> notificacoes)
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
