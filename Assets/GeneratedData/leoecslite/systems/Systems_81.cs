using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System81 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component63> _p1;
EcsPool<Component83> _p2;
EcsPool<Component421> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component63>().Inc<Component83>().Inc<Component421>().End();
   _p1 = _world.GetPool<Component63>();
   _p2 = _world.GetPool<Component83>();
   _p3 = _world.GetPool<Component421>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
