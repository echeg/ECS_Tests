using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System13 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component176> _p1;
EcsPool<Component131> _p2;
EcsPool<Component338> _p3;
EcsPool<Component213> _p4;
EcsPool<Component114> _pl0;
EcsPool<Component193> _pl1;
EcsPool<Component127> _pl2;
EcsPool<Component269> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component176>().Inc<Component131>().Inc<Component338>().Inc<Component213>().End();
   _p1 = _world.GetPool<Component176>();
   _p2 = _world.GetPool<Component131>();
   _p3 = _world.GetPool<Component338>();
   _p4 = _world.GetPool<Component213>();
   _pl0 = _world.GetPool<Component114>();
   _pl1 = _world.GetPool<Component193>();
   _pl2 = _world.GetPool<Component127>();
   _pl3 = _world.GetPool<Component269>();
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
