using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System451 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component235> _p1;
EcsPool<Component171> _p2;
EcsPool<Component71> _p3;
EcsPool<Component20> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component235>().Inc<Component171>().Inc<Component71>().End();
   _p1 = _world.GetPool<Component235>();
   _p2 = _world.GetPool<Component171>();
   _p3 = _world.GetPool<Component71>();
   _pl0 = _world.GetPool<Component20>();
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