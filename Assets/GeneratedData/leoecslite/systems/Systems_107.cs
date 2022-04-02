using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System107 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component287> _p1;
EcsPool<Component352> _p2;
EcsPool<Component97> _p3;
EcsPool<Component250> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component287>().Inc<Component352>().Inc<Component97>().Inc<Component250>().End();
   _p1 = _world.GetPool<Component287>();
   _p2 = _world.GetPool<Component352>();
   _p3 = _world.GetPool<Component97>();
   _p4 = _world.GetPool<Component250>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
