using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System0 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component377> _p1;
EcsPool<Component91> _p2;
EcsPool<Component10> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component377>().Inc<Component91>().End();
   _p1 = _world.GetPool<Component377>();
   _p2 = _world.GetPool<Component91>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component10>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl0.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

}
