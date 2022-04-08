using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System37 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component248> _p1;
EcsPool<Component429> _p2;
EcsPool<Component97> _p3;
EcsPool<Component128> _p4;
EcsPool<Component100> _pl0;
EcsPool<Component320> _pl1;
EcsPool<Component409> _pl2;
EcsPool<Component237> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component248>().Inc<Component429>().Inc<Component97>().Inc<Component128>().End();
   _p1 = _world.GetPool<Component248>();
   _p2 = _world.GetPool<Component429>();
   _p3 = _world.GetPool<Component97>();
   _p4 = _world.GetPool<Component128>();
   _pl0 = _world.GetPool<Component100>();
   _pl1 = _world.GetPool<Component320>();
   _pl2 = _world.GetPool<Component409>();
   _pl3 = _world.GetPool<Component237>();
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
