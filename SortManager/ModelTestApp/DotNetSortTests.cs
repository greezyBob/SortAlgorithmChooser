using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ModelTestApp
{
    public class DotNetSortTests
    {
        private DotNetSort _model;

        static object[] dotNetSortArray =
{
        new object[] { new int[] { 3423, 644, 43279, 454, 43827, 3129 }, new int[] { 454, 644, 3129, 3423, 43279, 43827 } },
        new object[] { new int[] { 10, 64, 43, 45, 0, 31 }, new int[] { 0, 10, 31, 43, 45, 64 } },
        new object[] { new int[] { -10, 604, -88, 4500, 111, 31000 }, new int[] { -88, -10, 111, 604, 4500, 31000 } },
        new object[] { new int[] { 126, 110, 118, 10 }, new int[] { 10, 110, 118, 126 } }
    };

        [OneTimeSetUp]
        public void SetUp()
        {
            _model = new DotNetSort();
        }

        [Test]
        public void GivenANullArray_Sort_ThrowsAnException()
        {
            int[] array = null;
            Assert.That(() => _model.Sort(array), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void GivenArray_Sort_ReturnsExpectedArrayLength()
        {
            int[] nums = { 3423, 644, 43279, 454, 43827, 3129 };
            Assert.That(_model.Sort(nums).Length, Is.EqualTo(6));
        }

        [TestCaseSource(nameof(dotNetSortArray))]

        public void GivenArray_Sort_ReturnsSortedArray(int[] nums, int[] expected)
        {
            Assert.That(_model.Sort(nums), Is.EqualTo(expected));
        }
    }
}
