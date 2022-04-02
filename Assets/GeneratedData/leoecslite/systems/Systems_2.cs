using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System2 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component292> _p1;
EcsPool<Component51> _p2;
EcsPool<Component405> _p3;
EcsPool<Component286> _p4;
EcsPool<Component396> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component292>().Inc<Component51>().Inc<Component405>().Inc<Component286>().End();
   _p1 = _world.GetPool<Component292>();
   _p2 = _world.GetPool<Component51>();
   _p3 = _world.GetPool<Component405>();
   _p4 = _world.GetPool<Component286>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component396>();
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
