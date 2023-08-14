using Leopotam.EcsLite;
using UnityEngine;
using Component1 = EcsGenerator.LeoEcsLite.Component1;
using Component2 = EcsGenerator.LeoEcsLite.Component2;

namespace SimpleTest {
    internal class LiteMigrateSystem : IEcsRunSystem, IEcsInitSystem {
        private EcsWorld _world = null;
        private EcsPool<Component1> _p1;
        private EcsPool<Component2> _p2;
        private EcsFilter _filter1;
        private EcsFilter _filter2;

        public void Init(IEcsSystems systems) {
            _world = systems.GetWorld();
            _p1 = _world.GetPool<Component1>();
            _p2 = _world.GetPool<Component2>();
            _filter1 = _world.Filter<Component1>().End();
            _filter2 = _world.Filter<Component2>().End();
        }
        public void Run(IEcsSystems systems) {
            foreach (var entity in _filter1) {
                _p2.Add(entity);
                _p1.Del(entity);
#if UNITY_EDITOR
                Debug.Log("AAA Lite");
#endif
            }

            foreach (var entity in _filter2) {
                _p1.Add(entity);
                _p2.Del(entity);
#if UNITY_EDITOR
                Debug.Log("BBB Lite");
#endif
            }
        }
    }

    /*
    internal class ProtoAspect2 : ProtoAspectInject {
        public readonly ProtoPool<Component1> C1;
        public readonly ProtoPool<Component2> C2;
        public ProtoIt C1It = new(It.Inc<Component1>());
        public ProtoIt C2It = new(It.Inc<Component2>());
    }
    */
}