namespace Account
{
    public class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double money)
        {
            _money = money;
            _name = name;
        }

        public double Withdrawal(double money)
        {
            _money -= money;

            return _money;
        }

        public double Deposit(double money)
        {
            _money += money;

            return _money;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}