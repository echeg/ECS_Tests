using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System146 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component487> _p1;
EcsPool<Component370> _p2;
EcsPool<Component65> _p3;
EcsPool<Component394> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component487>().Inc<Component370>().Inc<Component65>().End();
   _p1 = _world.GetPool<Component487>();
   _p2 = _world.GetPool<Component370>();
   _p3 = _world.GetPool<Component65>();
   _pl0 = _world.GetPool<Component394>();
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
