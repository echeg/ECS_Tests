using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System486 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component295> _p1;
EcsPool<Component64> _p2;
EcsPool<Component352> _p3;
EcsPool<Component251> _p4;
EcsPool<Component432> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component295>().Inc<Component64>().Inc<Component352>().Inc<Component251>().End();
   _p1 = _world.GetPool<Component295>();
   _p2 = _world.GetPool<Component64>();
   _p3 = _world.GetPool<Component352>();
   _p4 = _world.GetPool<Component251>();
   _pl0 = _world.GetPool<Component432>();
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
