using SortManagerController;
using SortManagerView;

namespace ControllerTest
{
    public class Tests
    {
        private Controller _controller;

        [OneTimeSetUp]
        public void Setup()
        {
            _controller = new Controller();
            
        }

        [Test]
        public void GivenArray_ArrayToString_ReturnsCorrectFormat()
        {
            int[] input = new int[] { 5, 3, 4, 6 };
            var result = _controller.ArrayToString(input);
            var expectedOutput = "[ 5, 3, 4, 6 ]";
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}