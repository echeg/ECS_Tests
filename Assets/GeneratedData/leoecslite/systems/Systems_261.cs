using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System261 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component479> _p1;
EcsPool<Component122> _p2;
EcsPool<Component138> _p3;
EcsPool<Component43> _p4;
EcsPool<Component144> _pl0;
EcsPool<Component64> _pl1;
EcsPool<Component288> _pl2;
EcsPool<Component71> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component479>().Inc<Component122>().Inc<Component138>().Inc<Component43>().End();
   _p1 = _world.GetPool<Component479>();
   _p2 = _world.GetPool<Component122>();
   _p3 = _world.GetPool<Component138>();
   _p4 = _world.GetPool<Component43>();
   _pl0 = _world.GetPool<Component144>();
   _pl1 = _world.GetPool<Component64>();
   _pl2 = _world.GetPool<Component288>();
   _pl3 = _world.GetPool<Component71>();
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
