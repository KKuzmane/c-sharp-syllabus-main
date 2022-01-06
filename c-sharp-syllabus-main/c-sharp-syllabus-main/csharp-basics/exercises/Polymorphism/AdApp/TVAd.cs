namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private int _costPerSecond;
        private bool _peakTime;

        public TVAd(int fee, int seconds, int costPerSecond, bool peakTime) : base(fee)
        {
            _seconds = seconds;
            _costPerSecond = costPerSecond;
            _peakTime = peakTime;
        }
        
        public override int Cost() 
        {
            if (_peakTime == true)
            {
                return _seconds * _costPerSecond * 2 + _fee;
            }
            else
            {
                return _seconds * _costPerSecond + _fee;
            }
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}