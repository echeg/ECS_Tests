using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System185 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component150> _p1;
EcsPool<Component169> _p2;
EcsPool<Component381> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component150>().Inc<Component169>().Inc<Component381>().End();
   _p1 = _world.GetPool<Component150>();
   _p2 = _world.GetPool<Component169>();
   _p3 = _world.GetPool<Component381>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
