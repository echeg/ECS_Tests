using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System33 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component195> _p1;
EcsPool<Component118> _p2;
EcsPool<Component364> _p3;
EcsPool<Component95> _pl0;
EcsPool<Component103> _pl1;
EcsPool<Component7> _pl2;
EcsPool<Component200> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component195>().Inc<Component118>().Inc<Component364>().End();
   _p1 = _world.GetPool<Component195>();
   _p2 = _world.GetPool<Component118>();
   _p3 = _world.GetPool<Component364>();
   _pl0 = _world.GetPool<Component95>();
   _pl1 = _world.GetPool<Component103>();
   _pl2 = _world.GetPool<Component7>();
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
