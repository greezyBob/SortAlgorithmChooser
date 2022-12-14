using Model;

namespace ModelTestApp;

public class DotNetSortTests
{
    private DotNetSort _model;

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

    [TestCaseSource(typeof(TestCaseSourceClass), nameof(TestCaseSourceClass.TestCaseArrays))]
    public void GivenArray_Sort_ReturnsSortedArray(int[] nums, int[] expected)
    {
        Assert.That(_model.Sort(nums), Is.EqualTo(expected));
    }
}