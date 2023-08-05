using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System249 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
EcsPool<Component170> _p2;
EcsPool<Component485> _p3;
EcsPool<Component40> _p4;
EcsPool<Component94> _pl0;
EcsPool<Component314> _pl1;
EcsPool<Component283> _pl2;
EcsPool<Component333> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().Inc<Component170>().Inc<Component485>().Inc<Component40>().End();
   _p1 = _world.GetPool<Component13>();
   _p2 = _world.GetPool<Component170>();
   _p3 = _world.GetPool<Component485>();
   _p4 = _world.GetPool<Component40>();
   _pl0 = _world.GetPool<Component94>();
   _pl1 = _world.GetPool<Component314>();
   _pl2 = _world.GetPool<Component283>();
   _pl3 = _world.GetPool<Component333>();
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
