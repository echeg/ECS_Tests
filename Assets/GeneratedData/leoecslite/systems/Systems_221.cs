using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System221 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component381> _p1;
EcsPool<Component344> _p2;
EcsPool<Component422> _p3;
EcsPool<Component396> _pl0;
EcsPool<Component55> _pl1;
EcsPool<Component30> _pl2;
EcsPool<Component485> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component381>().Inc<Component344>().Inc<Component422>().End();
   _p1 = _world.GetPool<Component381>();
   _p2 = _world.GetPool<Component344>();
   _p3 = _world.GetPool<Component422>();
   _pl0 = _world.GetPool<Component396>();
   _pl1 = _world.GetPool<Component55>();
   _pl2 = _world.GetPool<Component30>();
   _pl3 = _world.GetPool<Component485>();
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
