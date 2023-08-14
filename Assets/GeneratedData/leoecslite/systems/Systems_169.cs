using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System169 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component184> _p1;
EcsPool<Component468> _p2;
EcsPool<Component344> _p3;
EcsPool<Component276> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component184>().Inc<Component468>().Inc<Component344>().Inc<Component276>().End();
   _p1 = _world.GetPool<Component184>();
   _p2 = _world.GetPool<Component468>();
   _p3 = _world.GetPool<Component344>();
   _p4 = _world.GetPool<Component276>();
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
