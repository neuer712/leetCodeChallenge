namespace leetCodeChallenge.problems
{
    public class _201_BitwiseANDofNumbersRange
    {
        public int RangeBitwiseAnd(int left, int right)
        {
            var leftL = left;
            var rightL = right;
            byte[] leftArr = new byte[32];
            byte[] rightArr = new byte[32];
            int i = 0;
            while (leftL != 0)
            {
                leftArr[i] = (byte)(leftL % 2);
                rightArr[i] = (byte)(rightL % 2);
                leftL = leftL >> 1;
                rightL = rightL >> 1;
                i++;
            }

            i--;
            var tail = i;

            if (rightL == 0)
            {
                bool flag = false;
                while (i >= 0)
                {
                    if (!flag)
                    {
                        byte temp = (byte)(rightArr[i] * leftArr[i]);
                        if (temp == 0 && rightArr[i] != 0) flag = true;
                        rightArr[i] = temp;
                    }
                    else
                    {
                        rightArr[i] = 0;
                    }

                    i--;
                }

                i++;
                var result = 0;
                var floor = 1;
                for (; i <= tail; i++)
                {
                    result += floor * (int)(rightArr[i]);
                    floor *= 2;
                }

                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
