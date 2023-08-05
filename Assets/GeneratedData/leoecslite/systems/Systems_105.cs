using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System105 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component11> _p1;
EcsPool<Component46> _p2;
EcsPool<Component340> _p3;
EcsPool<Component398> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component11>().Inc<Component46>().Inc<Component340>().End();
   _p1 = _world.GetPool<Component11>();
   _p2 = _world.GetPool<Component46>();
   _p3 = _world.GetPool<Component340>();
   _pl0 = _world.GetPool<Component398>();
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
