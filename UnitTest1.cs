namespace Calculator
{
    public class Tests
    {
        private readonly CalcularoService _calcularoService;
        public Tests() { }

        [Test]
        public void WhenCalculatorDividesReturnDivideResult()
        {
            DivideResult result = _calcularoService.Divide();
            Assert.NotNull(result);
            Assert.That(result.Divide, Is.Not.Null);
            Assert.That(result.Reminder.Is.Not.Null);
        }   
    }
}