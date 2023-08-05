using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System177 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component266> _p1;
EcsPool<Component355> _p2;
EcsPool<Component455> _p3;
EcsPool<Component269> _p4;
EcsPool<Component194> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component266>().Inc<Component355>().Inc<Component455>().Inc<Component269>().End();
   _p1 = _world.GetPool<Component266>();
   _p2 = _world.GetPool<Component355>();
   _p3 = _world.GetPool<Component455>();
   _p4 = _world.GetPool<Component269>();
   _pl0 = _world.GetPool<Component194>();
 }
 public void Run (EcsSystems systems) {
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
