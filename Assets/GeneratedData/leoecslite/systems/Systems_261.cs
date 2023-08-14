using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System261 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component22> _p1;
EcsPool<Component344> _p2;
EcsPool<Component77> _p3;
EcsPool<Component375> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component22>().Inc<Component344>().Inc<Component77>().End();
   _p1 = _world.GetPool<Component22>();
   _p2 = _world.GetPool<Component344>();
   _p3 = _world.GetPool<Component77>();
   _pl0 = _world.GetPool<Component375>();
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
