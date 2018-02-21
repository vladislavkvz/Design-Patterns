namespace Mediator.Entities
{
    using System;

    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine(DateTime.Now.ToString() + " [" + user.GetName() + "] : " + message);
        }
    }
}