using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System429 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component250> _p1;
EcsPool<Component423> _p2;
EcsPool<Component84> _p3;
EcsPool<Component187> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component250>().Inc<Component423>().Inc<Component84>().End();
   _p1 = _world.GetPool<Component250>();
   _p2 = _world.GetPool<Component423>();
   _p3 = _world.GetPool<Component84>();
   _pl0 = _world.GetPool<Component187>();
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
