using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System183 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component348> _p1;
EcsPool<Component357> _p2;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component348>().Inc<Component357>().End();
   _p1 = _world.GetPool<Component348>();
   _p2 = _world.GetPool<Component357>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
