using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System24 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component306> _p1;
EcsPool<Component262> _p2;
EcsPool<Component179> _p3;
EcsPool<Component203> _p4;
EcsPool<Component18> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component306>().Inc<Component262>().Inc<Component179>().Inc<Component203>().End();
   _p1 = _world.GetPool<Component306>();
   _p2 = _world.GetPool<Component262>();
   _p3 = _world.GetPool<Component179>();
   _p4 = _world.GetPool<Component203>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component18>();
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
