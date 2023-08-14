using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System318 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component461> _p1;
EcsPool<Component487> _p2;
EcsPool<Component425> _p3;
EcsPool<Component137> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component461>().Inc<Component487>().Inc<Component425>().End();
   _p1 = _world.GetPool<Component461>();
   _p2 = _world.GetPool<Component487>();
   _p3 = _world.GetPool<Component425>();
   _pl0 = _world.GetPool<Component137>();
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
