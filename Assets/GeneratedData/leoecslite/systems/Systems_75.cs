using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System75 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component81> _p1;
EcsPool<Component440> _p2;
EcsPool<Component444> _p3;
EcsPool<Component326> _pl0;
EcsPool<Component443> _pl1;
EcsPool<Component406> _pl2;
EcsPool<Component15> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component81>().Inc<Component440>().Inc<Component444>().End();
   _p1 = _world.GetPool<Component81>();
   _p2 = _world.GetPool<Component440>();
   _p3 = _world.GetPool<Component444>();
   _pl0 = _world.GetPool<Component326>();
   _pl1 = _world.GetPool<Component443>();
   _pl2 = _world.GetPool<Component406>();
   _pl3 = _world.GetPool<Component15>();
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