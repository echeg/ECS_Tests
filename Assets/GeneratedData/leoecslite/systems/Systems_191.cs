using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System191 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component166> _p1;
EcsPool<Component468> _p2;
EcsPool<Component285> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component166>().Inc<Component468>().Inc<Component285>().End();
   _p1 = _world.GetPool<Component166>();
   _p2 = _world.GetPool<Component468>();
   _p3 = _world.GetPool<Component285>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
