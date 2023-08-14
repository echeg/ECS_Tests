using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System229 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component70> _p1;
EcsPool<Component216> _p2;
EcsPool<Component91> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component70>().Inc<Component216>().End();
   _p1 = _world.GetPool<Component70>();
   _p2 = _world.GetPool<Component216>();
   _pl0 = _world.GetPool<Component91>();
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