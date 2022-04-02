using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System42 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component331> _p1;
EcsPool<Component405> _p2;
EcsPool<Component376> _p3;
EcsPool<Component452> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component331>().Inc<Component405>().Inc<Component376>().End();
   _p1 = _world.GetPool<Component331>();
   _p2 = _world.GetPool<Component405>();
   _p3 = _world.GetPool<Component376>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component452>();
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
