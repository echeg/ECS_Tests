using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System36 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component448> _p1;
EcsPool<Component231> _p2;
EcsPool<Component224> _p3;
EcsPool<Component288> _p4;
EcsPool<Component53> _pl0;
EcsPool<Component296> _pl1;
EcsPool<Component326> _pl2;
EcsPool<Component345> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component448>().Inc<Component231>().Inc<Component224>().Inc<Component288>().End();
   _p1 = _world.GetPool<Component448>();
   _p2 = _world.GetPool<Component231>();
   _p3 = _world.GetPool<Component224>();
   _p4 = _world.GetPool<Component288>();
   _pl0 = _world.GetPool<Component53>();
   _pl1 = _world.GetPool<Component296>();
   _pl2 = _world.GetPool<Component326>();
   _pl3 = _world.GetPool<Component345>();
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
