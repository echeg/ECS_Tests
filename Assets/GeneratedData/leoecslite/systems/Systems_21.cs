using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System21 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component226> _p1;
EcsPool<Component160> _p2;
EcsPool<Component236> _p3;
EcsPool<Component16> _p4;
EcsPool<Component468> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component226>().Inc<Component160>().Inc<Component236>().Inc<Component16>().End();
   _p1 = _world.GetPool<Component226>();
   _p2 = _world.GetPool<Component160>();
   _p3 = _world.GetPool<Component236>();
   _p4 = _world.GetPool<Component16>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component468>();
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
