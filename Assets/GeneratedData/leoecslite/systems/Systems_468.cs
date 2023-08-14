using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System468 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component95> _p1;
EcsPool<Component75> _p2;
EcsPool<Component379> _p3;
EcsPool<Component209> _p4;
EcsPool<Component31> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component95>().Inc<Component75>().Inc<Component379>().Inc<Component209>().End();
   _p1 = _world.GetPool<Component95>();
   _p2 = _world.GetPool<Component75>();
   _p3 = _world.GetPool<Component379>();
   _p4 = _world.GetPool<Component209>();
   _pl0 = _world.GetPool<Component31>();
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
