using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System380 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component490> _p1;
EcsPool<Component229> _p2;
EcsPool<Component307> _p3;
EcsPool<Component64> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component490>().Inc<Component229>().Inc<Component307>().End();
   _p1 = _world.GetPool<Component490>();
   _p2 = _world.GetPool<Component229>();
   _p3 = _world.GetPool<Component307>();
   _pl0 = _world.GetPool<Component64>();
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
