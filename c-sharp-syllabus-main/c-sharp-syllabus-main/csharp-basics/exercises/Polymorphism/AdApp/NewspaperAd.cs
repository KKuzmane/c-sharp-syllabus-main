namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            _rate = rate;
            _column = column;
        }

        private new int Cost()
        {
            var fee = base.Cost();
            return fee;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}