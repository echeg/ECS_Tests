using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System123 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component61> _p1;
EcsPool<Component273> _p2;
EcsPool<Component337> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component61>().Inc<Component273>().Inc<Component337>().End();
   _p1 = _world.GetPool<Component61>();
   _p2 = _world.GetPool<Component273>();
   _p3 = _world.GetPool<Component337>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
