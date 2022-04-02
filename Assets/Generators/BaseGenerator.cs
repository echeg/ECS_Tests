using System.IO;

namespace EcsGenerator {
    public abstract class BaseGenerator {
        private string _workPath;
        protected readonly IEcsPresetDataProvider _dataProvider;

        public BaseGenerator(string workWorkPath, IEcsPresetDataProvider dataProvider) {
            _dataProvider = dataProvider;
            _workPath = workWorkPath;
        }

        public void Generate() {
            Cleanup();
            GenerateComponents();
            GenerateRunner();
            GenerateSystems();
        }

        private void GenerateComponents()
        {
            foreach (var component in _dataProvider.GetComponents())
            {
                SaveToFile($"Components{component.Id}.cs", GenerateComponent(component), "compoents");
            }
        }
        
        private void Cleanup() {
            var di = new DirectoryInfo(_workPath);
            if (!di.Exists) return;
            foreach (var file in di.GetFiles()) {
                file.Delete();
            }

            foreach (var dir in di.GetDirectories()) {
                dir.Delete(true);
            }
        }

        protected void SaveToFile(string filename, string fileContent, string dir = "") {
            fileContent = DecorateNamespace(fileContent);
            if (!string.IsNullOrEmpty(dir)) {
                dir += "/";
            }

            Directory.CreateDirectory(_workPath + dir);
            File.WriteAllText(_workPath + dir + filename, fileContent);
        }

        protected virtual string DecorateNamespace(string fileContent) {
            return fileContent;
        }
        
        private void GenerateSystems()
        {
            foreach (var system in _dataProvider.GetSystems())
            {
                var fileContent = GenerateSystem(system);
                SaveToFile($"Systems_{system.Id}.cs", fileContent, "systems");
            }
        }

        protected abstract string GenerateSystem(DslSystem s);
        protected abstract string GenerateComponent(DslComponent c);
        protected abstract void GenerateRunner();

    }
}