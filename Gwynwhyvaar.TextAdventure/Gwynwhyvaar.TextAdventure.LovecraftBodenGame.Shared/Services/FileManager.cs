using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class FileManager<TEntity> : IFileManagerService<TEntity>
    {
        private static FileManager<TEntity> _instance;
        public static FileManager<TEntity> Instance => _instance ??= new FileManager<TEntity>();

        public TEntity Load(string fileName)
        {
            var dataSerializer = new DataContractSerializer(typeof(TEntity));
            var content =  File.ReadAllText(fileName);

            using (Stream stream = new MemoryStream())
            {
                var data = System.Text.Encoding.UTF8.GetBytes(content);
                stream.Write(data, 0, data.Length);
                stream.Position = 0;
                return (TEntity)dataSerializer.ReadObject(stream);
            }
        }

        public void Save(TEntity file, string fileName)
        {
            try
            {
                if (file == null) return;
                try
                {
                    var dataSerializer = new DataContractSerializer(typeof(TEntity));
                    string xmlString;
                    using (var sw = new StringWriter())
                    {
                        using (var writer = new XmlTextWriter(sw))
                        {
                            writer.Formatting = Formatting.Indented; // indent the Xml so it's human readable
                            dataSerializer.WriteObject(writer, file);
                            writer.Flush();
                            xmlString = sw.ToString();
                            File.WriteAllText(fileName, xmlString);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TEntity Update(TEntity file, string fileName)
        {
            // todo: fix this ...
            var data =  Load(fileName);
            data = file; 
            Save(data, fileName);
            return file;
        }
    }
}