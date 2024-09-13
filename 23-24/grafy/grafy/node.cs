using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class node
    {
        public int Data {  get; set; }
        public List <node> Children { get; set; }

        public node (int data)
        {
            Data = data;
            Children = new List <node> ();
        }

        public void AddChild(int childData)
        {
            node child = new node(childData);
            Children.Add (child);
        }

        public void go()
        {
            Console.Write(Data + " ");

            foreach(var child in Children)
            {
                child.go();            
            }
        }
    }
}
