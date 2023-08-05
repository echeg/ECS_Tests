using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System147 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component102> _p1;
EcsPool<Component231> _p2;
EcsPool<Component490> _p3;
EcsPool<Component337> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component102>().Inc<Component231>().Inc<Component490>().End();
   _p1 = _world.GetPool<Component102>();
   _p2 = _world.GetPool<Component231>();
   _p3 = _world.GetPool<Component490>();
   _pl0 = _world.GetPool<Component337>();
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
