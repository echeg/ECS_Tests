using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System210 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component391> _p1;
EcsPool<Component281> _p2;
EcsPool<Component445> _p3;
EcsPool<Component344> _pl0;
EcsPool<Component467> _pl1;
EcsPool<Component414> _pl2;
EcsPool<Component279> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component391>().Inc<Component281>().Inc<Component445>().End();
   _p1 = _world.GetPool<Component391>();
   _p2 = _world.GetPool<Component281>();
   _p3 = _world.GetPool<Component445>();
   _pl0 = _world.GetPool<Component344>();
   _pl1 = _world.GetPool<Component467>();
   _pl2 = _world.GetPool<Component414>();
   _pl3 = _world.GetPool<Component279>();
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
