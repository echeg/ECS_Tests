using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System37 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component307> _p1;
EcsPool<Component9> _p2;
EcsPool<Component52> _p3;
EcsPool<Component50> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component307>().Inc<Component9>().Inc<Component52>().Inc<Component50>().End();
   _p1 = _world.GetPool<Component307>();
   _p2 = _world.GetPool<Component9>();
   _p3 = _world.GetPool<Component52>();
   _p4 = _world.GetPool<Component50>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
