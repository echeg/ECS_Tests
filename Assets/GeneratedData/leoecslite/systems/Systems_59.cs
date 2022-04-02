using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System59 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component168> _p1;
EcsPool<Component97> _p2;
EcsPool<Component40> _p3;
EcsPool<Component490> _p4;
EcsPool<Component4> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component168>().Inc<Component97>().Inc<Component40>().Inc<Component490>().End();
   _p1 = _world.GetPool<Component168>();
   _p2 = _world.GetPool<Component97>();
   _p3 = _world.GetPool<Component40>();
   _p4 = _world.GetPool<Component490>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component4>();
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
