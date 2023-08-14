using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System444 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component268> _p1;
EcsPool<Component255> _p2;
EcsPool<Component136> _p3;
EcsPool<Component357> _p4;
EcsPool<Component210> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component268>().Inc<Component255>().Inc<Component136>().Inc<Component357>().End();
   _p1 = _world.GetPool<Component268>();
   _p2 = _world.GetPool<Component255>();
   _p3 = _world.GetPool<Component136>();
   _p4 = _world.GetPool<Component357>();
   _pl0 = _world.GetPool<Component210>();
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
