using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System197 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component298> _p1;
EcsPool<Component33> _p2;
EcsPool<Component471> _p3;
EcsPool<Component1> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component298>().Inc<Component33>().Inc<Component471>().End();
   _p1 = _world.GetPool<Component298>();
   _p2 = _world.GetPool<Component33>();
   _p3 = _world.GetPool<Component471>();
   _pl0 = _world.GetPool<Component1>();
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
