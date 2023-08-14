using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System192 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component83> _p1;
EcsPool<Component397> _p2;
EcsPool<Component177> _p3;
EcsPool<Component271> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component83>().Inc<Component397>().Inc<Component177>().Inc<Component271>().End();
   _p1 = _world.GetPool<Component83>();
   _p2 = _world.GetPool<Component397>();
   _p3 = _world.GetPool<Component177>();
   _p4 = _world.GetPool<Component271>();
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
