using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System346 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component314> _p1;
EcsPool<Component315> _p2;
EcsPool<Component310> _p3;
EcsPool<Component459> _pl0;
EcsPool<Component125> _pl1;
EcsPool<Component380> _pl2;
EcsPool<Component60> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component314>().Inc<Component315>().Inc<Component310>().End();
   _p1 = _world.GetPool<Component314>();
   _p2 = _world.GetPool<Component315>();
   _p3 = _world.GetPool<Component310>();
   _pl0 = _world.GetPool<Component459>();
   _pl1 = _world.GetPool<Component125>();
   _pl2 = _world.GetPool<Component380>();
   _pl3 = _world.GetPool<Component60>();
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
