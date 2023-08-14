using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System382 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component262> _p1;
EcsPool<Component280> _p2;
EcsPool<Component208> _p3;
EcsPool<Component6> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component262>().Inc<Component280>().Inc<Component208>().End();
   _p1 = _world.GetPool<Component262>();
   _p2 = _world.GetPool<Component280>();
   _p3 = _world.GetPool<Component208>();
   _pl0 = _world.GetPool<Component6>();
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
