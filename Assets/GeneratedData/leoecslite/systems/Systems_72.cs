using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System72 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component362> _p1;
EcsPool<Component256> _p2;
EcsPool<Component296> _p3;
EcsPool<Component271> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component362>().Inc<Component256>().Inc<Component296>().Inc<Component271>().End();
   _p1 = _world.GetPool<Component362>();
   _p2 = _world.GetPool<Component256>();
   _p3 = _world.GetPool<Component296>();
   _p4 = _world.GetPool<Component271>();
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
