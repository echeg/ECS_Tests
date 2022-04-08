using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System28 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component499> _p1;
EcsPool<Component99> _p2;
EcsPool<Component385> _p3;
EcsPool<Component110> _p4;
EcsPool<Component65> _pl0;
EcsPool<Component305> _pl1;
EcsPool<Component463> _pl2;
EcsPool<Component406> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component499>().Inc<Component99>().Inc<Component385>().Inc<Component110>().End();
   _p1 = _world.GetPool<Component499>();
   _p2 = _world.GetPool<Component99>();
   _p3 = _world.GetPool<Component385>();
   _p4 = _world.GetPool<Component110>();
   _pl0 = _world.GetPool<Component65>();
   _pl1 = _world.GetPool<Component305>();
   _pl2 = _world.GetPool<Component463>();
   _pl3 = _world.GetPool<Component406>();
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
