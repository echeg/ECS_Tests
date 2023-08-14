using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System462 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component102> _p1;
EcsPool<Component35> _p2;
EcsPool<Component356> _p3;
EcsPool<Component260> _p4;
EcsPool<Component305> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component102>().Inc<Component35>().Inc<Component356>().Inc<Component260>().End();
   _p1 = _world.GetPool<Component102>();
   _p2 = _world.GetPool<Component35>();
   _p3 = _world.GetPool<Component356>();
   _p4 = _world.GetPool<Component260>();
   _pl0 = _world.GetPool<Component305>();
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
