using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System137 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component176> _p1;
EcsPool<Component267> _p2;
EcsPool<Component335> _p3;
EcsPool<Component453> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component176>().Inc<Component267>().Inc<Component335>().Inc<Component453>().End();
   _p1 = _world.GetPool<Component176>();
   _p2 = _world.GetPool<Component267>();
   _p3 = _world.GetPool<Component335>();
   _p4 = _world.GetPool<Component453>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
