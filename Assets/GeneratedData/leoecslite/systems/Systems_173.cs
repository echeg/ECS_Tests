using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System173 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component404> _p1;
EcsPool<Component361> _p2;
EcsPool<Component92> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component404>().Inc<Component361>().Inc<Component92>().End();
   _p1 = _world.GetPool<Component404>();
   _p2 = _world.GetPool<Component361>();
   _p3 = _world.GetPool<Component92>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
