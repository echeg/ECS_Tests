using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System474 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component409> _p1;
EcsPool<Component164> _p2;
EcsPool<Component393> _p3;
EcsPool<Component252> _p4;
EcsPool<Component113> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component409>().Inc<Component164>().Inc<Component393>().Inc<Component252>().End();
   _p1 = _world.GetPool<Component409>();
   _p2 = _world.GetPool<Component164>();
   _p3 = _world.GetPool<Component393>();
   _p4 = _world.GetPool<Component252>();
   _pl0 = _world.GetPool<Component113>();
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
