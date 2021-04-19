using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using YouTrackSharp;

namespace TimeTrackingYoutrack.Services
{
    public class HttpListenerYouTrack
    {

        public static void Run()
        {
            var methods = AppDomain.CurrentDomain.GetAssemblies() // Returns all currenlty loaded assemblies
                .SelectMany(x => x.GetTypes()) // returns all types defined in this assemblies
                .Where(x => x.IsClass) // only yields classes
                .SelectMany(x => x.GetMethods()) // returns all methods defined in those classes
                .Where(x => x.GetCustomAttributes(typeof(HttpAttribute), false).FirstOrDefault() != null); // returns only methods that have the InvokeAttribute

            var methodsDict = methods.ToDictionary(x => x.CustomAttributes.FirstOrDefault().ConstructorArguments[0].Value, x => x);

            var prefixes = new List<string>() { "http://+:8888/" };

            HttpListener listener = new HttpListener();
            foreach (string s in prefixes)
            {
                listener.Prefixes.Add(s);
            }
            listener.Start();

            while (true)
            {
                // Note: The GetContext method blocks while waiting for a request.
                HttpListenerContext context = listener.GetContext();

                HttpListenerRequest request = context.Request;
                

                var nameMethod = request.Url.AbsolutePath.Split('/')[1];
                var paramsQuery = new List<object>();
                

                var method = methodsDict[nameMethod];
                var typesOfParam = method.GetParameters();
                for (int i = 0; i < request.QueryString.Count; i++)
                {
                    var typeString = typesOfParam.Where(x => x.Name == request.QueryString.Keys[i]).FirstOrDefault().ParameterType.FullName;
                    var type = Type.GetType(typeString);


                    paramsQuery.Add(Convert.ChangeType(request.QueryString[i], type));
                }

                var obj = System.Activator.CreateInstance(method.DeclaringType); // Instantiate the class
                method.Invoke(obj, paramsQuery.ToArray()); // invoke the method
                string documentContents;
                using (Stream receiveStream = request.InputStream)
                {
                    using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                    {
                        documentContents = readStream.ReadToEnd();
                    }
                }


                /// Доделать методы, которые возвращают что-то

                //Console.WriteLine($"Recived request for {request.Url}");
                //Console.WriteLine(documentContents);

                //// Obtain a response object.
                //HttpListenerResponse response = context.Response;
                //// Construct a response.
                //string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
                //byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                //// Get a response stream and write the response to it.
                //response.ContentLength64 = buffer.Length;
                //System.IO.Stream output = response.OutputStream;
                //output.Write(buffer, 0, buffer.Length);
                //// You must close the output stream.
                //output.Close();
            }
            listener.Stop();
        }
    }
}
