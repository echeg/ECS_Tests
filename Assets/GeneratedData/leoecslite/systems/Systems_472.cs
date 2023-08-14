using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System472 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component476> _p1;
EcsPool<Component225> _p2;
EcsPool<Component407> _p3;
EcsPool<Component498> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component476>().Inc<Component225>().Inc<Component407>().End();
   _p1 = _world.GetPool<Component476>();
   _p2 = _world.GetPool<Component225>();
   _p3 = _world.GetPool<Component407>();
   _pl0 = _world.GetPool<Component498>();
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
