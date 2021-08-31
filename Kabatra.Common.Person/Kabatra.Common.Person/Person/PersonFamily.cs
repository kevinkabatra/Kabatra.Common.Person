namespace Kabatra.Common.Person.Person
{
    using System.Collections.Generic;

    public partial class Person
    {
        private readonly List<Person> _parents = new();
        private readonly List<Person> _children = new();

        public bool AddChild(Person child)
        {
            if (_children.Contains(child))
            {
                return false;
            }

            _children.Add(child);
            return true;
        }

        public bool AddParent(Person parent)
        {
            if (_parents.Contains(parent))
            {
                return false;
            }

            _parents.Add(parent);
            return true;
        }

        public List<Person> GetParents()
        {
            return _parents;
        }

        public List<Person> GetChildren()
        {
            return _children;
        }

        public bool RemoveChild(Person child)
        {
            if (!_children.Contains(child))
            {
                return false;
            }

            _children.Remove(child);
            return true;
        }

        public bool RemoveParent(Person parent)
        {
            if (!_parents.Contains(parent))
            {
                return false;
            }

            _parents.Remove(parent);
            return true;
        }
    }
}
