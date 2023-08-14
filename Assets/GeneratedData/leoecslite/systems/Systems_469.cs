using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System469 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component109> _p1;
EcsPool<Component315> _p2;
EcsPool<Component471> _p3;
EcsPool<Component88> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component109>().Inc<Component315>().Inc<Component471>().End();
   _p1 = _world.GetPool<Component109>();
   _p2 = _world.GetPool<Component315>();
   _p3 = _world.GetPool<Component471>();
   _pl0 = _world.GetPool<Component88>();
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
