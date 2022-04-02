using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System69 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component95> _p1;
EcsPool<Component166> _p2;
EcsPool<Component374> _p3;
EcsPool<Component428> _p4;
EcsPool<Component227> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component95>().Inc<Component166>().Inc<Component374>().Inc<Component428>().End();
   _p1 = _world.GetPool<Component95>();
   _p2 = _world.GetPool<Component166>();
   _p3 = _world.GetPool<Component374>();
   _p4 = _world.GetPool<Component428>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component227>();
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
