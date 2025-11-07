using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
namespace CaesarCipher
{
    public class FileData
    {
        public string Text { get; set; }
        public string Alphabet { get; set; }
        public string Key { get; set; }
        public bool IsValid { get; set; }
    }
    public static class FileManager
    {
        public static void SaveFile(string path, string text, string alphabet, string key)
        {
            if (Path.GetExtension(path).ToLower() == ".html")
            {
                string html = $@"
<html>
<head><meta charset='UTF-8'><title>Результат шифрования</title></head>
<body>
<h2>Результат шифрования</h2>
<p><b>ALPHABET:</b> {alphabet}</p>
<p><b>KEY:</b> {key}</p>
<pre>{text}</pre>
</body>
</html>";
                File.WriteAllText(path, html, Encoding.UTF8);
            }
            else
            {
                string content = $"KEY={key}\nALPHABET={alphabet}\nTEXT={text}";
                File.WriteAllText(path, content, Encoding.UTF8);
            }
        }
        public static FileData LoadFile(string path)
        {
            FileData data = new FileData();
            string ext = Path.GetExtension(path).ToLower();
            string text = null, alphabet = null, key = null;
            if (ext == ".html")
            {
                string html = File.ReadAllText(path, Encoding.UTF8);
                alphabet = Regex.Match(html, @"ALPHABET:\s*</b>\s*(.*?)</p>", RegexOptions.Singleline).Groups[1].Value;
                key = Regex.Match(html, @"KEY:\s*</b>\s*(.*?)</p>", RegexOptions.Singleline).Groups[1].Value;
                var t = Regex.Match(html, @"<pre>(.*?)</pre>", RegexOptions.Singleline);
                if (t.Success)
                    text = WebUtility.HtmlDecode(t.Groups[1].Value);
            }
            else
            {
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
                foreach (string line in lines)
                {
                    if (line.StartsWith("KEY=")) key = line.Substring(4).Trim();
                    if (line.StartsWith("ALPHABET=")) alphabet = line.Substring(9).Trim();
                    if (line.StartsWith("TEXT=")) text = line.Substring(5);
                }
            }
            data.Key = key;
            data.Alphabet = alphabet;
            data.Text = text;
            data.IsValid = InputValidator.ValidateFile(key, alphabet, text);
            return data;
        }
    }
}
