using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System88 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component367> _p1;
EcsPool<Component209> _p2;
EcsPool<Component306> _p3;
EcsPool<Component394> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component367>().Inc<Component209>().Inc<Component306>().Inc<Component394>().End();
   _p1 = _world.GetPool<Component367>();
   _p2 = _world.GetPool<Component209>();
   _p3 = _world.GetPool<Component306>();
   _p4 = _world.GetPool<Component394>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
