using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("Daniel","Vega", "02039746030","danielvieiravega@gmail.com" );               
            student.AddSubscription(subscription);

            Assert.AreEqual(student.Subscriptions.Count, 1);
        }
    }
}
