using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System461 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component318> _p1;
EcsPool<Component83> _p2;
EcsPool<Component224> _p3;
EcsPool<Component101> _p4;
EcsPool<Component376> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component318>().Inc<Component83>().Inc<Component224>().Inc<Component101>().End();
   _p1 = _world.GetPool<Component318>();
   _p2 = _world.GetPool<Component83>();
   _p3 = _world.GetPool<Component224>();
   _p4 = _world.GetPool<Component101>();
   _pl0 = _world.GetPool<Component376>();
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
