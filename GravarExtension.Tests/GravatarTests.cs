using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravarExtension.Tests
{
    [TestClass]
    public class GravatarTests
    {
        [TestCategory("Gravatar")]
        [TestMethod("Should generate Gravar URL from email")]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow(" ", true)]
        [DataRow("and", true)]
        [DataRow("andre@a", true)]
        [DataRow("andre@balta.io", true)]
        public void ShouldGenerateFromEmail(string email, bool isValid)
        {
            Assert.AreNotEqual(string.IsNullOrEmpty(email.ToGravatar()), isValid);
        }
    }
}
