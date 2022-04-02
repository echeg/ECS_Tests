using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System113 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component189> _p1;
EcsPool<Component462> _p2;
EcsPool<Component229> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component189>().Inc<Component462>().Inc<Component229>().End();
   _p1 = _world.GetPool<Component189>();
   _p2 = _world.GetPool<Component462>();
   _p3 = _world.GetPool<Component229>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
