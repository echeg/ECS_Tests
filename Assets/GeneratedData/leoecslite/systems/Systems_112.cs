using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System112 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component301> _p1;
EcsPool<Component351> _p2;
EcsPool<Component291> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component301>().Inc<Component351>().Inc<Component291>().End();
   _p1 = _world.GetPool<Component301>();
   _p2 = _world.GetPool<Component351>();
   _p3 = _world.GetPool<Component291>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
