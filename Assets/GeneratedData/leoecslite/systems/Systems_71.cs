using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System71 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component155> _p1;
EcsPool<Component407> _p2;
EcsPool<Component188> _p3;
EcsPool<Component217> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component155>().Inc<Component407>().Inc<Component188>().Inc<Component217>().End();
   _p1 = _world.GetPool<Component155>();
   _p2 = _world.GetPool<Component407>();
   _p3 = _world.GetPool<Component188>();
   _p4 = _world.GetPool<Component217>();
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
