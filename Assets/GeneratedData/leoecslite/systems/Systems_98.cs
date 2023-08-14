using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System98 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component311> _p1;
EcsPool<Component446> _p2;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component311>().Inc<Component446>().End();
   _p1 = _world.GetPool<Component311>();
   _p2 = _world.GetPool<Component446>();
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
