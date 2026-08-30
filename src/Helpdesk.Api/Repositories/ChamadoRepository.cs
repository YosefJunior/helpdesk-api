using Helpdesk.Api.Models;

namespace Helpdesk.Api.Repositories
{
    public class ChamadoRepository
    {
        private readonly List<Chamado> _chamados = new List<Chamado>();
        private int _proximoId = 1;
        public void Create(string nome, string email, Setor setor, string descricao, TipoChamado tipo, Urgencia urgencia)
        {
            var novoChamado = new Chamado(nome, email, setor, descricao, tipo, urgencia);
            _chamados.Add(novoChamado);
            novoChamado.DefinirId(_proximoId);
            _proximoId++;
            _chamados.Add(novoChamado);
        }
    }
}
