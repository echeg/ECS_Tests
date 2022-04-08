using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System17 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component323> _p1;
EcsPool<Component261> _p2;
EcsPool<Component466> _p3;
EcsPool<Component320> _pl0;
EcsPool<Component444> _pl1;
EcsPool<Component307> _pl2;
EcsPool<Component9> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component323>().Inc<Component261>().Inc<Component466>().End();
   _p1 = _world.GetPool<Component323>();
   _p2 = _world.GetPool<Component261>();
   _p3 = _world.GetPool<Component466>();
   _pl0 = _world.GetPool<Component320>();
   _pl1 = _world.GetPool<Component444>();
   _pl2 = _world.GetPool<Component307>();
   _pl3 = _world.GetPool<Component9>();
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
