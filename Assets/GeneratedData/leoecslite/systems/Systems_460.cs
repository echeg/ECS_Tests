using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System460 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component36> _p1;
EcsPool<Component16> _p2;
EcsPool<Component171> _p3;
EcsPool<Component330> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component36>().Inc<Component16>().Inc<Component171>().End();
   _p1 = _world.GetPool<Component36>();
   _p2 = _world.GetPool<Component16>();
   _p3 = _world.GetPool<Component171>();
   _pl0 = _world.GetPool<Component330>();
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
