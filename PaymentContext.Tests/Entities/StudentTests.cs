using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student {
                FirstName = "Daniel", 
                LastName="Vega", 
                Document="02039746030",
                Email="danielvieiravega@gmail.com"};

                

        }
    }
}
