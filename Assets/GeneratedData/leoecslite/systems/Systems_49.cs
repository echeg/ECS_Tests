using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System49 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component168> _p1;
EcsPool<Component251> _p2;
EcsPool<Component405> _p3;
EcsPool<Component433> _p4;
EcsPool<Component111> _pl0;
EcsPool<Component50> _pl1;
EcsPool<Component343> _pl2;
EcsPool<Component153> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component168>().Inc<Component251>().Inc<Component405>().Inc<Component433>().End();
   _p1 = _world.GetPool<Component168>();
   _p2 = _world.GetPool<Component251>();
   _p3 = _world.GetPool<Component405>();
   _p4 = _world.GetPool<Component433>();
   _pl0 = _world.GetPool<Component111>();
   _pl1 = _world.GetPool<Component50>();
   _pl2 = _world.GetPool<Component343>();
   _pl3 = _world.GetPool<Component153>();
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
