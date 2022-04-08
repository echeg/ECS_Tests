using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System9 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component198> _p1;
EcsPool<Component34> _p2;
EcsPool<Component424> _p3;
EcsPool<Component151> _p4;
EcsPool<Component178> _pl0;
EcsPool<Component2> _pl1;
EcsPool<Component299> _pl2;
EcsPool<Component443> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component198>().Inc<Component34>().Inc<Component424>().Inc<Component151>().End();
   _p1 = _world.GetPool<Component198>();
   _p2 = _world.GetPool<Component34>();
   _p3 = _world.GetPool<Component424>();
   _p4 = _world.GetPool<Component151>();
   _pl0 = _world.GetPool<Component178>();
   _pl1 = _world.GetPool<Component2>();
   _pl2 = _world.GetPool<Component299>();
   _pl3 = _world.GetPool<Component443>();
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
