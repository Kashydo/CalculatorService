
namespace Calculator
{
    public class Tests
    {
        private CalcularoService _calcularoService;
        [SetUp]
        public void Setup()
        {
            _calcularoService = new CalcularoService();
            //Create services mocks
        }

        [Test]
        public void WhenCalculatorDividesReturnDivideResult()
        {
            int x = 5; int y = 2;
            DivideResult result = _calcularoService.Divide(x, y);
            Assert.NotNull(result);
            Assert.That(result.Quotient, Is.EqualTo(2));
            Assert.That(result.Reminder, Is.EqualTo(1));
        }
        [Test]
        public void WhenDivideIsZeroReutnExeption()
        {
            int x = 5; int y = 0;
            var result = Assert.Throws<ArgumentException>(() => _calcularoService.Divide(x, y));
            Assert.That(result.Message, Is.EqualTo("Can't divide by 0"));
        }

        [Test]
        public void WhenDiviserisNegativeReturnNegativeQuation()
        {
            int x = 5; int y = -2;
            DivideResult result = _calcularoService.Divide(x, y);
            Assert.That(result.Quotient, Is.EqualTo(-2));
            Assert.That(result.Reminder, Is.EqualTo(1));
        }
    }
}