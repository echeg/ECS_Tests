using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System61 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component159> _p1;
EcsPool<Component171> _p2;
EcsPool<Component481> _p3;
EcsPool<Component487> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component159>().Inc<Component171>().Inc<Component481>().Inc<Component487>().End();
   _p1 = _world.GetPool<Component159>();
   _p2 = _world.GetPool<Component171>();
   _p3 = _world.GetPool<Component481>();
   _p4 = _world.GetPool<Component487>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
