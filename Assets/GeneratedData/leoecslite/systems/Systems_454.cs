using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System454 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component348> _p1;
EcsPool<Component403> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component348>().End();
   _p1 = _world.GetPool<Component348>();
   _pl0 = _world.GetPool<Component403>();
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
