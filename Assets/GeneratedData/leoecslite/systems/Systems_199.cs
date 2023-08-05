using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System199 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component86> _p1;
EcsPool<Component474> _p2;
EcsPool<Component255> _p3;
EcsPool<Component37> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component86>().Inc<Component474>().Inc<Component255>().End();
   _p1 = _world.GetPool<Component86>();
   _p2 = _world.GetPool<Component474>();
   _p3 = _world.GetPool<Component255>();
   _pl0 = _world.GetPool<Component37>();
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
