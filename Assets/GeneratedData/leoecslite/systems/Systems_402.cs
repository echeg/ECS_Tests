using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System402 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component318> _p1;
EcsPool<Component367> _p2;
EcsPool<Component235> _p3;
EcsPool<Component435> _p4;
EcsPool<Component17> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component318>().Inc<Component367>().Inc<Component235>().Inc<Component435>().End();
   _p1 = _world.GetPool<Component318>();
   _p2 = _world.GetPool<Component367>();
   _p3 = _world.GetPool<Component235>();
   _p4 = _world.GetPool<Component435>();
   _pl0 = _world.GetPool<Component17>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
