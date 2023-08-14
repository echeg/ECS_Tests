using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System144 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component139> _p1;
EcsPool<Component235> _p2;
EcsPool<Component457> _p3;
EcsPool<Component67> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component139>().Inc<Component235>().Inc<Component457>().Inc<Component67>().End();
   _p1 = _world.GetPool<Component139>();
   _p2 = _world.GetPool<Component235>();
   _p3 = _world.GetPool<Component457>();
   _p4 = _world.GetPool<Component67>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
