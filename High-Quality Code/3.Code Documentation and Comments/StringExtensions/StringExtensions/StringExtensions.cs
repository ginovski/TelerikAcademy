//-----------------------------------------------------------------------

// <summary>

// String extensions class library by Telerik

// </summary>

//-----------------------------------------------------------------------
namespace Telerik.ILS.Common 
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    
    /// <summary>
    /// Class for String extension methods
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Hashes string with the MD5 Algorithm
        /// </summary>
        /// <param name="input">String to be hashed</param>
        /// <returns>Hashed string with MD5</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Converts string value to Boolean representation
        /// </summary>
        /// <param name="input">String to be converted</param>
        /// <returns>Boolean representation of the string</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };

            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts string to short
        /// </summary>
        /// <param name="input">String to be converted</param>
        /// <returns>Converted string to short or short default value if string cannot be converted</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);

            return shortValue;
        }

        /// <summary>
        /// Converts string to 32 bit integer representation
        /// </summary>
        /// <param name="input">String to be converted</param>
        /// <returns>Converted string to 32 bit integer or 32 bit integer default value if string cannot be converted</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);

            return integerValue;
        }

        /// <summary>
        /// Converts string to 64 bit integer representation
        /// </summary>
        /// <param name="input">String to be converted</param>
        /// <returns>64 bit integer representation or 64 bit integer default value if string cannot be converted</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);

            return longValue;
        }

        /// <summary>
        /// Converts string to DateTime
        /// </summary>
        /// <param name="input">String to be converted</param>
        /// <returns>Converts the specified string to a DateTime or DateTime default value if string cannot be converted</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);

            return dateTimeValue;
        }

        /// <summary>
        /// Makes first letter of a string capital
        /// </summary>
        /// <param name="input">String to be capitalized</param>
        /// <returns>String with first letter capitalized</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Returns string between two substrings
        /// </summary>
        /// <param name="input">Full string</param>
        /// <param name="startString">Start substring</param>
        /// <param name="endString">End substring</param>
        /// <param name="startFrom">Starting index. Default value is 0</param>
        /// <returns>String between the two substrings</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts string cyrillic letters to their latin representation
        /// </summary>
        /// <param name="input">String to be converted</param>
        /// <returns>String with cyrillic letters converted to latin representation</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts string latin letters to their cyrillic representation
        /// </summary>
        /// <param name="input">String to be converted</param>
        /// <returns>String with latin letters converted to cyrillic representation</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts invalid username to valid with only latin letters, numbers, dots and underscores
        /// </summary>
        /// <param name="input">Invalid username</param>
        /// <returns>Valid username with only allowed characters</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts invalid file name to valid with only latin letters, numbers, underscores, dots and dashes
        /// </summary>
        /// <param name="input">Invalid filename</param>
        /// <returns>Valid filename with the allowed characters</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Retrieves substring with the first number of characters
        /// </summary>
        /// <param name="input">String value</param>
        /// <param name="charsCount">Number of the first characters to be selected</param>
        /// <returns>Substring with the first number of characters</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Extracts the extension from a file name
        /// </summary>
        /// <param name="fileName">Name of a file</param>
        /// <returns>Extracted file extension from the file name</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Converts file extension to content type
        /// </summary>
        /// <param name="fileExtension">File extension</param>
        /// <returns>Content type represented from the file extension</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts string input to a byte array
        /// </summary>
        /// <param name="input">String to be converted</param>
        /// <returns>Byte array representing the string</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
