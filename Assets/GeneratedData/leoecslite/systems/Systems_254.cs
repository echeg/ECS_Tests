using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System254 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component251> _p1;
EcsPool<Component142> _p2;
EcsPool<Component198> _p3;
EcsPool<Component214> _p4;
EcsPool<Component283> _pl0;
EcsPool<Component184> _pl1;
EcsPool<Component270> _pl2;
EcsPool<Component102> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component251>().Inc<Component142>().Inc<Component198>().Inc<Component214>().End();
   _p1 = _world.GetPool<Component251>();
   _p2 = _world.GetPool<Component142>();
   _p3 = _world.GetPool<Component198>();
   _p4 = _world.GetPool<Component214>();
   _pl0 = _world.GetPool<Component283>();
   _pl1 = _world.GetPool<Component184>();
   _pl2 = _world.GetPool<Component270>();
   _pl3 = _world.GetPool<Component102>();
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
