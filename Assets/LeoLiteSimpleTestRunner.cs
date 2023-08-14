using EcsGenerator;
using EcsGenerator.LeoEcsLite;
using Leopotam.EcsLite;
using UnityEngine;

namespace SimpleTest {
    class LeoLiteSimpleTestRunner : MonoBehaviour, IEcsRunner {
        EcsWorld _world;
        EcsSystems _systems;
        public void Init() {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);
            _systems.Add(new LiteMigrateSystem());
            _systems.Init ();
        }
        public void GenStartEntities() {
            LeoEcsLiteRunner.GenStartEntities(_world);
        }
        public void Run() {
            _systems.Run();
        }
        public void GenInfo(){
            Debug.Log("e " + _world.GetEntitiesCount());
        }
        public void CopyWorld(int i) {
            throw new System.NotImplementedException();
        }
    }
}