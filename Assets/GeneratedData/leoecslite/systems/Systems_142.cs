using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System142 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component444> _p1;
EcsPool<Component468> _p2;
EcsPool<Component128> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component444>().Inc<Component468>().Inc<Component128>().End();
   _p1 = _world.GetPool<Component444>();
   _p2 = _world.GetPool<Component468>();
   _p3 = _world.GetPool<Component128>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
