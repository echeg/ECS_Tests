using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System102 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
EcsPool<Component483> _p2;
EcsPool<Component378> _p3;
EcsPool<Component72> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().Inc<Component483>().Inc<Component378>().Inc<Component72>().End();
   _p1 = _world.GetPool<Component13>();
   _p2 = _world.GetPool<Component483>();
   _p3 = _world.GetPool<Component378>();
   _p4 = _world.GetPool<Component72>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
