
namespace Calculator
{
    public class Tests
    {
        private readonly CalcularoService _calcularoService;
        public Tests() { }

        [Test]
        public void WhenCalculatorDividesReturnDivideResult()
        {
            int x =5; int y =2;
            DivideResult result = _calcularoService.Divide(x,y);
            Assert.NotNull(result);
            Assert.That(result.Divide, Is.EqualTo(2));
            Assert.That(result.Reminder, Is.EqualTo(5));
        }   
    }

    internal class DivideResult
    {
        public int Divide { get; set; }
        public int Reminder { get; set; }
    }

    internal class CalcularoService
    {
        internal DivideResult Divide(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}