using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System131 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component174> _p1;
EcsPool<Component308> _p2;
EcsPool<Component418> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component174>().Inc<Component308>().Inc<Component418>().End();
   _p1 = _world.GetPool<Component174>();
   _p2 = _world.GetPool<Component308>();
   _p3 = _world.GetPool<Component418>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
