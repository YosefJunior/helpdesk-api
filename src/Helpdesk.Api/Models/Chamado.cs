namespace Helpdesk.Api.Models
{
    public class Chamado
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Setor Setor { get; set; }
        public string Descricao { get; set; }
        public TipoChamado Tipo { get; set; }
        public Urgencia Urgencia { get; set; }
        public StatusChamado Status { get; set; }
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
    }
}
