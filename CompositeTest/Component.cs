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

        public abstract Dictionary<int, List<int>> GetChildren();
    }

    class Number : Component
    {
        private List<Component> _children = new List<Component>();

        public Number(int level) : base(level)
        {
            if (level - 1 == 0) return;
            _children = new List<Component> { new Number(level - 1), new Number(level - 1) };
        }

        public override Dictionary<int, List<int>> GetChildren()
        {
            var dict = new Dictionary<int, List<int>>
            {
                { level, new List<int> { level } }
            };

            foreach (var child in _children)
            {
                foreach (var childDict in child.GetChildren())
                {
                    if (dict.ContainsKey(childDict.Key))
                    {
                        dict[childDict.Key].AddRange(childDict.Value);
                    }
                    else
                    {
                        dict.Add(childDict.Key, childDict.Value);
                    }
                }
            }

            return dict;
        }
    }
}