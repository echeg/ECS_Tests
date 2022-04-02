using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System102 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component31> _p1;
EcsPool<Component331> _p2;
EcsPool<Component169> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component31>().Inc<Component331>().Inc<Component169>().End();
   _p1 = _world.GetPool<Component31>();
   _p2 = _world.GetPool<Component331>();
   _p3 = _world.GetPool<Component169>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
