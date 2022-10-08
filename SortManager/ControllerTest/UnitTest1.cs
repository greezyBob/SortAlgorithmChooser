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
            var output = _controller.ArrayToString(input);
            var expectedOutput = "[ 5, 3, 4, 6 ]";
            Assert.That(output, Is.EqualTo(expectedOutput));
        }

        [TestCase("23", 23)]
        [TestCase("4", 4)]
        [TestCase("99", 99)]
        public void GivenValidString_ParseInput_ReturnsInt(string input, int expectedOutput)
        {
            var output = _controller.ParseInput(input);
            Assert.That(output, Is.EqualTo(expectedOutput));
        }

        [TestCase("2 3", 0)]
        [TestCase("4.3", 0)]
        [TestCase("agd", 0)]
        [TestCase(" ", 0)]
        public void GivenInvalidString_ParseInput_ReturnsZero(string input, int expectedOutput)
        {
            var output = _controller.ParseInput(input);
            Assert.That(output, Is.EqualTo(expectedOutput));
        }

        [TestCase(1, 1)]
        [TestCase(22, 22)]
        [TestCase(99, 99)]
        public void GivenLength_RandomArray_ReturnsArrayOfLength(int length, int expected)
        {
            var output = _controller.RandomArray(length).Length;
            Assert.That(output, Is.EqualTo(expected));
        }

    }
}