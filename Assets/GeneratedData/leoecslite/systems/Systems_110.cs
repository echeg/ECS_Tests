using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System110 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component156> _p1;
EcsPool<Component490> _p2;
EcsPool<Component67> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component156>().Inc<Component490>().Inc<Component67>().End();
   _p1 = _world.GetPool<Component156>();
   _p2 = _world.GetPool<Component490>();
   _p3 = _world.GetPool<Component67>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
