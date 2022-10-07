using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ModelTestApp
{
    public class BubbleSortTests
    {
        private BubbleSortModel _model;

        [OneTimeSetUp]
        public void SetUp()
        {
            _model = new BubbleSortModel();
        }

        [Test]
        public void GivenANullArray_Sort_ThrowsAnException()
        {
            int[] array = null;
            Assert.That(() => _model.Sort(array), Throws.TypeOf<ArgumentNullException>());
        }

        [TestCaseSource(typeof(IntegerArrayTestSource))]
        public void GivenArray_Sort_ReturnsExpectedArrayLength(int[] nums)
        {

            Assert.That(_model.Sort(nums).Length, Is.EqualTo(8));
        }

        [Test]
        public void GivenArray_Sort_ReturnsSortedArray()
        {
            int[] nums = { 12, 20, 80, 100, 55, 1, 0, 45 };
            int[] expected = { 0, 1, 12, 20, 45, 55, 80, 100 };

            Assert.That(_model.Sort(nums), Is.EqualTo(expected));
        }


    }
}
