using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System447 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component430> _p1;
EcsPool<Component157> _p2;
EcsPool<Component256> _p3;
EcsPool<Component222> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component430>().Inc<Component157>().Inc<Component256>().End();
   _p1 = _world.GetPool<Component430>();
   _p2 = _world.GetPool<Component157>();
   _p3 = _world.GetPool<Component256>();
   _pl0 = _world.GetPool<Component222>();
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
