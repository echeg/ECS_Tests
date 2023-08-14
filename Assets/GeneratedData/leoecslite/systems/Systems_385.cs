using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System385 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component201> _p1;
EcsPool<Component279> _p2;
EcsPool<Component400> _p3;
EcsPool<Component459> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component201>().Inc<Component279>().Inc<Component400>().End();
   _p1 = _world.GetPool<Component201>();
   _p2 = _world.GetPool<Component279>();
   _p3 = _world.GetPool<Component400>();
   _pl0 = _world.GetPool<Component459>();
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
