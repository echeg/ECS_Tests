using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System422 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component67> _p1;
EcsPool<Component452> _p2;
EcsPool<Component352> _p3;
EcsPool<Component2> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component67>().Inc<Component452>().Inc<Component352>().End();
   _p1 = _world.GetPool<Component67>();
   _p2 = _world.GetPool<Component452>();
   _p3 = _world.GetPool<Component352>();
   _pl0 = _world.GetPool<Component2>();
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
