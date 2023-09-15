using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace HangmanGame.Classes
{
    public class CsvReader
    {
        public static string[] ReadWordsFromCsv(string filePath)
        {
            var words = new List<string>();
            using (var parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length >= 2)
                    {
                        string word = fields[0];
                        if (int.TryParse(fields[1], out int category))
                        {
                            // You can use the category here if needed
                            words.Add(word);
                        }
                    }
                }
            }
            return words.ToArray();
        }
    }
}