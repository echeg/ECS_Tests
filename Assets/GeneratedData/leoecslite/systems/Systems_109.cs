using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System109 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component479> _p1;
EcsPool<Component254> _p2;
EcsPool<Component11> _p3;
EcsPool<Component52> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component479>().Inc<Component254>().Inc<Component11>().Inc<Component52>().End();
   _p1 = _world.GetPool<Component479>();
   _p2 = _world.GetPool<Component254>();
   _p3 = _world.GetPool<Component11>();
   _p4 = _world.GetPool<Component52>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
