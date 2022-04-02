using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System34 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component255> _p1;
EcsPool<Component315> _p2;
EcsPool<Component332> _p3;
EcsPool<Component6> _p4;
EcsPool<Component120> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component255>().Inc<Component315>().Inc<Component332>().Inc<Component6>().End();
   _p1 = _world.GetPool<Component255>();
   _p2 = _world.GetPool<Component315>();
   _p3 = _world.GetPool<Component332>();
   _p4 = _world.GetPool<Component6>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component120>();
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
