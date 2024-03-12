using CalculatorTestingWithNunit;
using Moq;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void AdditionNosTest()
        //{

        //    var systemUnderTest = new CalculatorTestingWithNunit.Maths();
        //    Assert.That(systemUnderTest.AddNos(10, 20),Is.EqualTo(40));


        //}


        


        [TestCase(1, 2)]
        [TestCase(10, 20)]
        [TestCase(13, 2)]
        public void AdditionNosTest(int fno, int sno)
        {

            var systemUnderTest = new CalculatorTestingWithNunit.Maths();
            var expected = fno + sno;

            Assert.That(systemUnderTest.AddNos(fno, sno), Is.EqualTo(expected));

        }

        //TDD--Test Driven Development

        //[TestCase(100,"Denied")]
        //[TestCase(150, "Denied")]
        //[TestCase(190, "Denied")]
        //public void TestForApprovingLoan(int creditScore,string expectedResult)
        //{
        //    string result = "Approved";




        //    Assert.That(result,Is.EqualTo(expectedResult));
        //}


        [TestCase(100, "Denied")]
        [TestCase(150, "Denied")]
        [TestCase(190, "Approved")]

        public void MockUnitTestForLoanDecision(int creditScore, string expectedResult)
        {

            Mock<ICreditDecision>?  mockMaths = new Mock<ICreditDecision>(MockBehavior.Strict);
            mockMaths.Setup(p => p.LoanDecision(creditScore)).Returns(expectedResult);

            Maths systemUnderTest = new Maths(mockMaths.Object);
            string result = systemUnderTest.LoanDecision(creditScore);

            Assert.That(result, Is.EqualTo(expectedResult));
        }





    }
}