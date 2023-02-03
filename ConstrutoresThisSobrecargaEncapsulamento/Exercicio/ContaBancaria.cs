namespace Exercicio
{
    class ContaBancaria
    {
        private string _nome;
        public int NumeroConta { get; set; }
        public double Saldo { get; private set; }
        public double DepositoInicial { get; set; }
        public double Deposito { get; set; }
        public double Saque { get; set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(string nome, int numeroConta, double saldo, double depositoInicial, double deposito, double saque)
        {
            _nome = nome;
            NumeroConta = numeroConta;
            Saldo = saldo;
            DepositoInicial = depositoInicial;
            Deposito = deposito;
            Saque = saque;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double calculoDeposito()
        {
            return DepositoInicial + Deposito;
        }

        public double calculoSaque()
        {
            return calculoDeposito() - Saque - 5;
        }

    }
}
