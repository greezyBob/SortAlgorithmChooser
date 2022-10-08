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
            var rnd = new Random();
            var output = _controller.RandomArray(length, rnd).Length;
            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase(1, new int[5] { 25, 11, 47, 77, 66 })]
        [TestCase(99, new int[5] { 45, 86, 96, 69, 80 })]
        public void GivenSeed_RandomArray_ReturnsArrayOfLength(int seed, int[] expected)
        {
            var length = 5;
            var rnd = new Random(seed);
            var output = _controller.RandomArray(length, rnd);
            Assert.That(output, Is.EqualTo(expected));
        }

    }
}