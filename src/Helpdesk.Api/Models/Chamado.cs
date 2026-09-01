namespace Helpdesk.Api.Models
{
    public class Chamado
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Setor Setor { get; private set; }
        public string Descricao { get; private set; }
        public TipoChamado Tipo { get; private set; }
        public Urgencia Urgencia { get; private set; }
        public StatusChamado Status { get; private set; }
        public DateTime DataAbertura { get; set; }

        public Chamado(string nome, string email, Setor setor, string descricao, TipoChamado tipo, Urgencia urgencia)
        {
            Nome = nome;
            Email = email;
            Setor = setor;
            Descricao = descricao;
            Tipo = tipo;
            Urgencia = urgencia;
            Status = StatusChamado.NaoAtribuido;
            DataAbertura = DateTime.Now;
        }

        public void DefinirId(int id)
        {
            Id = id;
        }

        public void AlterarStatus(StatusChamado novoStatus)
        {
            Status = novoStatus;
        }

        public void AtualizarDados(string descricao, Setor setor, TipoChamado tipo)
        {
            Descricao = descricao;
            Setor = setor;
            Tipo = tipo;
        }

        public void AlterarUrgencia(Urgencia novaUrgencia)
        {
            Urgencia = novaUrgencia;
        }
    }
}
