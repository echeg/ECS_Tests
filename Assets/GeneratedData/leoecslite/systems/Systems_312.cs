using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System312 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component318> _p1;
EcsPool<Component296> _p2;
EcsPool<Component165> _p3;
EcsPool<Component342> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component318>().Inc<Component296>().Inc<Component165>().End();
   _p1 = _world.GetPool<Component318>();
   _p2 = _world.GetPool<Component296>();
   _p3 = _world.GetPool<Component165>();
   _pl0 = _world.GetPool<Component342>();
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
