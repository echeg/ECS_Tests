using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System19 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component261> _p1;
EcsPool<Component174> _p2;
EcsPool<Component288> _p3;
EcsPool<Component291> _p4;
EcsPool<Component99> _pl0;
EcsPool<Component366> _pl1;
EcsPool<Component400> _pl2;
EcsPool<Component114> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component261>().Inc<Component174>().Inc<Component288>().Inc<Component291>().End();
   _p1 = _world.GetPool<Component261>();
   _p2 = _world.GetPool<Component174>();
   _p3 = _world.GetPool<Component288>();
   _p4 = _world.GetPool<Component291>();
   _pl0 = _world.GetPool<Component99>();
   _pl1 = _world.GetPool<Component366>();
   _pl2 = _world.GetPool<Component400>();
   _pl3 = _world.GetPool<Component114>();
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
