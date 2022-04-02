using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System41 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component32> _p1;
EcsPool<Component398> _p2;
EcsPool<Component13> _p3;
EcsPool<Component110> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component32>().Inc<Component398>().Inc<Component13>().End();
   _p1 = _world.GetPool<Component32>();
   _p2 = _world.GetPool<Component398>();
   _p3 = _world.GetPool<Component13>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component110>();
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
