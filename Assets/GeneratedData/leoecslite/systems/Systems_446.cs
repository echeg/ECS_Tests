using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System446 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component416> _p1;
EcsPool<Component194> _p2;
EcsPool<Component392> _p3;
EcsPool<Component317> _p4;
EcsPool<Component224> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component416>().Inc<Component194>().Inc<Component392>().Inc<Component317>().End();
   _p1 = _world.GetPool<Component416>();
   _p2 = _world.GetPool<Component194>();
   _p3 = _world.GetPool<Component392>();
   _p4 = _world.GetPool<Component317>();
   _pl0 = _world.GetPool<Component224>();
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
