using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System248 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component10> _p1;
EcsPool<Component128> _p2;
EcsPool<Component340> _p3;
EcsPool<Component418> _p4;
EcsPool<Component247> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component10>().Inc<Component128>().Inc<Component340>().Inc<Component418>().End();
   _p1 = _world.GetPool<Component10>();
   _p2 = _world.GetPool<Component128>();
   _p3 = _world.GetPool<Component340>();
   _p4 = _world.GetPool<Component418>();
   _pl0 = _world.GetPool<Component247>();
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
