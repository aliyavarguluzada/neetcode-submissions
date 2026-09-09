public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
     int zero_count = 0;
    int prod = 1;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            prod *= nums[i];
        }
        else
        {
            zero_count++;
        }
    }


    if (zero_count > 1)
    {
        return new int[nums.Length];
    }

    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        if (zero_count > 0)
        {
            if (nums[i] == 0)
            {
                res[i] = prod;
            }
            else
            {
                res[i] = 0;
            }
        }
        else
        {
            res[i] = prod / nums[i];
        }
    }

    return res;
    }
}
