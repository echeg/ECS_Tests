using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System63 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component224> _p1;
EcsPool<Component203> _p2;
EcsPool<Component328> _p3;
EcsPool<Component109> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component224>().Inc<Component203>().Inc<Component328>().Inc<Component109>().End();
   _p1 = _world.GetPool<Component224>();
   _p2 = _world.GetPool<Component203>();
   _p3 = _world.GetPool<Component328>();
   _p4 = _world.GetPool<Component109>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
