using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System44 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component40> _p1;
EcsPool<Component286> _p2;
EcsPool<Component250> _p3;
EcsPool<Component33> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component40>().Inc<Component286>().Inc<Component250>().Inc<Component33>().End();
   _p1 = _world.GetPool<Component40>();
   _p2 = _world.GetPool<Component286>();
   _p3 = _world.GetPool<Component250>();
   _p4 = _world.GetPool<Component33>();
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
