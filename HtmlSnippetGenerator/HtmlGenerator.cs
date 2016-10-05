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

            String[] lines = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder builder = new StringBuilder();



            for (int i = 0; i < lines.Length; i++)
            {

                string[] items = lines[i].Split('|');

                builder.Append("<tr>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:100px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[0]);

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:302px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[1]);

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:100px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[2]);

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:75px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[3]);

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:85px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[4]);

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:85px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[5]);

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:60px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[6]);

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:75px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[7]);

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:95px;\">");

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                

                builder.Append(Environment.NewLine);
                builder.Append("</tr>");
                builder.Append(Environment.NewLine);

            }

            return builder.ToString();
        }
    }
}
