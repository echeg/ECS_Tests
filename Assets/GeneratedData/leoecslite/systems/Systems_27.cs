using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System27 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component455> _p1;
EcsPool<Component176> _p2;
EcsPool<Component131> _p3;
EcsPool<Component338> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component455>().Inc<Component176>().Inc<Component131>().Inc<Component338>().End();
   _p1 = _world.GetPool<Component455>();
   _p2 = _world.GetPool<Component176>();
   _p3 = _world.GetPool<Component131>();
   _p4 = _world.GetPool<Component338>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
