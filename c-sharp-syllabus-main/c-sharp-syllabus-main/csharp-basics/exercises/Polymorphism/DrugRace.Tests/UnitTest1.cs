using NUnit.Framework;

namespace DragRace.Tests
{
    public class DragRaceTests
    {
        private IDragRace _audi;
        private IDragRace _bmw;
        private IDragRace _ferrari;
        private IDragRace _lexus;
        private IDragRace _tesla;
        private IDragRace _volksWagen;
        private IBoostable _lexusBoosts;
        private IBoostable _volkswagenBoosts;

        [SetUp]
        public void Setup()
        {
            _audi = new Audi();
            _bmw = new Bmw();
            _ferrari = new Ferrari();
            _lexus = new Lexus();
            _tesla = new Tesla();
            _volksWagen = new VolksWagen();
            _lexusBoosts = new Lexus();
            _volkswagenBoosts = new VolksWagen();
        }

        [Test]
        public void SpeedUp_TheirSpeedUpValues()
        {
            Assert.AreEqual(10, _audi.SpeedUp());
            Assert.AreEqual(10, _bmw.SpeedUp());
            Assert.AreEqual(25, _ferrari.SpeedUp());
            Assert.AreEqual(10, _lexus.SpeedUp());
            Assert.AreEqual(15, _tesla.SpeedUp());
            Assert.AreEqual(13, _volksWagen.SpeedUp());
        }

        [Test]
        public void SlowDown_TheirSpeedUpValues()
        {
            Assert.AreEqual(-10, _audi.SlowDown());
            Assert.AreEqual(-10, _bmw.SlowDown());
            Assert.AreEqual(-25, _ferrari.SlowDown());
            Assert.AreEqual(-10, _lexus.SlowDown());
            Assert.AreEqual(-15, _tesla.SlowDown());
            Assert.AreEqual(-13, _volksWagen.SlowDown());
        }

        [Test]
        public void ShowCurrentSpeed_ReturnStringCurrentSpeed()
        {
            Assert.AreEqual("0", _audi.ShowCurrentSpeed());
            Assert.AreEqual("0", _bmw.ShowCurrentSpeed());
            Assert.AreEqual("0", _ferrari.ShowCurrentSpeed());
            Assert.AreEqual("0", _lexus.ShowCurrentSpeed());
            Assert.AreEqual("0", _tesla.ShowCurrentSpeed());
            Assert.AreEqual("0", _volksWagen.ShowCurrentSpeed());
        }

        [Test]
        public void StartEngine_ReturnCarSound()
        {
            Assert.AreEqual("Rrrrrrr.....", _audi.StartEngine());
            Assert.AreEqual("Rrrrrrr.....", _bmw.StartEngine());
            Assert.AreEqual("ZummZum.Zummmmm", _ferrari.StartEngine());
            Assert.AreEqual("Rrrrrrr.....", _lexus.StartEngine());
            Assert.AreEqual("-- silence ---", _tesla.StartEngine());
            Assert.AreEqual("EnnEnnEnnnnn....", _volksWagen.StartEngine());
        }

        [Test]
        public void UseNitrousOxideEngine_BoostCarByInputValues()
        {
            Assert.AreEqual(30, _lexusBoosts.UseNitrousOxideEngine());
            Assert.AreEqual(20, _volkswagenBoosts.UseNitrousOxideEngine());
        }
    }
}