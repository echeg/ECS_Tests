using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System267 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component24> _p1;
EcsPool<Component276> _p2;
EcsPool<Component224> _p3;
EcsPool<Component223> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component24>().Inc<Component276>().Inc<Component224>().End();
   _p1 = _world.GetPool<Component24>();
   _p2 = _world.GetPool<Component276>();
   _p3 = _world.GetPool<Component224>();
   _pl0 = _world.GetPool<Component223>();
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
