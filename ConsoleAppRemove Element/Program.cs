//var tmp = new int[8] { 0, 1, 2, 2, 3, 0, 4, 2 };
//var tmp = new int[4] { 3,2,2,3};
//var tmp = new int[1] { 1};
var tmp = new int[2] { 4,1};
var res = RemoveElement(tmp, 4);
 int RemoveElement(int[] nums, int val)
{
    int counter = 0;
    int valCounter = 0;
    for(int i=0;i<nums.Length;i++)
    {
        if (nums[i]==val)
        {
            counter = i;
            valCounter++;
            while ( counter+1 <nums.Length && counter < nums.Length)
            {
                if (nums[counter + 1] != val)
                {
                    nums[i] = nums[counter+1];
                    i++;
                    counter++;

                }
                else if (counter + 1 !=nums.Length && nums[counter + 1] == val)
                {
                    counter++;
                    valCounter++;
                }
            }
              
            }
    
        }
    
    return nums.Length - valCounter;
 }
