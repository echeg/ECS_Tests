using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System147 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component209> _p1;
EcsPool<Component376> _p2;
EcsPool<Component471> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component209>().Inc<Component376>().Inc<Component471>().End();
   _p1 = _world.GetPool<Component209>();
   _p2 = _world.GetPool<Component376>();
   _p3 = _world.GetPool<Component471>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
