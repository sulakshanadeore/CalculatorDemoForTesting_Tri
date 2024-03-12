using CalculatorTestingWithNunit;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class CreditDemo
    {

        //[Setup]
        //public CreditDemo()
        //{
            
        //}
        Mock<ICreditDecision>? mockMaths;

        [TestCase(150, "Denied")]
        [TestCase(190, "Approved")]
        public void LoanCreditDecisionForBank(int creditScore, string expectedResult)
        { 
        mockMaths=new Mock<ICreditDecision>(MockBehavior.Strict);
            mockMaths.Setup(p=>p.LoanDecision(creditScore)).Returns(expectedResult);
            Maths systemUnderTest = new Maths(mockMaths.Object);
            var result=systemUnderTest.LoanDecision(creditScore);
            Assert.That(result,Is.EqualTo(expectedResult));    
        
        }
    }
}
