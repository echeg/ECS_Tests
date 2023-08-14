using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System421 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component495> _p1;
EcsPool<Component349> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component495>().End();
   _p1 = _world.GetPool<Component495>();
   _pl0 = _world.GetPool<Component349>();
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
