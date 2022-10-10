using Microsoft.VisualStudio.TestPlatform.TestHost;
using Model;
using System.Security.Cryptography.X509Certificates;

namespace ModelTestApp;

public class MergeSortTests
{
    private MergeSortModel _model;

    [OneTimeSetUp]
    public void SetUp()
    {
        _model = new MergeSortModel();
    }

    [Test]
    public void GivenANullArray_Sort_ThrowsAnException()
    {
        int[] array = null;
        Assert.That(() => _model.Sort(array), Throws.TypeOf<NullReferenceException>());
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

    [Test]
    public void GivenTwoArrays_Merge_ReturnsCorrectLength()
    {
        int[] left = { 1, 2 };
        int[] right = { 3, 4 };

        var length = _model.Merge(left, right).Length;
        int expectedLength = 4;

        Assert.That(length, Is.EqualTo(expectedLength));
    }

    [Test]
    public void Given2ArraysOfLength2_Merge_ReturnsExpectedArray()
    {
        int[] left = { 10, 3 };
        int[] right = { 8, 20 };
        
        var result =_model.Merge(left, right);
        int[] expectedresult = { 8, 10, 3, 20 };
        
        Assert.That(result, Is.EqualTo(expectedresult));
    }

    [Test]
    public void Given2ArraysOfLength2And1_Merge_ReturnsExpectedArray()
    {
        int[] left = { 16, 4 };
        int[] right = { 9 };
        
        var result =_model.Merge(left, right);
        int[] expectedresult = { 9, 16, 4 };
        
        Assert.That(result, Is.EqualTo(expectedresult));
    }

    [Test]
    public void Given2ArraysOfLength1And2_Merge_ReturnsExpectedArray()
    {
        int[] left = { 25 };
        int[] right = { 15, 3 };
        
        var result = _model.Merge(left, right);
        int[] expectedresult = { 15, 3, 25 };
        
        Assert.That(result, Is.EqualTo(expectedresult));
    }

    [Test]
    public void Given2ArraysOfLength1_Merge_ReturnsExpectedArray()
    {
        int[] left = { 30 };
        int[] right = { 60 };
        
        var result = _model.Merge(left, right);
        int[] expectedresult = { 30, 60 };
        
        Assert.That(result, Is.EqualTo(expectedresult));
    }

    [Test]
    public void Given2ArraysOfLength0And1_Merge_ReturnsTheSecondArray()
    {
        int[] left = { };
        int[] right = { 60 };
        
        var result = _model.Merge(left, right);
        int[] expectedresult = { 60 };
        
        Assert.That(result, Is.EqualTo(expectedresult));
    }
}