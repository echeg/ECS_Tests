using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System187 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component0> _p1;
EcsPool<Component220> _p2;
EcsPool<Component381> _p3;
EcsPool<Component120> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component0>().Inc<Component220>().Inc<Component381>().Inc<Component120>().End();
   _p1 = _world.GetPool<Component0>();
   _p2 = _world.GetPool<Component220>();
   _p3 = _world.GetPool<Component381>();
   _p4 = _world.GetPool<Component120>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
