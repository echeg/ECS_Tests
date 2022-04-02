using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System182 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component299> _p1;
EcsPool<Component208> _p2;
EcsPool<Component367> _p3;
EcsPool<Component360> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component299>().Inc<Component208>().Inc<Component367>().Inc<Component360>().End();
   _p1 = _world.GetPool<Component299>();
   _p2 = _world.GetPool<Component208>();
   _p3 = _world.GetPool<Component367>();
   _p4 = _world.GetPool<Component360>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
