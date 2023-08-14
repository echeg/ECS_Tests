using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System10 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component494> _p1;
EcsPool<Component11> _p2;
EcsPool<Component445> _p3;
EcsPool<Component379> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component494>().Inc<Component11>().Inc<Component445>().Inc<Component379>().End();
   _p1 = _world.GetPool<Component494>();
   _p2 = _world.GetPool<Component11>();
   _p3 = _world.GetPool<Component445>();
   _p4 = _world.GetPool<Component379>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
