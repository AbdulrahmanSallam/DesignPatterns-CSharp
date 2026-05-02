namespace DesignPatterns_CSharp.Structural.Composite.Solution
{
    // Composite 
    public class Group:IComponent
    {
        private List<IComponent> _components = [];


        public void Add (IComponent shape)
        {
            _components.Add(shape);
        }

        public void Render()
        {
            foreach (var component in _components)
            {
                component.Render();
            }
        }
        public void Move()
        {
            foreach (var component in _components)
            {
                component.Move();
            }
        }

    }
}


