using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System215 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component334> _p1;
EcsPool<Component324> _p2;
EcsPool<Component344> _p3;
EcsPool<Component428> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component334>().Inc<Component324>().Inc<Component344>().End();
   _p1 = _world.GetPool<Component334>();
   _p2 = _world.GetPool<Component324>();
   _p3 = _world.GetPool<Component344>();
   _pl0 = _world.GetPool<Component428>();
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
