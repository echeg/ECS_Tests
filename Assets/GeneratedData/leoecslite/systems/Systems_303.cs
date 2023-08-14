using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System303 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component326> _p1;
EcsPool<Component495> _p2;
EcsPool<Component36> _p3;
EcsPool<Component117> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component326>().Inc<Component495>().Inc<Component36>().End();
   _p1 = _world.GetPool<Component326>();
   _p2 = _world.GetPool<Component495>();
   _p3 = _world.GetPool<Component36>();
   _pl0 = _world.GetPool<Component117>();
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
