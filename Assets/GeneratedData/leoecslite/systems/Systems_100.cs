using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System100 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component51> _p1;
EcsPool<Component212> _p2;
EcsPool<Component105> _p3;
EcsPool<Component315> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component51>().Inc<Component212>().Inc<Component105>().Inc<Component315>().End();
   _p1 = _world.GetPool<Component51>();
   _p2 = _world.GetPool<Component212>();
   _p3 = _world.GetPool<Component105>();
   _p4 = _world.GetPool<Component315>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
