using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System149 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component489> _p1;
EcsPool<Component9> _p2;
EcsPool<Component240> _p3;
EcsPool<Component180> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component489>().Inc<Component9>().Inc<Component240>().Inc<Component180>().End();
   _p1 = _world.GetPool<Component489>();
   _p2 = _world.GetPool<Component9>();
   _p3 = _world.GetPool<Component240>();
   _p4 = _world.GetPool<Component180>();
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
