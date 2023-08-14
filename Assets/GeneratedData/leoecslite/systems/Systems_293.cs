using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System293 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component33> _p1;
EcsPool<Component210> _p2;
EcsPool<Component276> _p3;
EcsPool<Component158> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component33>().Inc<Component210>().Inc<Component276>().End();
   _p1 = _world.GetPool<Component33>();
   _p2 = _world.GetPool<Component210>();
   _p3 = _world.GetPool<Component276>();
   _pl0 = _world.GetPool<Component158>();
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
