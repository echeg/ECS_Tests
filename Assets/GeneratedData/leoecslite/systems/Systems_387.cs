using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System387 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component68> _p1;
EcsPool<Component368> _p2;
EcsPool<Component50> _p3;
EcsPool<Component204> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component68>().Inc<Component368>().Inc<Component50>().End();
   _p1 = _world.GetPool<Component68>();
   _p2 = _world.GetPool<Component368>();
   _p3 = _world.GetPool<Component50>();
   _pl0 = _world.GetPool<Component204>();
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
