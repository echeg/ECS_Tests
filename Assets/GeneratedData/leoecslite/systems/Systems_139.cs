using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System139 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component294> _p1;
EcsPool<Component160> _p2;
EcsPool<Component425> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component294>().Inc<Component160>().Inc<Component425>().End();
   _p1 = _world.GetPool<Component294>();
   _p2 = _world.GetPool<Component160>();
   _p3 = _world.GetPool<Component425>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
