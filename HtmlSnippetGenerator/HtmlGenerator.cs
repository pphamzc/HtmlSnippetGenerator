using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlSnippetGenerator
{
    public class HtmlGenerator
    {

        public HtmlGenerator()
        {
           
        }

        public string Generate(string input)
        {

            String[] lines = input.Split(new string[] {Environment.NewLine},StringSplitOptions.RemoveEmptyEntries);

            StringBuilder builder = new StringBuilder();
            int line1 = 0;
            int line2 = 1;
            int line3 = 2;

            for(int i = 0;i < lines.Length;i++)
            {
                if(i == line1)
                {
                    builder.Append("<tr>");
                    builder.Append(Environment.NewLine);
                    builder.Append("<td style=\"width:250px;\">");

                    builder.Append(Environment.NewLine);

                    builder.Append(lines[i]);

                    builder.Append(Environment.NewLine);

                    continue;
                }

                if(i == line2)
                {
                    builder.Append(lines[i]);

                    builder.Append(Environment.NewLine);

                    builder.Append("</td>");

                    builder.Append(Environment.NewLine);

                    continue;
                }

                if(i == line3)
                {

                    string[] prices = lines[i].Split(' ');

                    builder.Append("<td style=\"width:118px;\">");
                    builder.Append(Environment.NewLine);
                    builder.Append(prices[0]);
                   builder.Append(Environment.NewLine);
                    builder.Append("</td>");

                    builder.Append(Environment.NewLine);

                    builder.Append("<td style=\"width:135px;\">");
                    builder.Append(Environment.NewLine);
                    builder.Append(prices[1]);
                    builder.Append(' ');
                    builder.Append(prices[2]);
                    builder.Append(Environment.NewLine);
                    builder.Append("</td>");

                    builder.Append(Environment.NewLine);

                    builder.Append("<td style=\"width:120px;\">");
                    builder.Append(Environment.NewLine);
                    builder.Append(prices[3]);
                    builder.Append(' ');
                    builder.Append(prices[4]);
                    builder.Append(Environment.NewLine);
                    builder.Append("</td>");

                    builder.Append(Environment.NewLine);
                    builder.Append("</tr>");
                    builder.Append(Environment.NewLine);
                }

                line1 += 3;
                line2 += 3;
                line3 += 3;
            }

            return builder.ToString();
        }
    }
}
