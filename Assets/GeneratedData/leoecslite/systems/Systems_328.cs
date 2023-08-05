using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System328 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component265> _p1;
EcsPool<Component413> _p2;
EcsPool<Component314> _pl0;
EcsPool<Component407> _pl1;
EcsPool<Component269> _pl2;
EcsPool<Component381> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component265>().Inc<Component413>().End();
   _p1 = _world.GetPool<Component265>();
   _p2 = _world.GetPool<Component413>();
   _pl0 = _world.GetPool<Component314>();
   _pl1 = _world.GetPool<Component407>();
   _pl2 = _world.GetPool<Component269>();
   _pl3 = _world.GetPool<Component381>();
 }
 public void Run (EcsSystems systems) {
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
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
