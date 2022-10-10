namespace ModelTestApp;

public class TestCaseSourceClass
{
    public static IEnumerable<object[]> TestCaseArrays()
    {
        yield return new[] { new int[] { 3423, 644, 43279, 454, 43827, 3129 }, new int[] { 454, 644, 3129, 3423, 43279, 43827 } };
        yield return new[] { new int[] { 10, 64, 43, 45, 0, 31 }, new int[] { 0, 10, 31, 43, 45, 64 } };
        yield return new[] { new int[] { -10, 604, -88, 4500, 111, 31000 }, new int[] { -88, -10, 111, 604, 4500, 31000 } };
        yield return new[] { new int[] { 126, 110, 118, 10 }, new int[] { 10, 110, 118, 126 } };
    }
}