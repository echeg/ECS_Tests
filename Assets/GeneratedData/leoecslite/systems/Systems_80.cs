using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System80 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component402> _p1;
EcsPool<Component264> _p2;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component402>().Inc<Component264>().End();
   _p1 = _world.GetPool<Component402>();
   _p2 = _world.GetPool<Component264>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
