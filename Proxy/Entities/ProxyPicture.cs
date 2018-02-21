namespace Proxy.Entities
{
    using Interfaces;

    public class ProxyPicture : IPicture
    {
        RealPicture realPicture;
        private string fileName;

        public ProxyPicture(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (realPicture == null)
            {
                realPicture = new RealPicture(fileName);
            }
            realPicture.Display();
        }
    }
}