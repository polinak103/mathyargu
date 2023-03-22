using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;

namespace Project.Service
{
    class FileIOService
    {
        private readonly string FilePath;
        public FileIOService(string filePath)
        {
            FilePath = filePath;
        }
        public BindingList<ToDoModel> LoadData()
        {
            var fileExists = File.Exists(FilePath);
            if(!fileExists)
            {
                File.CreateText(FilePath).Dispose();
                return new BindingList<ToDoModel>();

            }
            using (var reader = File.OpenText(FilePath))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<ToDoModel>>(fileText);
            }
        }
        public void SaveData(object todoDataList)
        {
            using(StreamWriter writer = File.CreateText(FilePath))
            {
                string output = JsonConvert.SerializeObject(todoDataList);
                writer.Write(output);
            }
        }

    }
}
