using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System129 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component458> _p1;
EcsPool<Component338> _p2;
EcsPool<Component264> _p3;
EcsPool<Component165> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component458>().Inc<Component338>().Inc<Component264>().Inc<Component165>().End();
   _p1 = _world.GetPool<Component458>();
   _p2 = _world.GetPool<Component338>();
   _p3 = _world.GetPool<Component264>();
   _p4 = _world.GetPool<Component165>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
