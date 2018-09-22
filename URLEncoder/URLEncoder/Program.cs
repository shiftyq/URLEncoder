using System;
using System.IO;

using System.Web;


namespace URLEncoder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of your project: ");
            string project = Console.ReadLine();
            Console.WriteLine("Please enter the name of the activity:  ");
            string act = Console.ReadLine();

            var FullUrl = System.Web.HttpUtility.UrlEncode(project);

            Console.WriteLine("Test Url :" + project + act);
            Console.WriteLine("HttpUtility.UrlEncode :" + FullUrl);

            FullUrl = System.Net.WebUtility.UrlEncode(project);
            Console.WriteLine("WebUtility.UrlEncode :" + FullUrl);
        }

    }

}



        
        
    




