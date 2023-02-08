using System.IO;
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

        [Test]
        public void FindFileIfExists_ExistTest()
        {    
            string path = FindFile.GetFilePath();
            var act = _findFile.FindFileIfExists(path);
            Assert.AreEqual(true, act);
        }

        [Test]
        public void FindFileIfExists_NotExistTest()
        {
            string path = FindFile.GetFilePath();
            var act = _findFile.FindFileIfExists(path);
            Assert.AreNotEqual(false, act);
        }
    }
}