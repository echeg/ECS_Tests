using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System335 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component417> _p1;
EcsPool<Component379> _p2;
EcsPool<Component29> _p3;
EcsPool<Component135> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component417>().Inc<Component379>().Inc<Component29>().End();
   _p1 = _world.GetPool<Component417>();
   _p2 = _world.GetPool<Component379>();
   _p3 = _world.GetPool<Component29>();
   _pl0 = _world.GetPool<Component135>();
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
