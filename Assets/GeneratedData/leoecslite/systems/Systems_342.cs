using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System342 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component348> _p1;
EcsPool<Component307> _p2;
EcsPool<Component120> _p3;
EcsPool<Component266> _p4;
EcsPool<Component60> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component348>().Inc<Component307>().Inc<Component120>().Inc<Component266>().End();
   _p1 = _world.GetPool<Component348>();
   _p2 = _world.GetPool<Component307>();
   _p3 = _world.GetPool<Component120>();
   _p4 = _world.GetPool<Component266>();
   _pl0 = _world.GetPool<Component60>();
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
