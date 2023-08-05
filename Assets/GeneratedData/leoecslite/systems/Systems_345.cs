using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System345 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component28> _p1;
EcsPool<Component290> _p2;
EcsPool<Component223> _p3;
EcsPool<Component35> _p4;
EcsPool<Component2> _pl0;
EcsPool<Component92> _pl1;
EcsPool<Component30> _pl2;
EcsPool<Component371> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component28>().Inc<Component290>().Inc<Component223>().Inc<Component35>().End();
   _p1 = _world.GetPool<Component28>();
   _p2 = _world.GetPool<Component290>();
   _p3 = _world.GetPool<Component223>();
   _p4 = _world.GetPool<Component35>();
   _pl0 = _world.GetPool<Component2>();
   _pl1 = _world.GetPool<Component92>();
   _pl2 = _world.GetPool<Component30>();
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
