using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System270 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component105> _p1;
EcsPool<Component47> _p2;
EcsPool<Component357> _p3;
EcsPool<Component21> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component105>().Inc<Component47>().Inc<Component357>().End();
   _p1 = _world.GetPool<Component105>();
   _p2 = _world.GetPool<Component47>();
   _p3 = _world.GetPool<Component357>();
   _pl0 = _world.GetPool<Component21>();
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
