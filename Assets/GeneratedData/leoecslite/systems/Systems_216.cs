using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System216 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component189> _p1;
EcsPool<Component195> _p2;
EcsPool<Component495> _p3;
EcsPool<Component389> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component189>().Inc<Component195>().Inc<Component495>().End();
   _p1 = _world.GetPool<Component189>();
   _p2 = _world.GetPool<Component195>();
   _p3 = _world.GetPool<Component495>();
   _pl0 = _world.GetPool<Component389>();
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
