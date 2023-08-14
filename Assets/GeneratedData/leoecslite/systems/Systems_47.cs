using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System47 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component358> _p1;
EcsPool<Component186> _p2;
EcsPool<Component10> _p3;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component358>().Inc<Component186>().Inc<Component10>().End();
   _p1 = _world.GetPool<Component358>();
   _p2 = _world.GetPool<Component186>();
   _p3 = _world.GetPool<Component10>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
