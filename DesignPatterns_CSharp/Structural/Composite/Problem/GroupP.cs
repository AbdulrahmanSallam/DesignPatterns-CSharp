namespace DesignPatterns_CSharp.Structural.Composite.Problem
{
    public class GroupP
    {
        private readonly List<object> _objects = [];


        public void Add(object @object)
        {
            _objects.Add(@object);
        }

        public void Render()
        {
            foreach(var @object in _objects)
            {
                if (@object is ShapeP)
                {
                    ((ShapeP)@object).Render();
                }
                else if (@object is GroupP)
                    ((GroupP)@object).Render();

            }
        }
        
    }
}
