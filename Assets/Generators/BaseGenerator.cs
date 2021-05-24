using System.IO;

namespace EcsGenerator
{
    public class BaseGenerator
    {
        protected string _workPath;
        protected IEcsPresetDataProvider _dataProvider;

        public BaseGenerator(string workWorkPath, IEcsPresetDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
            _workPath = workWorkPath;
        }
        
        public virtual void Generate()
        {
            Cleanup();
        }

        private void Cleanup()
        {
            var di = new DirectoryInfo(_workPath);
            if (!di.Exists) return;
            foreach (var file in di.GetFiles())
            {
                file.Delete();
            }

            foreach (var dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        
        protected void SaveToFile(string filename, string fileContent)
        {
            fileContent = DecorateNamespace(fileContent);
            Directory.CreateDirectory(_workPath);
            File.WriteAllText(_workPath + filename, fileContent);
        }

        protected virtual string DecorateNamespace(string fileContent)
        {
            return fileContent;
        }
    }
}