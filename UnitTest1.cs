
namespace Calculator
{
    public class Tests
    {
        private readonly CalcularoService _calcularoService;
        public Tests() { 
        _calcularoService = new CalcularoService();
        }

        [Test]
        public void WhenCalculatorDividesReturnDivideResult()
        {
            int x =5; int y =2;
            DivideResult result = _calcularoService.Divide(x,y);
            Assert.NotNull(result);
            Assert.That(result.Quotient, Is.EqualTo(2));
            Assert.That(result.Reminder, Is.EqualTo(1));
        }
        [Test]
        public void WhenDivideIsZeroReutnExeption()
        {
            int x =5; int y =0;
            var result = Assert.Throws<ArgumentException>(()=>_calcularoService.Divide(x,y));

            Assert.That(result.ParamName, Is.EqualTo("DivideResult"));
        }
    }
   
}