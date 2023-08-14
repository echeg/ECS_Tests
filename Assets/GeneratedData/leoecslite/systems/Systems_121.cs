using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System121 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component301> _p1;
EcsPool<Component6> _p2;
EcsPool<Component347> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component301>().Inc<Component6>().Inc<Component347>().End();
   _p1 = _world.GetPool<Component301>();
   _p2 = _world.GetPool<Component6>();
   _p3 = _world.GetPool<Component347>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
