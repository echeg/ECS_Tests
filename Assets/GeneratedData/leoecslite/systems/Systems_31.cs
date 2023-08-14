using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System31 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component304> _p1;
EcsPool<Component496> _p2;
EcsPool<Component318> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component304>().Inc<Component496>().Inc<Component318>().End();
   _p1 = _world.GetPool<Component304>();
   _p2 = _world.GetPool<Component496>();
   _p3 = _world.GetPool<Component318>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
