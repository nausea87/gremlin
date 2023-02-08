using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Nausea.nUnitTests
{
    public class FindFileTests
    {

        private FindFile _findFile { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _findFile = new FindFile();
        }

        // TestCase == path to myfile.csv
        [TestCase("C:\\Users\\nAuseA\\Desktop\\gremlin\\Nausea\\myfile.csv")]
        public void FindFileIfExists_ExistTest(string path)
        {
            var act = _findFile.FindFileIfExists(path);
            Assert.AreEqual(true, act);
        }

        [TestCase("C:\\Users\\nAuseA\\Desktop\\gremlin\\Nausea\\myfile.csv")]
        public void FindFileIfExists_NotExistTest(string path)
        {
            var act = _findFile.FindFileIfExists(path);
            Assert.AreNotEqual(false, act);
        }
    }
}