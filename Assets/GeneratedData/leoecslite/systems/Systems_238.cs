using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System238 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component338> _p1;
EcsPool<Component118> _p2;
EcsPool<Component489> _p3;
EcsPool<Component30> _pl0;
EcsPool<Component420> _pl1;
EcsPool<Component56> _pl2;
EcsPool<Component493> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component338>().Inc<Component118>().Inc<Component489>().End();
   _p1 = _world.GetPool<Component338>();
   _p2 = _world.GetPool<Component118>();
   _p3 = _world.GetPool<Component489>();
   _pl0 = _world.GetPool<Component30>();
   _pl1 = _world.GetPool<Component420>();
   _pl2 = _world.GetPool<Component56>();
   _pl3 = _world.GetPool<Component493>();
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
