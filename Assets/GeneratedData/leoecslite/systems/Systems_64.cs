using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System64 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component446> _p1;
EcsPool<Component377> _p2;
EcsPool<Component200> _p3;
EcsPool<Component421> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component446>().Inc<Component377>().Inc<Component200>().Inc<Component421>().End();
   _p1 = _world.GetPool<Component446>();
   _p2 = _world.GetPool<Component377>();
   _p3 = _world.GetPool<Component200>();
   _p4 = _world.GetPool<Component421>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
