using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System56 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component133> _p1;
EcsPool<Component286> _p2;
EcsPool<Component353> _p3;
EcsPool<Component30> _p4;
EcsPool<Component265> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component133>().Inc<Component286>().Inc<Component353>().Inc<Component30>().End();
   _p1 = _world.GetPool<Component133>();
   _p2 = _world.GetPool<Component286>();
   _p3 = _world.GetPool<Component353>();
   _p4 = _world.GetPool<Component30>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component265>();
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
