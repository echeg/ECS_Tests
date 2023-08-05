using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System295 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component286> _p1;
EcsPool<Component40> _p2;
EcsPool<Component130> _p3;
EcsPool<Component404> _p4;
EcsPool<Component40> _pl0;
EcsPool<Component12> _pl1;
EcsPool<Component138> _pl2;
EcsPool<Component189> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component286>().Inc<Component40>().Inc<Component130>().Inc<Component404>().End();
   _p1 = _world.GetPool<Component286>();
   _p2 = _world.GetPool<Component40>();
   _p3 = _world.GetPool<Component130>();
   _p4 = _world.GetPool<Component404>();
   _pl0 = _world.GetPool<Component40>();
   _pl1 = _world.GetPool<Component12>();
   _pl2 = _world.GetPool<Component138>();
   _pl3 = _world.GetPool<Component189>();
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
