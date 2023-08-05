using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System263 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component46> _p1;
EcsPool<Component440> _p2;
EcsPool<Component55> _pl0;
EcsPool<Component434> _pl1;
EcsPool<Component397> _pl2;
EcsPool<Component248> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component46>().Inc<Component440>().End();
   _p1 = _world.GetPool<Component46>();
   _p2 = _world.GetPool<Component440>();
   _pl0 = _world.GetPool<Component55>();
   _pl1 = _world.GetPool<Component434>();
   _pl2 = _world.GetPool<Component397>();
   _pl3 = _world.GetPool<Component248>();
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
