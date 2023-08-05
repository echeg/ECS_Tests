using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System14 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component272> _p1;
EcsPool<Component169> _p2;
EcsPool<Component359> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component272>().Inc<Component169>().Inc<Component359>().End();
   _p1 = _world.GetPool<Component272>();
   _p2 = _world.GetPool<Component169>();
   _p3 = _world.GetPool<Component359>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
