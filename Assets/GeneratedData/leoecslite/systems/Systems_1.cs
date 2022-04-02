using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System1 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component60> _p1;
EcsPool<Component63> _p2;
EcsPool<Component400> _p3;
EcsPool<Component488> _p4;
EcsPool<Component493> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component60>().Inc<Component63>().Inc<Component400>().Inc<Component488>().End();
   _p1 = _world.GetPool<Component60>();
   _p2 = _world.GetPool<Component63>();
   _p3 = _world.GetPool<Component400>();
   _p4 = _world.GetPool<Component488>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component493>();
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
