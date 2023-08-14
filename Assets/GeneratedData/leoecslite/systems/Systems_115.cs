using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System115 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component158> _p1;
EcsPool<Component226> _p2;
EcsPool<Component23> _p3;
EcsPool<Component146> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component158>().Inc<Component226>().Inc<Component23>().Inc<Component146>().End();
   _p1 = _world.GetPool<Component158>();
   _p2 = _world.GetPool<Component226>();
   _p3 = _world.GetPool<Component23>();
   _p4 = _world.GetPool<Component146>();
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
