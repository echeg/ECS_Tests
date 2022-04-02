using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System16 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component215> _p1;
EcsPool<Component230> _p2;
EcsPool<Component271> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component215>().Inc<Component230>().End();
   _p1 = _world.GetPool<Component215>();
   _p2 = _world.GetPool<Component230>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component271>();
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
