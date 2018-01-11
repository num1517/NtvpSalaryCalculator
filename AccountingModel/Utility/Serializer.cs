using System.Collections.Generic;
using AccountingModel.AccountingTypes;
using Newtonsoft.Json;
using System.IO;

namespace AccountingModel.Utility
{
    public class Serializer
    {
        JsonSerializerSettings settings;

        public Serializer()
        {
            settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
        }

        public void Serialize(List <Worker> workers, Stream fileStream)
        {
            string workersSerializedToString =
                JsonConvert.SerializeObject(workers, settings);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(workersSerializedToString);
            streamWriter.Flush();
            streamWriter.Close();
        }

        public List<Worker> Deserialize(Stream fileStream)
        {
            List<Worker> WorkerList = null;
            StreamReader streamReader = new StreamReader(fileStream);
            WorkerList = 
                JsonConvert.DeserializeObject<List<Worker>>(
                    streamReader.ReadLine(), settings);
            streamReader.Close();
            return WorkerList;
        }
    }
}
