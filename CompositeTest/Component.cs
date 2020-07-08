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

        public Number(int level) : base(level)
        {
            if (level == 0) return;
            // TODO: improve this add
            _children = new List<Component> { new Number(level - 1), new Number(level - 1) };
        }

        public override void Add(Component c) => _children.Add(c);

        public override void Display(int l)
        {
            Console.Write(level);

            if (_children != null && _children.Any()) Console.WriteLine();

            foreach (var item in _children)
            {
                item.Display(l + 1);
            }
        }
    }
}