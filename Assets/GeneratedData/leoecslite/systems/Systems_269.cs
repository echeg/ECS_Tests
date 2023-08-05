using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System269 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component459> _p1;
EcsPool<Component343> _p2;
EcsPool<Component364> _p3;
EcsPool<Component136> _pl0;
EcsPool<Component392> _pl1;
EcsPool<Component381> _pl2;
EcsPool<Component349> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component459>().Inc<Component343>().Inc<Component364>().End();
   _p1 = _world.GetPool<Component459>();
   _p2 = _world.GetPool<Component343>();
   _p3 = _world.GetPool<Component364>();
   _pl0 = _world.GetPool<Component136>();
   _pl1 = _world.GetPool<Component392>();
   _pl2 = _world.GetPool<Component381>();
   _pl3 = _world.GetPool<Component349>();
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
