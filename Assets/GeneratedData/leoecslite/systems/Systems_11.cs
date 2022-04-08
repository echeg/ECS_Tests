using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System11 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component203> _p1;
EcsPool<Component180> _p2;
EcsPool<Component320> _p3;
EcsPool<Component113> _p4;
EcsPool<Component359> _pl0;
EcsPool<Component120> _pl1;
EcsPool<Component277> _pl2;
EcsPool<Component183> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component203>().Inc<Component180>().Inc<Component320>().Inc<Component113>().End();
   _p1 = _world.GetPool<Component203>();
   _p2 = _world.GetPool<Component180>();
   _p3 = _world.GetPool<Component320>();
   _p4 = _world.GetPool<Component113>();
   _pl0 = _world.GetPool<Component359>();
   _pl1 = _world.GetPool<Component120>();
   _pl2 = _world.GetPool<Component277>();
   _pl3 = _world.GetPool<Component183>();
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
