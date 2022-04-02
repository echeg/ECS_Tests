using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System119 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component198> _p1;
EcsPool<Component64> _p2;
EcsPool<Component92> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component198>().Inc<Component64>().Inc<Component92>().End();
   _p1 = _world.GetPool<Component198>();
   _p2 = _world.GetPool<Component64>();
   _p3 = _world.GetPool<Component92>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
