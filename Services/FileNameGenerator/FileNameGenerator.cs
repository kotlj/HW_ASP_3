using System.Text;

namespace HW_ASP_3.Services.FileNameGenerator
{
    public class FileNameGenerator : IFileNameGenerator
    {
        public string Random(int length)
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            char symbol = ' ';
            for (int i = 0; i < length; i++)
            {
                int letterOrNumber = r.Next(0, 2);
                if (letterOrNumber == 0)
                {
                    symbol = Convert.ToChar(r.Next(97, 123));
                }
                else
                {
                    symbol = Convert.ToChar(r.Next(48, 58));
                }
                sb.Append(symbol);
            }
            return sb.ToString();
        }
    }
}
