namespace TestEDM.Shared.Exceptions
{
    public class SaldoCaixaException : Exception
    {
        public SaldoCaixaException()
        {
        }

        public SaldoCaixaException(string message)
            : base(message)
        {
        }

        public SaldoCaixaException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
