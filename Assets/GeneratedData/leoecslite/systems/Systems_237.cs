using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System237 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component384> _p1;
EcsPool<Component38> _p2;
EcsPool<Component255> _p3;
EcsPool<Component335> _p4;
EcsPool<Component146> _pl0;
EcsPool<Component473> _pl1;
EcsPool<Component180> _pl2;
EcsPool<Component7> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component384>().Inc<Component38>().Inc<Component255>().Inc<Component335>().End();
   _p1 = _world.GetPool<Component384>();
   _p2 = _world.GetPool<Component38>();
   _p3 = _world.GetPool<Component255>();
   _p4 = _world.GetPool<Component335>();
   _pl0 = _world.GetPool<Component146>();
   _pl1 = _world.GetPool<Component473>();
   _pl2 = _world.GetPool<Component180>();
   _pl3 = _world.GetPool<Component7>();
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
