using Helpdesk.Api.Models;

namespace Helpdesk.Api.Repositories
{
    public class ChamadoRepository
    {
        private readonly List<Chamado> _chamados = new List<Chamado>();
        private int _proximoId = 1;
        public void Create(string nome, string email, Setor setor,
            string descricao, TipoChamado tipo, Urgencia urgencia)

        {
            var novoChamado = new Chamado(nome, email, setor, descricao, tipo, urgencia);
            novoChamado.DefinirId(_proximoId);
            _proximoId++;
            _chamados.Add(novoChamado);
        }

        public List<Chamado> GetAll()
        {
            return _chamados;
        }

        public Chamado GetById(int id)
        {
            return _chamados.FirstOrDefault(c => c.Id == id);
        }

        public bool AlterarStatus(int id, StatusChamado novoStatus)
        {
            var chamado = GetById(id);
            if (chamado == null)
            {
                return false;
            }
            chamado.AlterarStatus(novoStatus);
            return true;
        }
    }
}
