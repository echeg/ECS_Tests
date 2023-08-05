using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System337 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component434> _p1;
EcsPool<Component497> _p2;
EcsPool<Component237> _p3;
EcsPool<Component424> _p4;
EcsPool<Component271> _pl0;
EcsPool<Component256> _pl1;
EcsPool<Component55> _pl2;
EcsPool<Component200> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component434>().Inc<Component497>().Inc<Component237>().Inc<Component424>().End();
   _p1 = _world.GetPool<Component434>();
   _p2 = _world.GetPool<Component497>();
   _p3 = _world.GetPool<Component237>();
   _p4 = _world.GetPool<Component424>();
   _pl0 = _world.GetPool<Component271>();
   _pl1 = _world.GetPool<Component256>();
   _pl2 = _world.GetPool<Component55>();
   _pl3 = _world.GetPool<Component200>();
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
