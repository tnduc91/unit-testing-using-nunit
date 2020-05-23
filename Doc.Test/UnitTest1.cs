using NUnit.Framework;
using System.IO;
namespace Doc.Test
{
    [TestFixture]
    public class Tests
    {
        FileStream _f1;
        FileStream _f2;
        string root;
        [SetUp]
        public void Setup()
        {
            root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.ToString();
            _f1 = File.OpenRead(root+"/SampleData/file1.txt");
            _f2 = File.OpenRead(root+"/SampleData/file2.txt");
        }

        [Test]
        public void Test1()
        {
            FileAssert.AreEqual(_f1, _f2);
        }
    }
}