using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System386 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component12> _p1;
EcsPool<Component254> _p2;
EcsPool<Component481> _p3;
EcsPool<Component275> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component12>().Inc<Component254>().Inc<Component481>().End();
   _p1 = _world.GetPool<Component12>();
   _p2 = _world.GetPool<Component254>();
   _p3 = _world.GetPool<Component481>();
   _pl0 = _world.GetPool<Component275>();
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
