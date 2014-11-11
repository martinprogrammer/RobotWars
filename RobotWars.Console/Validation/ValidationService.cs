using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotWars.ConsoleApp.Data;

namespace RobotWars.ConsoleApp.Validation
{
    public static class ValidationService
    {

        public static bool IsStringArgumentNullOrEmpty(bool throwException, string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                if (!throwException)
                {
                    return true;
                }
                else if (str == null)
                {
                    throw new ArgumentNullException("The string is null or Empty");
                }
                else if (str.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("The string is null or Empty");
                }
            }

            return false;
        }
        
        
        public  static bool IsArenaDimensionValid(bool throwException, string input)
        {
            if (IsStringArgumentNullOrEmpty(false, input))
            {
                return false;
            }

            string[] newString = input.Split(' ');
            int id = 0;

            if (newString.GetUpperBound(0) == 1)
            {
                for (int i = 0; i < newString.GetUpperBound(0) + 1; i++)
                {
                    if (!int.TryParse(newString[i], out id))
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsInputValidLocation(string input)
        {
            if (IsStringArgumentNullOrEmpty(false, input))
            {
                return false;
            }
            
            string[] newString = input.Split(' ');
            int id = 0;

            if (newString.GetUpperBound(0) == 2)
            {
                for (int i = 0; i < newString.GetUpperBound(0) + 1; i++)
                {
                    if (i == 2)
                    {
                        if (!Enum.IsDefined(typeof(enumFacing), newString[i].ToUpper()))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (!int.TryParse(newString[i], out id))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsInputValidMoveInstruction(string input)
        {
            if (IsStringArgumentNullOrEmpty(false, input))
            {
                return false;
            }

            char[] newString = input.ToCharArray();

            for (int i = 0; i < newString.GetUpperBound(0) + 1; i++)
            {
                if (!Enum.IsDefined(typeof(enumMoves), (Convert.ToString(newString[i]).ToUpper())))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
