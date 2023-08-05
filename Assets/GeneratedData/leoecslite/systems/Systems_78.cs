using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System78 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component97> _p1;
EcsPool<Component128> _p2;
EcsPool<Component100> _p3;
EcsPool<Component320> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component97>().Inc<Component128>().Inc<Component100>().Inc<Component320>().End();
   _p1 = _world.GetPool<Component97>();
   _p2 = _world.GetPool<Component128>();
   _p3 = _world.GetPool<Component100>();
   _p4 = _world.GetPool<Component320>();
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
