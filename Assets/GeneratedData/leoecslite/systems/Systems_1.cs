using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System1 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component362> _p1;
EcsPool<Component466> _p2;
EcsPool<Component190> _p3;
EcsPool<Component254> _p4;
EcsPool<Component366> _pl0;
EcsPool<Component115> _pl1;
EcsPool<Component225> _pl2;
EcsPool<Component192> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component362>().Inc<Component466>().Inc<Component190>().Inc<Component254>().End();
   _p1 = _world.GetPool<Component362>();
   _p2 = _world.GetPool<Component466>();
   _p3 = _world.GetPool<Component190>();
   _p4 = _world.GetPool<Component254>();
   _pl0 = _world.GetPool<Component366>();
   _pl1 = _world.GetPool<Component115>();
   _pl2 = _world.GetPool<Component225>();
   _pl3 = _world.GetPool<Component192>();
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
