using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System161 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component498> _p1;
EcsPool<Component353> _p2;
EcsPool<Component195> _p3;
EcsPool<Component372> _p4;
EcsPool<Component307> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component498>().Inc<Component353>().Inc<Component195>().Inc<Component372>().End();
   _p1 = _world.GetPool<Component498>();
   _p2 = _world.GetPool<Component353>();
   _p3 = _world.GetPool<Component195>();
   _p4 = _world.GetPool<Component372>();
   _pl0 = _world.GetPool<Component307>();
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
