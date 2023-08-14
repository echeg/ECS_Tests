using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System209 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component1> _p1;
EcsPool<Component338> _p2;
EcsPool<Component449> _p3;
EcsPool<Component172> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component1>().Inc<Component338>().Inc<Component449>().End();
   _p1 = _world.GetPool<Component1>();
   _p2 = _world.GetPool<Component338>();
   _p3 = _world.GetPool<Component449>();
   _pl0 = _world.GetPool<Component172>();
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
