using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System341 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component170> _p1;
EcsPool<Component342> _p2;
EcsPool<Component469> _p3;
EcsPool<Component361> _p4;
EcsPool<Component364> _pl0;
EcsPool<Component183> _pl1;
EcsPool<Component290> _pl2;
EcsPool<Component99> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component170>().Inc<Component342>().Inc<Component469>().Inc<Component361>().End();
   _p1 = _world.GetPool<Component170>();
   _p2 = _world.GetPool<Component342>();
   _p3 = _world.GetPool<Component469>();
   _p4 = _world.GetPool<Component361>();
   _pl0 = _world.GetPool<Component364>();
   _pl1 = _world.GetPool<Component183>();
   _pl2 = _world.GetPool<Component290>();
   _pl3 = _world.GetPool<Component99>();
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
