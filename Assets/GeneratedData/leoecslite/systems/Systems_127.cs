using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System127 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component218> _p1;
EcsPool<Component90> _p2;
EcsPool<Component397> _p3;
EcsPool<Component227> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component218>().Inc<Component90>().Inc<Component397>().End();
   _p1 = _world.GetPool<Component218>();
   _p2 = _world.GetPool<Component90>();
   _p3 = _world.GetPool<Component397>();
   _pl0 = _world.GetPool<Component227>();
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
