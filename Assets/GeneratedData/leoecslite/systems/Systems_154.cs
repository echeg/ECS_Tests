using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System154 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component11> _p1;
EcsPool<Component38> _p2;
EcsPool<Component253> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component11>().Inc<Component38>().Inc<Component253>().End();
   _p1 = _world.GetPool<Component11>();
   _p2 = _world.GetPool<Component38>();
   _p3 = _world.GetPool<Component253>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
