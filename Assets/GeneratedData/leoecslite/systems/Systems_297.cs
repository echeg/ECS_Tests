using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System297 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component381> _p1;
EcsPool<Component456> _p2;
EcsPool<Component309> _p3;
EcsPool<Component218> _pl0;
EcsPool<Component95> _pl1;
EcsPool<Component203> _pl2;
EcsPool<Component72> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component381>().Inc<Component456>().Inc<Component309>().End();
   _p1 = _world.GetPool<Component381>();
   _p2 = _world.GetPool<Component456>();
   _p3 = _world.GetPool<Component309>();
   _pl0 = _world.GetPool<Component218>();
   _pl1 = _world.GetPool<Component95>();
   _pl2 = _world.GetPool<Component203>();
   _pl3 = _world.GetPool<Component72>();
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
