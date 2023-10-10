using System;
using System.Text;

namespace CustMeth
{
    internal class String
    {
        public string name;

        public bool ContainMethod(char x)
        {
            for (int i = 0; i < name.Length; i++)
            {
            if (x == name[i])
                {
                    return true;
                }

            }
            return false;
        }
        public string ReplaceMethod(char oldChar , char newChar)
        {
            StringBuilder newString = new StringBuilder();
            for(int i=0; i < name.Length; i++) 
            { 

                if (oldChar == name[i])
                {
                    newString.Append(newChar);
                }
                else
                {
                    newString.Append(name[i]);
                }
            }
            return newString.ToString();
        }

        public string SubStringMethod(int start)
        {
            StringBuilder newString = new StringBuilder();
            
            for (int i = start; i < name.Length; i++)
            {
                newString.Append(name[i]);
            }
            return newString.ToString();
        }

        public string TrimMethod()
        {
            StringBuilder newString = new StringBuilder();
            int startIndex = 0;
            int endIndex=name.Length-1;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i]!=' ')
                {
                    startIndex = i;
                    break;
                }
            }
            for (int i = name.Length-1; i >= 0; i--)
            {
                if (name[i]!=' ')
                {
                    endIndex = i;
                    break;
                }
            }
            for (int i = startIndex; i <=endIndex; i++)
            {
                newString.Append(name[i]);
            }
            return newString.ToString();



        }



        }

}
