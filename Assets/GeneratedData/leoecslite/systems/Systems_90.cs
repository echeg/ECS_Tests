using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System90 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component235> _p1;
EcsPool<Component220> _p2;
EcsPool<Component137> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component235>().Inc<Component220>().Inc<Component137>().End();
   _p1 = _world.GetPool<Component235>();
   _p2 = _world.GetPool<Component220>();
   _p3 = _world.GetPool<Component137>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
