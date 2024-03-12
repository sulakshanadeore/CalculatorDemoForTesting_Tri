using CalculatorTestingWithNunit;
using Moq;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        Mock<ICreditDecision>? mockMaths;

        [TestCase(150, "Denied")]
        [TestCase(190, "Approved")]
        public void LoanCreditDecisionForBank(int creditScore, string expectedResult)
        {
            mockMaths = new Mock<ICreditDecision>(MockBehavior.Strict);
            mockMaths.Setup(p => p.LoanDecision(creditScore)).Returns(expectedResult);
            Maths systemUnderTest = new Maths(mockMaths.Object);
            string result = systemUnderTest.LoanDecision(creditScore);
         Assert.That(result,Is.EqualTo(expectedResult));

        }
    }
}