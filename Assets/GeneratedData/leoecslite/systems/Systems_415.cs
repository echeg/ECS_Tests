using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System415 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component345> _p1;
EcsPool<Component10> _p2;
EcsPool<Component13> _p3;
EcsPool<Component90> _p4;
EcsPool<Component446> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component345>().Inc<Component10>().Inc<Component13>().Inc<Component90>().End();
   _p1 = _world.GetPool<Component345>();
   _p2 = _world.GetPool<Component10>();
   _p3 = _world.GetPool<Component13>();
   _p4 = _world.GetPool<Component90>();
   _pl0 = _world.GetPool<Component446>();
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
