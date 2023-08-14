using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System283 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component136> _p1;
EcsPool<Component460> _p2;
EcsPool<Component422> _p3;
EcsPool<Component202> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component136>().Inc<Component460>().Inc<Component422>().End();
   _p1 = _world.GetPool<Component136>();
   _p2 = _world.GetPool<Component460>();
   _p3 = _world.GetPool<Component422>();
   _pl0 = _world.GetPool<Component202>();
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
