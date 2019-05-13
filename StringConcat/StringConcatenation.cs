using System;

namespace StringConcat
{
    public class StringConcatenation
    {
        public string addStrings(string lh, string rh)
        {
            if(lh.Equals(" "))
            {
                return lh + " " + rh.Trim();           
            } else if (rh.Equals(" "))
            {
                return lh.Trim() + " " + rh;
            }

            return lh.Trim() + " " + rh.Trim();
        }
    }
}