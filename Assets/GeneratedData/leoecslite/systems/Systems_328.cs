using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System328 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component328> _p1;
EcsPool<Component158> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component328>().End();
   _p1 = _world.GetPool<Component328>();
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
