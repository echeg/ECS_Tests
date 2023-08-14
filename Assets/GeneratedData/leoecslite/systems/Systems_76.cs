using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System76 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component404> _p1;
EcsPool<Component266> _p2;
EcsPool<Component279> _p3;
EcsPool<Component315> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component404>().Inc<Component266>().Inc<Component279>().Inc<Component315>().End();
   _p1 = _world.GetPool<Component404>();
   _p2 = _world.GetPool<Component266>();
   _p3 = _world.GetPool<Component279>();
   _p4 = _world.GetPool<Component315>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
