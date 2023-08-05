using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System335 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component143> _p1;
EcsPool<Component185> _p2;
EcsPool<Component386> _p3;
EcsPool<Component204> _pl0;
EcsPool<Component435> _pl1;
EcsPool<Component389> _pl2;
EcsPool<Component488> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component143>().Inc<Component185>().Inc<Component386>().End();
   _p1 = _world.GetPool<Component143>();
   _p2 = _world.GetPool<Component185>();
   _p3 = _world.GetPool<Component386>();
   _pl0 = _world.GetPool<Component204>();
   _pl1 = _world.GetPool<Component435>();
   _pl2 = _world.GetPool<Component389>();
   _pl3 = _world.GetPool<Component488>();
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
