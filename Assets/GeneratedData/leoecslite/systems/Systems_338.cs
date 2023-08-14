using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System338 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component468> _p1;
EcsPool<Component358> _p2;
EcsPool<Component379> _p3;
EcsPool<Component227> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component468>().Inc<Component358>().Inc<Component379>().End();
   _p1 = _world.GetPool<Component468>();
   _p2 = _world.GetPool<Component358>();
   _p3 = _world.GetPool<Component379>();
   _pl0 = _world.GetPool<Component227>();
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
