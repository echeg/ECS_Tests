using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System265 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component22> _p1;
EcsPool<Component282> _p2;
EcsPool<Component139> _p3;
EcsPool<Component443> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component22>().Inc<Component282>().Inc<Component139>().End();
   _p1 = _world.GetPool<Component22>();
   _p2 = _world.GetPool<Component282>();
   _p3 = _world.GetPool<Component139>();
   _pl0 = _world.GetPool<Component443>();
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
