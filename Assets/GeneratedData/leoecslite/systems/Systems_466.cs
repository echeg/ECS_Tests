using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System466 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component178> _p1;
EcsPool<Component314> _p2;
EcsPool<Component437> _p3;
EcsPool<Component482> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component178>().Inc<Component314>().Inc<Component437>().End();
   _p1 = _world.GetPool<Component178>();
   _p2 = _world.GetPool<Component314>();
   _p3 = _world.GetPool<Component437>();
   _pl0 = _world.GetPool<Component482>();
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
