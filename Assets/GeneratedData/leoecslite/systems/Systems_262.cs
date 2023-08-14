using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System262 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component214> _p1;
EcsPool<Component270> _p2;
EcsPool<Component269> _p3;
EcsPool<Component109> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component214>().Inc<Component270>().Inc<Component269>().End();
   _p1 = _world.GetPool<Component214>();
   _p2 = _world.GetPool<Component270>();
   _p3 = _world.GetPool<Component269>();
   _pl0 = _world.GetPool<Component109>();
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
