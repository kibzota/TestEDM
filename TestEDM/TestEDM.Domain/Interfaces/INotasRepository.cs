using TestEDM.Domain.Entities;

namespace TestEDM.Domain.Interfaces
{
    public interface INotasRepository
    {
        public Notas? NotasDisponiveis();
        public void SalvarNotas(Notas notas);

    }
}
