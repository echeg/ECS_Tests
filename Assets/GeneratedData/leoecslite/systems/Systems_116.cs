using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System116 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component244> _p1;
EcsPool<Component479> _p2;
EcsPool<Component71> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component244>().Inc<Component479>().Inc<Component71>().End();
   _p1 = _world.GetPool<Component244>();
   _p2 = _world.GetPool<Component479>();
   _p3 = _world.GetPool<Component71>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
