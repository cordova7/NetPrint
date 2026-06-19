using System;
using System.Collections.Generic;
using System.IO;

namespace NetPrint
{
    /// <summary>
    /// Minimal KEY=VALUE loader for a dotenv-style file living next to NetPrint.exe.
    /// Lines starting with '#' (after optional whitespace) and blank lines are ignored.
    /// Surrounding single or double quotes are stripped from values.
    /// Missing file is not an error: returns an empty dictionary so the app falls
    /// back to its built-in defaults.
    /// </summary>
    public static class EnvLoader
    {
        public static Dictionary<string, string> Load(string fileName = ".env")
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            string path;
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                path = Path.Combine(baseDir, fileName);
            }
            catch
            {
                return result;
            }

            if (!File.Exists(path))
                return result;

            string[] lines;
            try
            {
                lines = File.ReadAllLines(path);
            }
            catch
            {
                // Unreadable .env (locked, no perms) should not crash the app.
                return result;
            }

            foreach (var raw in lines)
            {
                var line = raw.Trim();

                if (line.Length == 0)
                    continue;
                if (line[0] == '#')
                    continue;

                int eq = line.IndexOf('=');
                if (eq <= 0)
                    continue;

                var key = line.Substring(0, eq).Trim();
                var value = line.Substring(eq + 1).Trim();

                // Strip a single matched pair of surrounding quotes.
                if (value.Length >= 2)
                {
                    char first = value[0];
                    char last = value[value.Length - 1];
                    if ((first == '"' && last == '"') || (first == '\'' && last == '\''))
                        value = value.Substring(1, value.Length - 2);
                }

                result[key] = value;
            }

            return result;
        }
    }
}