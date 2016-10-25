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
                if ((i % 8) == 0)
                {


                    builder.Append("<tr>");
                    builder.Append(Environment.NewLine);
                    builder.Append("<td style=\"width:250px;\">");

                    builder.Append(Environment.NewLine);

                    builder.Append("Audible MSP Transition (Audio Production)");

                    builder.Append(Environment.NewLine);

                    builder.Append("</td>");
                    builder.Append(Environment.NewLine);
                    builder.Append("<td style=\"width:118px;\">");

                    builder.Append(Environment.NewLine);

                    builder.Append("</td>");
                    builder.Append(Environment.NewLine);
                    builder.Append("<td style=\"width:135px;\">");

                    builder.Append(Environment.NewLine);

                    builder.Append("</td>");
                    builder.Append(Environment.NewLine);
                    builder.Append("<td style=\"width:120px;\">");

                    builder.Append(Environment.NewLine);

                    builder.Append("</td>");
                    builder.Append(Environment.NewLine);
                    builder.Append("</tr>");
                    builder.Append(Environment.NewLine);

                }

                builder.Append("<tr>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:250px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[1]);
                builder.Append("&nbsp;");
                builder.Append(items[0]);
                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:118px;\">");

                builder.Append(Environment.NewLine);

                builder.Append(items[6]);
                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:135px;\">");

                builder.Append(Environment.NewLine);

                builder.Append("USD");
                builder.Append("&nbsp;");
                builder.Append(items[8]);

                builder.Append(Environment.NewLine);

                builder.Append("</td>");
                builder.Append(Environment.NewLine);
                builder.Append("<td style=\"width:120px;\">");

                builder.Append(Environment.NewLine);

                builder.Append("USD");
                builder.Append("&nbsp;");
                builder.Append(items[9]);

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
