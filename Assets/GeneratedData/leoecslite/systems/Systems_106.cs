using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System106 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component453> _p1;
EcsPool<Component31> _p2;
EcsPool<Component10> _p3;
EcsPool<Component408> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component453>().Inc<Component31>().Inc<Component10>().Inc<Component408>().End();
   _p1 = _world.GetPool<Component453>();
   _p2 = _world.GetPool<Component31>();
   _p3 = _world.GetPool<Component10>();
   _p4 = _world.GetPool<Component408>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
