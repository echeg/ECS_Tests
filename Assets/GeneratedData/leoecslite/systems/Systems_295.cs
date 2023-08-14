using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System295 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component3> _p1;
EcsPool<Component457> _p2;
EcsPool<Component58> _p3;
EcsPool<Component259> _p4;
EcsPool<Component213> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component3>().Inc<Component457>().Inc<Component58>().Inc<Component259>().End();
   _p1 = _world.GetPool<Component3>();
   _p2 = _world.GetPool<Component457>();
   _p3 = _world.GetPool<Component58>();
   _p4 = _world.GetPool<Component259>();
   _pl0 = _world.GetPool<Component213>();
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
