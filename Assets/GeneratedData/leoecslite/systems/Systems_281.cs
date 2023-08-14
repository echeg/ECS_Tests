using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System281 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component271> _p1;
EcsPool<Component410> _p2;
EcsPool<Component489> _p3;
EcsPool<Component231> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component271>().Inc<Component410>().Inc<Component489>().End();
   _p1 = _world.GetPool<Component271>();
   _p2 = _world.GetPool<Component410>();
   _p3 = _world.GetPool<Component489>();
   _pl0 = _world.GetPool<Component231>();
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
