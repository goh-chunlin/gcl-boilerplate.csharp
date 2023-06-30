using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld.MultipartForm.Util
{
    /*
        The following class was inspired by ericvoid from São Paulo - Brasil

        Reference: https://gist.github.com/ericvoid/568d733c90857f010fb860cb5e6aba43
     */
    public class MultipartFormBuilder
    {
        static readonly string MultipartContentType = "multipart/form-data; boundary=";
        static readonly string FileHeaderTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\n\r\n";
        static readonly string FormDataTemplate = "\r\n--{0}\r\nContent-Disposition: form-data; name=\"{1}\";\r\n\r\n{2}";

        public string ContentType { get; private set; }

        string Boundary { get; set; }

        Dictionary<string, FileInfo> FilesToSend { get; set; }
        Dictionary<string, string> FieldsToSend { get; set; }

        public MultipartFormBuilder()
        {
            Boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");

            FilesToSend = new Dictionary<string, FileInfo>();
            FieldsToSend = new Dictionary<string, string>();

            ContentType = MultipartContentType + Boundary;
        }

        public void AddField(string key, string value)
        {
            FieldsToSend.Add(key, value);
        }

        public void AddFile(FileInfo file)
        {
            string key = file.Extension.Substring(1);
            FilesToSend.Add(key, file);
        }

        public void AddFile(string key, FileInfo file)
        {
            FilesToSend.Add(key, file);
        }

        public MemoryStream GetStream()
        {
            var memStream = new MemoryStream();

            WriteFields(memStream);
            WriteStreams(memStream);
            WriteTrailer(memStream);

            memStream.Seek(0, SeekOrigin.Begin);

            return memStream;
        }

        void WriteFields(Stream stream)
        {
            if (FieldsToSend.Count == 0)
                return;

            foreach (var fieldEntry in FieldsToSend)
            {
                string content = string.Format(FormDataTemplate, Boundary, fieldEntry.Key, fieldEntry.Value);

                using (var fieldData = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    CopyTo(fieldData, stream, 81920);
                }
            }
        }

        void WriteStreams(Stream stream)
        {
            if (FilesToSend.Count == 0)
                return;

            foreach (var fileEntry in FilesToSend)
            {
                WriteBoundary(stream);

                // This is to make sure the name of all files are all named "attachments" when sent to the server
                string fileHeaderName = fileEntry.Key.Split(new char[] { '_' })[0];

                string header = string.Format(FileHeaderTemplate, fileHeaderName, fileEntry.Value.Name);
                byte[] headerbytes = Encoding.UTF8.GetBytes(header);
                stream.Write(headerbytes, 0, headerbytes.Length);

                using (var fileData = System.IO.File.OpenRead(fileEntry.Value.FullName))
                {
                    CopyTo(fileData, stream, 81920);
                }
            }
        }

        void WriteBoundary(Stream stream)
        {
            byte[] boundarybytes = Encoding.UTF8.GetBytes("\r\n--" + Boundary + "\r\n");
            stream.Write(boundarybytes, 0, boundarybytes.Length);
        }

        void WriteTrailer(Stream stream)
        {
            byte[] trailer = Encoding.UTF8.GetBytes("\r\n--" + Boundary + "--\r\n");
            stream.Write(trailer, 0, trailer.Length);
        }

        void CopyTo(Stream source, Stream destination, int bufferSize)
        {
            byte[] array = new byte[bufferSize];
            int count;
            while ((count = source.Read(array, 0, array.Length)) != 0)
            {
                destination.Write(array, 0, count);
            }
        }
    }
}
