using System.Collections.Generic;

class Solution
{
	public IList<int> FindDisappearedNumbers(int[] nums)
	{
		List<int> result = new List<int>();
		if (nums.Length == 0)
			return result;

		System.Array.Sort(nums);
		for (int i = 0; i < nums.Length; i++)
		{
			if ((i + 1) < nums.Length && nums[i] != nums[i + 1] && nums[i] + 1 != nums[i + 1])
			{
				for (int j = 1; j < nums[i + 1] - nums[i]; j++)
					result.Add(nums[i] + j);
			}
		}

		// 开头缺少的
		for (int j = 1; j < nums[0]; j++)
			result.Add(j);

		// 结尾缺少的
		for (int j = 1; j <= nums.Length - nums[nums.Length - 1]; j++)
			result.Add(nums[nums.Length - 1] + j);
		return result;
	}
}
