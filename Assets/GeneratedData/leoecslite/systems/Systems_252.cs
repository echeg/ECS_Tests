using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System252 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component152> _p1;
EcsPool<Component209> _p2;
EcsPool<Component101> _p3;
EcsPool<Component457> _p4;
EcsPool<Component69> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component152>().Inc<Component209>().Inc<Component101>().Inc<Component457>().End();
   _p1 = _world.GetPool<Component152>();
   _p2 = _world.GetPool<Component209>();
   _p3 = _world.GetPool<Component101>();
   _p4 = _world.GetPool<Component457>();
   _pl0 = _world.GetPool<Component69>();
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
