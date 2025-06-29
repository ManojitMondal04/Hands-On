using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerCommTests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mockMailSender;
        private CustomerComm _customerComm;

        [OneTimeSetUp]
        public void Setup()
        {
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender
                .Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            _customerComm = new CustomerComm(_mockMailSender.Object);
        }

        [Test]
        public void SendMailToCustomer_ReturnsTrue()
        {
            bool result = _customerComm.SendMailToCustomer(); 
            NUnit.Framework.Assert.That(result);

        }
    }
}
