using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System183 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component347> _p1;
EcsPool<Component494> _p2;
EcsPool<Component129> _p3;
EcsPool<Component117> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component347>().Inc<Component494>().Inc<Component129>().End();
   _p1 = _world.GetPool<Component347>();
   _p2 = _world.GetPool<Component494>();
   _p3 = _world.GetPool<Component129>();
   _pl0 = _world.GetPool<Component117>();
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
