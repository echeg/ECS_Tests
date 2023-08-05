using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System292 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component401> _p1;
EcsPool<Component483> _pl0;
EcsPool<Component83> _pl1;
EcsPool<Component81> _pl2;
EcsPool<Component316> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component401>().End();
   _p1 = _world.GetPool<Component401>();
   _pl0 = _world.GetPool<Component483>();
   _pl1 = _world.GetPool<Component83>();
   _pl2 = _world.GetPool<Component81>();
   _pl3 = _world.GetPool<Component316>();
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
