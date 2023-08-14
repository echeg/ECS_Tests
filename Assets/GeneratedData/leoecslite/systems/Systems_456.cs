using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System456 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component266> _p1;
EcsPool<Component405> _p2;
EcsPool<Component337> _p3;
EcsPool<Component27> _p4;
EcsPool<Component115> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component266>().Inc<Component405>().Inc<Component337>().Inc<Component27>().End();
   _p1 = _world.GetPool<Component266>();
   _p2 = _world.GetPool<Component405>();
   _p3 = _world.GetPool<Component337>();
   _p4 = _world.GetPool<Component27>();
   _pl0 = _world.GetPool<Component115>();
 }
 public void Run (IEcsSystems systems) {
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
  }
 }
}

}
