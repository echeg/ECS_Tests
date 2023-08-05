using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System285 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component245> _p1;
EcsPool<Component392> _p2;
EcsPool<Component447> _p3;
EcsPool<Component204> _p4;
EcsPool<Component393> _pl0;
EcsPool<Component271> _pl1;
EcsPool<Component264> _pl2;
EcsPool<Component133> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component245>().Inc<Component392>().Inc<Component447>().Inc<Component204>().End();
   _p1 = _world.GetPool<Component245>();
   _p2 = _world.GetPool<Component392>();
   _p3 = _world.GetPool<Component447>();
   _p4 = _world.GetPool<Component204>();
   _pl0 = _world.GetPool<Component393>();
   _pl1 = _world.GetPool<Component271>();
   _pl2 = _world.GetPool<Component264>();
   _pl3 = _world.GetPool<Component133>();
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
