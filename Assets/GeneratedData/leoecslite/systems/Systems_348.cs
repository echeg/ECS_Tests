using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System348 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component206> _p1;
EcsPool<Component128> _p2;
EcsPool<Component109> _p3;
EcsPool<Component406> _p4;
EcsPool<Component53> _pl0;
EcsPool<Component396> _pl1;
EcsPool<Component173> _pl2;
EcsPool<Component179> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component206>().Inc<Component128>().Inc<Component109>().Inc<Component406>().End();
   _p1 = _world.GetPool<Component206>();
   _p2 = _world.GetPool<Component128>();
   _p3 = _world.GetPool<Component109>();
   _p4 = _world.GetPool<Component406>();
   _pl0 = _world.GetPool<Component53>();
   _pl1 = _world.GetPool<Component396>();
   _pl2 = _world.GetPool<Component173>();
   _pl3 = _world.GetPool<Component179>();
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
