namespace CalculatorTestingWithNunit
{
  public  interface ICreditDecision
    {
        string LoanDecision(int creditScore);
    }




        public class Maths:ICreditDecision
        {

        ICreditDecision obj;
        public Maths(ICreditDecision creditDecision)
        {
            obj = creditDecision;    
        }
        public int AddNos(int n1, int n2)
            {
                return n1 + n2;
            }

        public Maths()
        {
                
        }

        public string LoanDecision(int creditScore)
        {
            string result;
            if ((creditScore >= 100) && (creditScore <= 180))
            {
                result = "Denied";
            }
            else
            {
                result = "Approved";
            }
            return result;  
        }

        }

    
}
