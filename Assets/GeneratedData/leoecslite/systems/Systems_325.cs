using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System325 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component123> _p1;
EcsPool<Component348> _p2;
EcsPool<Component423> _pl0;
EcsPool<Component407> _pl1;
EcsPool<Component318> _pl2;
EcsPool<Component403> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component123>().Inc<Component348>().End();
   _p1 = _world.GetPool<Component123>();
   _p2 = _world.GetPool<Component348>();
   _pl0 = _world.GetPool<Component423>();
   _pl1 = _world.GetPool<Component407>();
   _pl2 = _world.GetPool<Component318>();
   _pl3 = _world.GetPool<Component403>();
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
