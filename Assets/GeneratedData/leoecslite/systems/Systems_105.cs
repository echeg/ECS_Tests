using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System105 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component250> _p1;
EcsPool<Component376> _p2;
EcsPool<Component249> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component250>().Inc<Component376>().Inc<Component249>().End();
   _p1 = _world.GetPool<Component250>();
   _p2 = _world.GetPool<Component376>();
   _p3 = _world.GetPool<Component249>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
