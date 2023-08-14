using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System5 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component38> _p1;
EcsPool<Component235> _p2;
EcsPool<Component379> _p3;
EcsPool<Component189> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component38>().Inc<Component235>().Inc<Component379>().Inc<Component189>().End();
   _p1 = _world.GetPool<Component38>();
   _p2 = _world.GetPool<Component235>();
   _p3 = _world.GetPool<Component379>();
   _p4 = _world.GetPool<Component189>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
