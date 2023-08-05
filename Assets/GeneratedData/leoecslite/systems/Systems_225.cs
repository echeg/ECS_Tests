using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System225 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component264> _p1;
EcsPool<Component496> _p2;
EcsPool<Component173> _p3;
EcsPool<Component7> _p4;
EcsPool<Component407> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component264>().Inc<Component496>().Inc<Component173>().Inc<Component7>().End();
   _p1 = _world.GetPool<Component264>();
   _p2 = _world.GetPool<Component496>();
   _p3 = _world.GetPool<Component173>();
   _p4 = _world.GetPool<Component7>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component407>();
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
