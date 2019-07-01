using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Tests
    {
        public List<string> head;
        public List<string> row;
        public List<string> foot;

        public Tests()
        {
            this.head = new List<string>();
            this.row = new List<string>();
            this.foot = new List<string>();
        }

        public Tests(List<string> head, List<string> row, List<string> foot)
        {
            this.head = head;
            this.row = row;
            this.foot = foot;
        }

        public void Test1()
        {
            head.Add("1-1");
            head.Add("1-2");

            row.Add("2-1");
            row.Add("2-2");

            HTMLGenerator gen = new HTMLGenerator(head, row, foot);

            gen.GenerateTable();
            gen.ToFile();
        }

        public void Test2()
        {
            head.Add("1-1   Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vehicula erat eget felis rhoncus congue. Sed semper scelerisque nisl sit amet venenatis. Fusce auctor sem a cursus auctor. Curabitur mauris erat, tristique id magna ut, gravida fermentum justo. ");
            head.Add("1-2   Mauris rutrum odio velit. Cras vitae accumsan diam. Phasellus laoreet purus posuere suscipit faucibus. Nulla ultrices id enim sed pretium.");
            head.Add("1-3   Aenean quis odio suscipit, sollicitudin nisl luctus, consequat massa. Donec egestas lacus id massa efficitur congue.");

            foot.Add("2-1   Vivamus ullamcorper rhoncus neque, ac finibus lacus viverra ut. Maecenas hendrerit nisl vel quam scelerisque, ac commodo dolor mattis.");
            foot.Add("2-2   Maecenas sed faucibus quam. Etiam at sem bibendum, tempus neque quis, porta dolor. Curabitur quis vestibulum augue. Pellentesque et elit orci. Nunc eget auctor tortor, at lobortis risus.");
            foot.Add("2-3   Fusce eu orci consectetur, tincidunt magna vel, ultricies lacus. Nunc suscipit nunc in libero accumsan, congue tempor urna euismod. Lorem ipsum dolor sit amet, consectetur adipiscing elit.");

            HTMLGenerator gen = new HTMLGenerator(head, row, foot);

            gen.GenerateTable();
            gen.ToFile();
        }

        public void Test3()
        {
            head.Add("1-1   Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vehicula erat eget felis rhoncus congue. Sed semper scelerisque nisl sit amet venenatis. Fusce auctor sem a cursus auctor. Curabitur mauris erat, tristique id magna ut, gravida fermentum justo. ");
            head.Add("1-2   Mauris rutrum odio velit. Cras vitae accumsan diam. Phasellus laoreet purus posuere suscipit faucibus. Nulla ultrices id enim sed pretium.");
            head.Add("1-3   Aenean quis odio suscipit, sollicitudin nisl luctus, consequat massa. Donec egestas lacus id massa efficitur congue.");

            row.Add("2-1");
            row.Add("2-2");
            row.Add("2-3");

            foot.Add("3-1   Vivamus ullamcorper rhoncus neque, ac finibus lacus viverra ut. Maecenas hendrerit nisl vel quam scelerisque, ac commodo dolor mattis.");
            foot.Add("3-2   Maecenas sed faucibus quam. Etiam at sem bibendum, tempus neque quis, porta dolor. Curabitur quis vestibulum augue. Pellentesque et elit orci. Nunc eget auctor tortor, at lobortis risus.");
            foot.Add("3-3   Fusce eu orci consectetur, tincidunt magna vel, ultricies lacus. Nunc suscipit nunc in libero accumsan, congue tempor urna euismod. Lorem ipsum dolor sit amet, consectetur adipiscing elit.");

            HTMLGenerator gen = new HTMLGenerator(head, row, foot);

            gen.GenerateTable();
            gen.ToFile();
        }

        public void Test4()
        {
            head.Add("1-1");
            head.Add("1-2");
            head.Add("1-3");
            head.Add("1-4");
            head.Add("1-5");
            
            foot.Add("2-1");
            foot.Add("2-2");
            foot.Add("2-3");
            foot.Add("2-4");
            foot.Add("2-5");

            HTMLGenerator gen = new HTMLGenerator();
            gen.head = head;
            gen.foot = foot;

            gen.GenerateTable();
            gen.ToFile();
        }

        public void Test5()
        {
            head.Add("1-1");
            head.Add("1-2");

            row.Add("2-1");
            row.Add("2-2");

            row.Add("3-1");
            row.Add("3-2");

            row.Add("4-1");
            row.Add("4-2");

            foot.Add("5-1");
            foot.Add("5-2");
            

            HTMLGenerator gen = new HTMLGenerator();
            gen.head = head;
            gen.foot = foot;
            gen.row = row;

            gen.GenerateTable();
            gen.ToFile();
        }
    }
}
