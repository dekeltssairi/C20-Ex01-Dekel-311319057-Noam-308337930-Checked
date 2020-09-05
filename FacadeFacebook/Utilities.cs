using System;

namespace FacadeLayer
{
    public class Utilities
    {
        public class Constants
        {
            public const int MaxHoursToWaitForRecovery = 24;
            public const string PositiveMessage = "You may be infected please go check yourself";
            public const string NegaiveMessage = "You are ok! no confirmed location detected";
        }

        public static bool inputValidation(string i_UserInput, out int o_UserInputAsInt, int i_NumberOfDigitsToRecive, int i_MaxNumber, string i_Type)
        {
            bool isANumber = int.TryParse(i_UserInput, out o_UserInputAsInt);
            bool isInputValid = i_UserInput.Length == i_NumberOfDigitsToRecive && o_UserInputAsInt > 0;
            if (isANumber == true)
            {
                if (o_UserInputAsInt < 0 || o_UserInputAsInt > i_MaxNumber)
                {
                    throw new Exception(string.Format("Time is not vaild! {0} is not a {1}", o_UserInputAsInt, i_Type));
                }
            }

            return isInputValid && isANumber;
        }
    }
}
