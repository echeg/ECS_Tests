using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System79 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component237> _p1;
EcsPool<Component154> _p2;
EcsPool<Component221> _p3;
EcsPool<Component161> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component237>().Inc<Component154>().Inc<Component221>().Inc<Component161>().End();
   _p1 = _world.GetPool<Component237>();
   _p2 = _world.GetPool<Component154>();
   _p3 = _world.GetPool<Component221>();
   _p4 = _world.GetPool<Component161>();
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
