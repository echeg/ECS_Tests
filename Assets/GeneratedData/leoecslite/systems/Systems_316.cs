using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System316 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component207> _p1;
EcsPool<Component95> _p2;
EcsPool<Component234> _pl0;
EcsPool<Component492> _pl1;
EcsPool<Component215> _pl2;
EcsPool<Component464> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component207>().Inc<Component95>().End();
   _p1 = _world.GetPool<Component207>();
   _p2 = _world.GetPool<Component95>();
   _pl0 = _world.GetPool<Component234>();
   _pl1 = _world.GetPool<Component492>();
   _pl2 = _world.GetPool<Component215>();
   _pl3 = _world.GetPool<Component464>();
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
