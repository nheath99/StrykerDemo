namespace StrykerDemo
{
    public static class ClassToBeTested
    {
        public static decimal CalculateValue(bool a, decimal b, decimal c)
        {
            decimal result;

            if (a)
            {
                result = b;
            }
            else
            {
                result = c;
            }

            return result;
        }
    }
}