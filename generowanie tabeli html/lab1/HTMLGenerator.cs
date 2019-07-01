using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class HTMLGenerator
    {
        public List<string> head  {  set; private get; }
        public List<string> row  {  set; private get; }
        public List<string> foot  {  set; private get; }
        List<string> table;

        public HTMLGenerator(List<string> head, List<string> row, List<string> foot)
        {
            this.head = head;
            this.row = row;
            this.foot = foot;
            table = new List<string>();
        }

        public HTMLGenerator()
        {
            this.head = new List<string>();
            this.row = new List<string>();
            this.foot = new List<string>();
            table = new List<string>();
        }

        /*public void AddHead(List<string> head)
        { this.head = head; }

        public void AddRow(List<string> row)
        { this.row = row; }

        public void AddFoot(List<string> foot)
        { this.foot = foot; }*/

        public void GenerateTable()
        {
            AddHeader();
            table.Add("<table>");

            if (head != null && head.Count() != 0)
            {
                GenerateHead();
            }
            if (row != null && row.Count() != 0)
            {
                GenerateRow();
            }
            if (foot != null && foot.Count() != 0)
            {
                GenerateFoot();
            }

            table.Add("</table>");
            table.Add("</body>");
            table.Add("</html>");

            ShowTable();
            //ToFile();
        }

        private void AddHeader()
        {
            table.Add("<html>");
            table.Add("<head>");
            table.Add("<style>");
            table.Add("thead { color: green; }");
            table.Add("tfoot { color: red; }");

            table.Add("table, td, th{");
            table.Add("border: 1px solid black;");
            table.Add("}");
            table.Add("</style >");

            table.Add("</head>");
            table.Add("<body>");
        }

        private void GenerateRow()
        {
            table.Add("<tbody>");    

            int counter = 0;
            for (int i = 0; i < (row.Count()/head.Count()); i++)
            {
                table.Add("     <tr>");
                for (int j = 0; j < head.Count(); j++)
                {
                    table.Add("       " + "<td>" + row[counter] + "</td>");
                    counter++;
                }
                table.Add("     </tr>");
            }
            table.Add("</tbody>");
        }

        private void GenerateHead()
        {
            table.Add("<thead>");

            table.Add("     <tr>");

            for (int i = 0; i < head.Count(); i++)
            { table.Add("       " + "<th>" + head[i] + "</th>"); }

            table.Add("     </tr>");

            table.Add("</thead>");
        }

        private void GenerateFoot()
        {
            table.Add("<tfoot>");

            table.Add("     <tr>");

            for (int i = 0; i < foot.Count(); i++)
            { table.Add("       " + "<td>" + foot[i] + "</td>"); }

            table.Add("     </tr>");

            table.Add("</tfoot>");
        }

        private void ShowTable()
        {
            for (int i = 0; i < table.Count(); i++)
            {
                Console.WriteLine(table[i]);
            }
            Console.ReadKey();
        }

        public void ToFile()
        {
            // System.IO.File.WriteAllLines(Environment.SpecialFolder.Desktop.ToString()+@"\index.html", table);
          System.IO.File.WriteAllLines(@"C:\Users\Archer\Desktop" + @"\index.html", table);
        }

    }
}
