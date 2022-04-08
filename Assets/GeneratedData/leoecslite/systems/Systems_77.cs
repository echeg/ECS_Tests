using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System77 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component357> _p1;
EcsPool<Component109> _p2;
EcsPool<Component346> _p3;
EcsPool<Component384> _pl0;
EcsPool<Component343> _pl1;
EcsPool<Component90> _pl2;
EcsPool<Component298> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component357>().Inc<Component109>().Inc<Component346>().End();
   _p1 = _world.GetPool<Component357>();
   _p2 = _world.GetPool<Component109>();
   _p3 = _world.GetPool<Component346>();
   _pl0 = _world.GetPool<Component384>();
   _pl1 = _world.GetPool<Component343>();
   _pl2 = _world.GetPool<Component90>();
   _pl3 = _world.GetPool<Component298>();
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
