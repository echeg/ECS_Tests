using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System35 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component296> _p1;
EcsPool<Component271> _p2;
EcsPool<Component276> _p3;
EcsPool<Component446> _pl0;
EcsPool<Component460> _pl1;
EcsPool<Component116> _pl2;
EcsPool<Component146> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component296>().Inc<Component271>().Inc<Component276>().End();
   _p1 = _world.GetPool<Component296>();
   _p2 = _world.GetPool<Component271>();
   _p3 = _world.GetPool<Component276>();
   _pl0 = _world.GetPool<Component446>();
   _pl1 = _world.GetPool<Component460>();
   _pl2 = _world.GetPool<Component116>();
   _pl3 = _world.GetPool<Component146>();
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