using TestEDM.Shared.Enum;

namespace TestEDM.Domain.Interfaces
{
    public interface IAdicionarNotas
    {
        public void Adicionar(int quantidade, TipoNota tipo);
    }
}
