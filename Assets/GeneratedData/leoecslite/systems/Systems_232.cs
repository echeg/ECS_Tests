using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System232 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component323> _p1;
EcsPool<Component263> _p2;
EcsPool<Component240> _p3;
EcsPool<Component336> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component323>().Inc<Component263>().Inc<Component240>().End();
   _p1 = _world.GetPool<Component323>();
   _p2 = _world.GetPool<Component263>();
   _p3 = _world.GetPool<Component240>();
   _pl0 = _world.GetPool<Component336>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}