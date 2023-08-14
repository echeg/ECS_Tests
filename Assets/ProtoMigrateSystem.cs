using EcsGenerator.LeoProto;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using UnityEngine;

namespace SimpleTest {
    internal class ProtoMigrateSystem : IProtoRunSystem, IProtoInitSystem {
        //[DI] private readonly Aspect1 _aspect2 = default;
        Aspect1 _aspect = null;
        ProtoIt _it1;
        ProtoIt _it2;

        public void Run() {
            foreach (var entity in _it1) {
                _aspect.Component2Pool.Add(entity);
                _aspect.Component1Pool.Del(entity);
#if UNITY_EDITOR
                Debug.Log("AAA Proto");
#endif
            }

            foreach (var entity in _it2) {
                _aspect.Component1Pool.Add(entity);
                _aspect.Component2Pool.Del(entity);
#if UNITY_EDITOR
                Debug.Log("BBB Proto");
#endif
            }
        }

        public void Init(IProtoSystems systems) {
            var world = systems.World();
            _aspect = (Aspect1)world.Aspect(typeof(Aspect1));
            _it1 = new ProtoIt(new[] { typeof(Component1) });
            _it1.Init(world);
            
            _it2 = new ProtoIt(new[] { typeof(Component2) });
            _it2.Init(world);
        }
    }
}