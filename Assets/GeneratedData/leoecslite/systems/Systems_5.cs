using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System5 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component283> _p1;
EcsPool<Component10> _p2;
EcsPool<Component424> _p3;
EcsPool<Component200> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component283>().Inc<Component10>().Inc<Component424>().Inc<Component200>().End();
   _p1 = _world.GetPool<Component283>();
   _p2 = _world.GetPool<Component10>();
   _p3 = _world.GetPool<Component424>();
   _p4 = _world.GetPool<Component200>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
