using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System202 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component103> _p1;
EcsPool<Component42> _p2;
EcsPool<Component110> _p3;
EcsPool<Component494> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component103>().Inc<Component42>().Inc<Component110>().End();
   _p1 = _world.GetPool<Component103>();
   _p2 = _world.GetPool<Component42>();
   _p3 = _world.GetPool<Component110>();
   _pl0 = _world.GetPool<Component494>();
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
