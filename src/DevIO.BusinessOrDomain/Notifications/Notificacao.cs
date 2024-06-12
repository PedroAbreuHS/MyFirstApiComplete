namespace DevIO.BusinessOrDomain.Notifications
{
    public class Notificacao
    {
        public String? Mensagem { get; }

        public Notificacao(String mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
