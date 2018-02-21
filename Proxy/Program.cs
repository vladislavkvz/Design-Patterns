namespace Proxy
{
    using Entities;
    using Interfaces;
    using System;

    class Program
    {
        static void Main()
        {
            IPicture pic = new ProxyPicture("testImage.jpg");

            //image will be loaded from disk      
            pic.Display();
            Console.WriteLine("");         
            //image will not be loaded from disk    
            pic.Display();   
        }
    }
}