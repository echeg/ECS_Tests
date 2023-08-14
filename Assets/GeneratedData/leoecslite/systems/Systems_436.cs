using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System436 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component293> _p1;
EcsPool<Component168> _p2;
EcsPool<Component123> _p3;
EcsPool<Component106> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component293>().Inc<Component168>().Inc<Component123>().End();
   _p1 = _world.GetPool<Component293>();
   _p2 = _world.GetPool<Component168>();
   _p3 = _world.GetPool<Component123>();
   _pl0 = _world.GetPool<Component106>();
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
