using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System155 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component139> _p1;
EcsPool<Component396> _p2;
EcsPool<Component379> _p3;
EcsPool<Component426> _p4;
EcsPool<Component261> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component139>().Inc<Component396>().Inc<Component379>().Inc<Component426>().End();
   _p1 = _world.GetPool<Component139>();
   _p2 = _world.GetPool<Component396>();
   _p3 = _world.GetPool<Component379>();
   _p4 = _world.GetPool<Component426>();
   _pl0 = _world.GetPool<Component261>();
 }
 public void Run (EcsSystems systems) {
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
