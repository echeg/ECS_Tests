using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System97 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component206> _p1;
EcsPool<Component255> _p2;
EcsPool<Component189> _p3;
EcsPool<Component379> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component206>().Inc<Component255>().Inc<Component189>().Inc<Component379>().End();
   _p1 = _world.GetPool<Component206>();
   _p2 = _world.GetPool<Component255>();
   _p3 = _world.GetPool<Component189>();
   _p4 = _world.GetPool<Component379>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
