var tmp = new int[8] { 0, 1, 2, 2, 3, 0, 4, 2 };
//var tmp = new int[4] { 3,2,2,3};
//var tmp = new int[1] { 1};
//var tmp = new int[2] { 4,4};
var res = RemoveElement(tmp, 2);
 int RemoveElement(int[] nums, int val)
{
    int i = 0;
    int n = nums.Length;
    while (i < n)
    {
        if (nums[i] == val)
        {
            nums[i] = nums[n - 1];
            n--;
        }
        else
        {
            i++;
        }
    }
    return n;

    
 }
