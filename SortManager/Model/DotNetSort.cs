namespace Model;

public class DotNetSort : ISortable
{
    public int[] Sort(int[] nums)
    {
        Array.Sort(nums);
        return nums;
    }
}