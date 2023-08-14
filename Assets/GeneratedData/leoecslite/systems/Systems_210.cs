using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System210 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component105> _p1;
EcsPool<Component384> _p2;
EcsPool<Component323> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component105>().Inc<Component384>().End();
   _p1 = _world.GetPool<Component105>();
   _p2 = _world.GetPool<Component384>();
   _pl0 = _world.GetPool<Component323>();
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