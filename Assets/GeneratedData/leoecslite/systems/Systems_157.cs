using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System157 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component181> _p1;
EcsPool<Component225> _p2;
EcsPool<Component64> _p3;
EcsPool<Component330> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component181>().Inc<Component225>().Inc<Component64>().Inc<Component330>().End();
   _p1 = _world.GetPool<Component181>();
   _p2 = _world.GetPool<Component225>();
   _p3 = _world.GetPool<Component64>();
   _p4 = _world.GetPool<Component330>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
