using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System482 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component384> _p1;
EcsPool<Component445> _p2;
EcsPool<Component421> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component384>().Inc<Component445>().End();
   _p1 = _world.GetPool<Component384>();
   _p2 = _world.GetPool<Component445>();
   _pl0 = _world.GetPool<Component421>();
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
