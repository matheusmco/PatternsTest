using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositeTest
{
    abstract class Component
    {
        protected int level;

        public Component(int level)
        {
            this.level = level;
        }

        public abstract void Add(Component c);
        public abstract void Display(int l);
    }

    class Number : Component
    {
        private List<Component> _children = new List<Component>();

        public Number(int level) : base(level) { }

        public override void Add(Component c) => _children.Add(c);

        public override void Display(int l)
        {
            Console.Write(new String(char.Parse(level.ToString()), l));
            Console.WriteLine();

            foreach (var item in _children)
            {
                item.Display(l + 1);
            }
        }
    }
}