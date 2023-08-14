using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System391 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component188> _p1;
EcsPool<Component172> _p2;
EcsPool<Component128> _p3;
EcsPool<Component45> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component188>().Inc<Component172>().Inc<Component128>().End();
   _p1 = _world.GetPool<Component188>();
   _p2 = _world.GetPool<Component172>();
   _p3 = _world.GetPool<Component128>();
   _pl0 = _world.GetPool<Component45>();
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
