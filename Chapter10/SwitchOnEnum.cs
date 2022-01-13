using System;
using System.Net;

using static System.Net.HttpStatusCode;
namespace Chapter10
{
    class SwitchOnEnum
    {
        public void HandleResponse(HttpWebResponse response)
        {
            switch (response.StatusCode)
            {
                case OK:
                    Console.WriteLine("Everything is fine");
                    break;
                case TemporaryRedirect:
                case Redirect:
                case RedirectMethod:
                    Console.WriteLine("We were redirected");
                    break;
                case NotFound:
                    Console.WriteLine("Couldn't find the content");
                    break;
                default:
                    Console.WriteLine("Don't really know...");
                    break;
            }
        }
    }
}
