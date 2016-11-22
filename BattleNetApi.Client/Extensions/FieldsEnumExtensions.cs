using System;
using System.Collections.Generic;
using System.Linq;
using BattleNetApi.Client.Constants;

namespace BattleNetApi.Client.Extensions
{
    public static class FieldsEnumExtensions
    {
        public static IEnumerable<string> GetFieldsAsStrings(this CharacterFields fields)
        {
            return GetFieldsAsStrings<CharacterFields>((int)fields);
        }

        public static IEnumerable<string> GetFieldsAsStrings(this GuildFields fields)
        {
            return GetFieldsAsStrings<GuildFields>((int)fields);
        }

        private static IEnumerable<string> GetFieldsAsStrings<T>(int enumValue) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("T must be an enumareted type.");

            var options = new List<string>();

            var names = Enum.GetNames(typeof(T));
            var values = Enum.GetValues(typeof(T));

            if (names.Length != values.Length)
                throw new Exception("Enum length mismatch.");

            foreach (var name in names)
            {
                if (name == "None")
                    continue;

                T nameValue;
                if (Enum.TryParse(name, true, out nameValue))
                {
                    var intNameValue = (int)(object)nameValue;
                    if ((enumValue & intNameValue) == intNameValue)
                    {
                        options.Add(string.Concat(name.Substring(0, 1).ToLowerInvariant(), name.Substring(1)));
                    }
                }
            }

            return options;
        }
    }
}
