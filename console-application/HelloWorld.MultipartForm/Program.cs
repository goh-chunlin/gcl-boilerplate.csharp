using HelloWorld.MultipartForm.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace HelloWorld.MultipartForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 5) 
            {
                Console.WriteLine("ERROR: Please provide system ID and token.");
                return;
            }

            string serviceEndpoint = args[0];
            string systemId = args[1];
            string token = args[2];
            string message = args[3];
            string[] attachmentList = args[4].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(att => att.Trim()).ToArray();

            try 
            {
                SubmitMultipartForm(serviceEndpoint, systemId, token, message, attachmentList);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }

        private static void SubmitMultipartForm(string serviceEndpoint, string systemId, string token, 
            string message, string[] attachmentList) 
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("System-ID", systemId);
                client.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);

                string mainMessage =
                    "{ " +
                        "\"message\": \"" + ConvertToUnicodeString(message) + "\",  " +
                        "\"documentType\": \"PERSONAL\" " +
                    "}";

                var multipart = new MultipartFormBuilder();

                multipart.AddField("main_message", mainMessage);

                int counter = 0;
                foreach (string absoluteFilePath in attachmentList)
                {
                    counter += 1;

                    if (counter > 1)
                        multipart.AddFile("attachments_" + counter, new FileInfo(absoluteFilePath));
                    else
                        multipart.AddFile("attachments", new FileInfo(absoluteFilePath));
                }

                using (var stream = multipart.GetStream())
                {
                    client.Headers.Add("content-type", multipart.ContentType);

                    client.UploadData(serviceEndpoint, stream.ToArray());
                }
            }
        }

        private static string ConvertToUnicodeString(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var c in text)
            {
                sb.Append("\\u" + ((int)c).ToString("X4"));
            }

            return sb.ToString();
        }
    }
}
