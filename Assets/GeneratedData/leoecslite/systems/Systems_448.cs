using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System448 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component40> _p1;
EcsPool<Component377> _p2;
EcsPool<Component225> _p3;
EcsPool<Component91> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component40>().Inc<Component377>().Inc<Component225>().End();
   _p1 = _world.GetPool<Component40>();
   _p2 = _world.GetPool<Component377>();
   _p3 = _world.GetPool<Component225>();
   _pl0 = _world.GetPool<Component91>();
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
