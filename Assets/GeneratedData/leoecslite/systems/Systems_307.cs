using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System307 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component174> _p1;
EcsPool<Component332> _p2;
EcsPool<Component154> _p3;
EcsPool<Component127> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component174>().Inc<Component332>().Inc<Component154>().End();
   _p1 = _world.GetPool<Component174>();
   _p2 = _world.GetPool<Component332>();
   _p3 = _world.GetPool<Component154>();
   _pl0 = _world.GetPool<Component127>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
