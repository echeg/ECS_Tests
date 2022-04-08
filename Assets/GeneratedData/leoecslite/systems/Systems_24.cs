using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System24 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component335> _p1;
EcsPool<Component265> _p2;
EcsPool<Component256> _p3;
EcsPool<Component464> _pl0;
EcsPool<Component208> _pl1;
EcsPool<Component55> _pl2;
EcsPool<Component371> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component335>().Inc<Component265>().Inc<Component256>().End();
   _p1 = _world.GetPool<Component335>();
   _p2 = _world.GetPool<Component265>();
   _p3 = _world.GetPool<Component256>();
   _pl0 = _world.GetPool<Component464>();
   _pl1 = _world.GetPool<Component208>();
   _pl2 = _world.GetPool<Component55>();
   _pl3 = _world.GetPool<Component371>();
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
