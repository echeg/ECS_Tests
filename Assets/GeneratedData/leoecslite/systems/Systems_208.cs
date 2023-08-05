using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System208 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component160> _p1;
EcsPool<Component344> _p2;
EcsPool<Component178> _p3;
EcsPool<Component275> _p4;
EcsPool<Component282> _pl0;
EcsPool<Component152> _pl1;
EcsPool<Component26> _pl2;
EcsPool<Component324> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component160>().Inc<Component344>().Inc<Component178>().Inc<Component275>().End();
   _p1 = _world.GetPool<Component160>();
   _p2 = _world.GetPool<Component344>();
   _p3 = _world.GetPool<Component178>();
   _p4 = _world.GetPool<Component275>();
   _pl0 = _world.GetPool<Component282>();
   _pl1 = _world.GetPool<Component152>();
   _pl2 = _world.GetPool<Component26>();
   _pl3 = _world.GetPool<Component324>();
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
