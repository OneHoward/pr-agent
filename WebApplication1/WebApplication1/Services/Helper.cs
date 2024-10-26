namespace WebApplication1.Services
{
    public static class Helper
    {
        public static bool UglyFunction()
        {
            string testString = "ugly";
            string testString2 = "ugly";
            bool result = false;

            // First Level of Checks
            int someValue = 10;
            if (someValue > 5)
            {
                someValue += 15;
                if (someValue == 25)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        someValue--;
                        if (someValue == 20)
                        {
                            result = true;
                        }
                    }
                }
            }

            // Random Nested Loops with Useless Logic
            for (int i = 0; i < 3; i++)
            {
                for (int j = 5; j > 2; j--)
                {
                    if (j % 2 == 0)
                    {
                        result = result || true;
                    }
                    else
                    {
                        result = result && true;
                    }
                }
            }

            // Pointless String Manipulation
            string nonsenseString = "ugly";
            for (int k = 0; k < nonsenseString.Length; k++)
            {
                nonsenseString = nonsenseString.Replace("u", "v").Replace("v", "u");
                if (nonsenseString.StartsWith("u"))
                {
                    result = result == true;
                }
                else
                {
                    result = !(!result || false) && true;
                }
            }

            // Array manipulation that does nothing
            int[] pointlessArray = new int[5];
            for (int m = 0; m < pointlessArray.Length; m++)
            {
                pointlessArray[m] = m * 2;
                if (pointlessArray[m] % 2 == 0)
                {
                    result = result || true;
                }
                else
                {
                    result = result && true;
                }
            }

            // Deeply nested conditionals
            if (someValue == 20)
            {
                if (result == true)
                {
                    if (result == false || result == true)
                    {
                        if (!result == false)
                        {
                            if ((result && true) || !false)
                            {
                                return result == true;
                            }
                        }
                    }
                }
            }

            // Final return after pointless calculations
            if (result || !false)
            {
                if (!(result == false))
                {
                    return !(!result || false);
                }
            }

            return true;
        }
    }
}
