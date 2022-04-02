using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System170 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component198> _p1;
EcsPool<Component89> _p2;
EcsPool<Component63> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component198>().Inc<Component89>().Inc<Component63>().End();
   _p1 = _world.GetPool<Component198>();
   _p2 = _world.GetPool<Component89>();
   _p3 = _world.GetPool<Component63>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
