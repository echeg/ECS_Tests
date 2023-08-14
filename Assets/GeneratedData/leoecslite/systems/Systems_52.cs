using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System52 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component485> _p1;
EcsPool<Component400> _p2;
EcsPool<Component230> _p3;
EcsPool<Component67> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component485>().Inc<Component400>().Inc<Component230>().Inc<Component67>().End();
   _p1 = _world.GetPool<Component485>();
   _p2 = _world.GetPool<Component400>();
   _p3 = _world.GetPool<Component230>();
   _p4 = _world.GetPool<Component67>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
