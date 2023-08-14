using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System181 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component181> _p1;
EcsPool<Component37> _p2;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component181>().Inc<Component37>().End();
   _p1 = _world.GetPool<Component181>();
   _p2 = _world.GetPool<Component37>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}