using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System134 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component77> _p1;
EcsPool<Component108> _p2;
EcsPool<Component342> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component77>().Inc<Component108>().Inc<Component342>().End();
   _p1 = _world.GetPool<Component77>();
   _p2 = _world.GetPool<Component108>();
   _p3 = _world.GetPool<Component342>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
