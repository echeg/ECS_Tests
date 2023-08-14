using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System388 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component110> _p1;
EcsPool<Component270> _p2;
EcsPool<Component204> _p3;
EcsPool<Component141> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component110>().Inc<Component270>().Inc<Component204>().End();
   _p1 = _world.GetPool<Component110>();
   _p2 = _world.GetPool<Component270>();
   _p3 = _world.GetPool<Component204>();
   _pl0 = _world.GetPool<Component141>();
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
