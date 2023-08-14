using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System11 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component274> _p1;
EcsPool<Component347> _p2;
EcsPool<Component6> _p3;
EcsPool<Component362> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component274>().Inc<Component347>().Inc<Component6>().Inc<Component362>().End();
   _p1 = _world.GetPool<Component274>();
   _p2 = _world.GetPool<Component347>();
   _p3 = _world.GetPool<Component6>();
   _p4 = _world.GetPool<Component362>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
