using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System235 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component247> _p1;
EcsPool<Component167> _p2;
EcsPool<Component420> _p3;
EcsPool<Component278> _pl0;
EcsPool<Component174> _pl1;
EcsPool<Component423> _pl2;
EcsPool<Component427> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component247>().Inc<Component167>().Inc<Component420>().End();
   _p1 = _world.GetPool<Component247>();
   _p2 = _world.GetPool<Component167>();
   _p3 = _world.GetPool<Component420>();
   _pl0 = _world.GetPool<Component278>();
   _pl1 = _world.GetPool<Component174>();
   _pl2 = _world.GetPool<Component423>();
   _pl3 = _world.GetPool<Component427>();
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
