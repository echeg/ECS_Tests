using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System34 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component450> _p1;
EcsPool<Component467> _p2;
EcsPool<Component155> _p3;
EcsPool<Component407> _p4;
EcsPool<Component188> _pl0;
EcsPool<Component217> _pl1;
EcsPool<Component379> _pl2;
EcsPool<Component362> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component450>().Inc<Component467>().Inc<Component155>().Inc<Component407>().End();
   _p1 = _world.GetPool<Component450>();
   _p2 = _world.GetPool<Component467>();
   _p3 = _world.GetPool<Component155>();
   _p4 = _world.GetPool<Component407>();
   _pl0 = _world.GetPool<Component188>();
   _pl1 = _world.GetPool<Component217>();
   _pl2 = _world.GetPool<Component379>();
   _pl3 = _world.GetPool<Component362>();
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
