using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace CSharpTestLib
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CanCallFSharp()
        {
            Assert.AreEqual(46, MyMathModule.DoubleIt(23));
        }
    }
}
