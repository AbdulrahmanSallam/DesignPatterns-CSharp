namespace DesignPatterns_CSharp.Structural.Adapter.Problem
{
    public class ImageViewP
    {
        private readonly ImageP _image;

        public ImageViewP(ImageP image)
        {
            _image = image;
        }

        public void Apply(IFilterP filter)
        {
            filter.Apply(_image);
        }

    }
}
