using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordsTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void numberEmptyReturnsException()
        {
            int? number = 2;
            if (number == null)
            {
                Assert.Fail();
            }
        }

        [Test]
        public string int0returnStringZero()
        {
            int number = 0;
            if (number == 0)
            {
                return "Zero";
            }
            return ""; 
        }
    }
}
